using HarmonyLib;
using System;
using System.Collections.Generic;
using TownOfUs.CrewmateRoles.ImitatorMod;
using TownOfUs.Extensions;
using TownOfUs.Roles;

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
                        DestroyableSingleton<HudManager>.Instance.Chat.AddChat(PlayerControl.LocalPlayer, roleResults);
                }
                doomsayerRole.LastObservedPlayers.Clear();
            }
        }

        public static string PlayerReportFeedback(PlayerControl player)
        {
            RoleEnum role = GetPlayerRole(player);
            if (role == RoleEnum.Crewmate || role == RoleEnum.Impostor)
                return $"You observe that {player.GetDefaultOutfit().PlayerName} appears to be roleless";
            return $"You observe that {player.GetDefaultOutfit().PlayerName} has characteristics related to {role}";
        }

        public static string RoleReportFeedback(PlayerControl player)
        {
            RoleEnum actualRole = GetPlayerRole(player);
            if (actualRole == RoleEnum.None) return "Error";
            List<RoleEnum> activeRoles = new List<RoleEnum>();
            foreach (RoleEnum role in Enum.GetValues(typeof(RoleEnum)))
            {
                if (role == RoleEnum.None) continue;
                if (IsRoleActive(role))
                    activeRoles.Add(role);
            }
            activeRoles.Remove(actualRole);
            List<RoleEnum> randomRoles = new List<RoleEnum>();
            Random rnd = new Random();
            int countToPick = Math.Min(CustomGameOptions.DoomsayerObserveRoleCount, activeRoles.Count);
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
            string result = $"({actualRole}";
            foreach (var r in randomRoles)
                result += $", {r}";
            result += ")";
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
            if (value is int intValue)
                return intValue > 0;
            return false;
        }
    }
}
