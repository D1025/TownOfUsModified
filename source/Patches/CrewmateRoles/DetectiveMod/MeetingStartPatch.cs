using HarmonyLib;
using TownOfUs.Roles;

namespace TownOfUs.CrewmateRoles.DetectiveMod
{
    [HarmonyPatch(typeof(MeetingHud), "Start")]
    public class MeetingStartPatch
    {
        public static void Postfix(MeetingHud __instance)
        {
            if (PlayerControl.LocalPlayer != null && PlayerControl.LocalPlayer.Is(RoleEnum.Detective))
            {
                var detective = Role.GetRole<Detective>(PlayerControl.LocalPlayer);
                if (!string.IsNullOrEmpty(detective.StoredReport))
                {
                    if (DestroyableSingleton<HudManager>.Instance != null)
                    {
                        DestroyableSingleton<HudManager>.Instance.Chat.AddChat(PlayerControl.LocalPlayer, detective.StoredReport);
                    }
                    detective.StoredReport = "";
                }
            }
        }
    }
}
