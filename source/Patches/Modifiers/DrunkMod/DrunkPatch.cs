using HarmonyLib;
using System;
using TownOfUs.Roles.Modifiers;
using TownOfUs.Patches.Roles.Modifiers;

namespace TownOfUs.Patches.Modifiers.DrunkMod
{
    public class DrunkPatch
    {
        [HarmonyPatch(typeof(PlayerPhysics), nameof(PlayerPhysics.FixedUpdate))]
        public static class PlayerPhysics_FixedUpdate
        {
            public static void Postfix(PlayerPhysics __instance)
            {
                if (__instance.myPlayer.Is(ModifierEnum.Drunk))
                    if (__instance.AmOwner && GameData.Instance && __instance.myPlayer.CanMove)
                        if (!(Modifier.GetModifier<Drunk>(__instance.myPlayer).RoundsLeft <= 0))
                            __instance.body.velocity *= -1;
            }
        }
    }
}
