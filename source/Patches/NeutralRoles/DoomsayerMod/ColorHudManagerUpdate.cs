using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.Patches.NeutralRoles.DoomsayerMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public static class ColorHudManagerUpdate
    {
        [HarmonyPriority(Priority.Last)]
        public static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Doomsayer)) return;
            var role = Role.GetRole<Doomsayer>(PlayerControl.LocalPlayer);

            if (!PlayerControl.LocalPlayer.IsHypnotised())
            {
                foreach (var player in PlayerControl.AllPlayerControls)
                {
                    if (!role.LastObservedPlayers.Contains(player)) continue;
                    player.nameText().color = Color.magenta;
                }
            }
        }
    }
}
