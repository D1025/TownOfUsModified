using System;
using BepInEx.Unity.IL2CPP.Utils;
using HarmonyLib;
using TownOfUs.CrewmateRoles.InvestigatorMod;
using TownOfUs.Roles;
using System.Collections.Generic;
using UnityEngine;

namespace TownOfUs.Patches.CrewmateRoles.SpyMod
{
    [HarmonyPatch(typeof(KillButton), nameof(KillButton.DoClick))]
    internal class PerformKill
    {
        public static bool Prefix(KillButton __instance)
        {
            if (__instance != DestroyableSingleton<HudManager>.Instance.KillButton) return true;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Spy)) return true;
            var role = Role.GetRole<Spy>(PlayerControl.LocalPlayer);
            if (!PlayerControl.LocalPlayer.CanMove) return false;
            if (role.SpyTimer() != 0f) return false;
            if (!__instance.enabled) return false;

            role.LastCheckAdmin = DateTime.UtcNow;
            if (!__instance.isActiveAndEnabled) return false;
            DestroyableSingleton<HudManager>.Instance.ToggleMapVisible(new MapOptions
            {
                Mode = MapOptions.Modes.CountOverlay
            });
            PlayerControl.LocalPlayer.NetTransform.Halt();
            return false;
        }
    }
}
