using HarmonyLib;
using TownOfUs.Roles;

namespace TownOfUs.Patches.ImpostorRoles.WraithMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    [HarmonyPriority(Priority.Last)]
    public class WallWalkUnWallWalk
    {
        [HarmonyPriority(Priority.Last)]
        public static void Postfix(HudManager __instance)
        {
            foreach (var role in Role.GetRoles(RoleEnum.Wraith))
            {
                var noclip = (Wraith)role;
                if (noclip.Noclipped)
                    noclip.WallWalk();
                else if (noclip.Enabled) noclip.UnWallWalk();
            }
        }
    }
}
