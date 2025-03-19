using HarmonyLib;
using System.Linq;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using static UnityEngine.ParticleSystem.PlaybackState;

namespace TownOfUs.NeutralRoles.DoomsayerMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public static class HudManagerUpdate
    {
        public static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Doomsayer)) return;
            var role = Role.GetRole<Doomsayer>(PlayerControl.LocalPlayer);

            __instance.KillButton.gameObject.SetActive((__instance.UseButton.isActiveAndEnabled || __instance.PetButton.isActiveAndEnabled)
                    && !MeetingHud.Instance && !PlayerControl.LocalPlayer.Data.IsDead
                    && AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Started && !CustomGameOptions.DoomsayerCantObserve);

            __instance.KillButton.SetCoolDown(role.ObserveTimer(), CustomGameOptions.ObserveCooldown);

            var notObserved = PlayerControl.AllPlayerControls
                .ToArray()
                .Where(x => !role.LastObservedPlayers.Contains(x))
                .ToList();

            Utils.SetTarget(ref role.ClosestPlayer, __instance.KillButton, float.NaN, notObserved);
        }
    }
}