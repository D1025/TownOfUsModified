using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using TownOfUs.CrewmateRoles.ImitatorMod;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using UnityEngine;
using Random = System.Random;

namespace TownOfUs.NeutralRoles.DoomsayerMod
{
    [HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.Start))]
    public class MeetingStart
    {
        public static void Postfix(MeetingHud __instance)
        {
            if (PlayerControl.LocalPlayer.Data.IsDead) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Doomsayer)) return;
            var doomsayerRole = Role.GetRole<Doomsayer>(PlayerControl.LocalPlayer);
            if (doomsayerRole.LastObservedPlayers.Count > 0 && !CustomGameOptions.DoomsayerCantObserve)
            {
                foreach (var observed in doomsayerRole.LastObservedPlayers)
                {
                    var roleResults = RoleReportFeedback(observed);
                    if (!string.IsNullOrWhiteSpace(roleResults))
                        DestroyableSingleton<HudManager>.Instance.Chat.AddChat(PlayerControl.LocalPlayer, $"You observe that {observed.GetDefaultOutfit().PlayerName} has characteristics related to {roleResults}");
                }
                doomsayerRole.LastObservedPlayers.Clear();
            }
        }

        public static string RoleReportFeedback(PlayerControl player)
        {
            RoleEnum actualRole = GetPlayerRole(player);
            if (actualRole == RoleEnum.None) return "Error";

            List<RoleEnum> activeRoles = new List<RoleEnum>();
            foreach (RoleEnum role in Enum.GetValues(typeof(RoleEnum)))
            {
                if (role == RoleEnum.None || role == actualRole) continue;
                if (IsRoleActive(role))
                    activeRoles.Add(role);
            }

            Random rnd = new Random();
            List<RoleEnum> randomRoles = new List<RoleEnum> { actualRole };

            int countToPick = Math.Min(CustomGameOptions.DoomsayerObserveRoleCount - 1, activeRoles.Count);
            for (int i = 0; i < countToPick; i++)
            {
                int index = rnd.Next(activeRoles.Count);
                randomRoles.Add(activeRoles[index]);
                activeRoles.RemoveAt(index);
            }

            while (randomRoles.Count < CustomGameOptions.DoomsayerObserveRoleCount)
            {
                randomRoles.Add(RoleEnum.Crewmate);
            }

            randomRoles = randomRoles.OrderBy(x => rnd.Next()).ToList();

            string result = $"({string.Join(", ", randomRoles)})";
            return result;
        }

        private static RoleEnum GetPlayerRole(PlayerControl player)
        {
            foreach (RoleEnum role in Enum.GetValues(typeof(RoleEnum)))
            {
                if (role == RoleEnum.None) continue;
                if (player.Is(role))
                    return role;
            }
            return RoleEnum.None;
        }

        private static bool IsRoleActive(RoleEnum role)
        {
            string propertyName = role.ToString() + "On";
            var prop = typeof(CustomGameOptions).GetProperty(propertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            if (prop == null) return false;
            object value = prop.GetValue(null);
            if (value is bool boolValue)
                return boolValue;
            return false;
        }
    }
}
