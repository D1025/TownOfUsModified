using System;
using HarmonyLib;
using TownOfUs.Roles;

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

            var adminOverlay = UnityEngine.Object.FindObjectOfType<MapCountOverlay>();
            if (adminOverlay != null)
            {
                adminOverlay.gameObject.SetActive(true);
            }
            return false;
        }
    }
}
