using System;
using AmongUs.GameOptions;
using HarmonyLib;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.Patches.NeutralRoles.WraithMod
{

    [HarmonyPatch(typeof(KillButton), nameof(KillButton.DoClick))]
    public class PerformKill
    {
        public static Sprite Noclip => TownOfUs.NoclipSprite;

        public static bool Prefix(KillButton __instance)
        {
            //var lp = PlayerControl.LocalPlayer;
            var flag = PlayerControl.LocalPlayer.Is(RoleEnum.Wraith);
            if (!flag) return true;
            if (!PlayerControl.LocalPlayer.CanMove) return false;
            if (PlayerControl.LocalPlayer.Data.IsDead) return false;
            var role = Role.GetRole<Wraith>(PlayerControl.LocalPlayer);
            DoClickKillButton(__instance, role);
            if (__instance == role.NoclipButton)
            {
                if (role.Player.inVent) return false;
                if (!__instance.isActiveAndEnabled || __instance.isCoolingDown) return false;
                //if (role.NoclipActive) return false;
                var abilityUsed = Utils.AbilityUsed(PlayerControl.LocalPlayer);
                if (!abilityUsed) return false;
                role.NoclipSafePoint = PlayerControl.LocalPlayer.transform.position;
                role.TimeRemaining = CustomGameOptions.WraithDuration;
                role.WallWalk();
                return false;
            }
            if (role.NoclipTimer() != 0) return false;
            if (!role.Noclipped) return false;

            return true;
        }

        private static bool DoClickKillButton(KillButton __instance, Wraith role)
        {
            if (role.KillTimer() != 0) return false;
            if (__instance != DestroyableSingleton<HudManager>.Instance.KillButton) return true;
            if (!__instance.isActiveAndEnabled || __instance.isCoolingDown) return false;
            if (role.ClosestPlayer == null) return false;
            var distBetweenPlayers = Utils.GetDistBetweenPlayers(PlayerControl.LocalPlayer, role.ClosestPlayer);
            var flag3 = distBetweenPlayers <
                        GameOptionsData.KillDistances[GameOptionsManager.Instance.currentNormalGameOptions.KillDistance];
            if (!flag3) return false;

            var interact = Utils.Interact(PlayerControl.LocalPlayer, role.ClosestPlayer, true);
            if (interact[4] == true) return false;
            else if (interact[0] == true)
            {
                role.LastKilled = DateTime.UtcNow;
                return false;
            }
            else if (interact[1] == true)
            {
                role.LastKilled = DateTime.UtcNow;
                role.LastKilled = role.LastKilled.AddSeconds(CustomGameOptions.ProtectKCReset - CustomGameOptions.WraithKillCd);
                return false;
            }
            else if (interact[2] == true)
            {
                role.LastKilled = DateTime.UtcNow;
                role.LastKilled = role.LastKilled.AddSeconds(CustomGameOptions.VestKCReset - CustomGameOptions.WraithKillCd);
                return false;
            }
            else if (interact[3] == true) return false;
            return false;
        }
    }
}
