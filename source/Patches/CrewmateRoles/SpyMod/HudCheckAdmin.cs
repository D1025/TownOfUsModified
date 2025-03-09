using HarmonyLib;
using TownOfUs.Roles;

namespace TownOfUs.Patches.CrewmateRoles.SpyMod
{
    [HarmonyPatch(typeof(HudManager))]
    internal class HudCheckAdmin
    {
        [HarmonyPatch(nameof(HudManager.Update))]
        public static void Postfix(HudManager __instance)
        {
            UpdateSpyButton(__instance);
        }

        public static void UpdateSpyButton(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Spy)) return;
            if (!CustomGameOptions.SpyAdminAnywhere) return;
            var role = Role.GetRole<Spy>(PlayerControl.LocalPlayer);


            var investigateButton = __instance.KillButton;

            investigateButton.gameObject.SetActive((__instance.UseButton.isActiveAndEnabled || __instance.PetButton.isActiveAndEnabled)
                && !MeetingHud.Instance && !PlayerControl.LocalPlayer.Data.IsDead
                && AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Started);
            investigateButton.SetCoolDown(role.SpyTimer(), CustomGameOptions.SpyAdminTableCd);
        }
    }
}
