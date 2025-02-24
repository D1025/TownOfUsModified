using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownOfUs.Patches.Lobby;

namespace TownOfUs.Patches
{
    internal static class PagingPatches
    {
        [HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.Start))]
        public static class MeetingHudStartPatch
        {
            public static void Postfix(MeetingHud __instance)
            {
                __instance.gameObject.AddComponent<MeetingHudPagingBehaviour>().meetingHud = __instance;
            }
        }

        [HarmonyPatch(typeof(VitalsMinigame), nameof(VitalsMinigame.Begin))]
        public static class VitalsMinigameBeginPatch
        {
            public static void Postfix(VitalsMinigame __instance)
            {
                __instance.gameObject.AddComponent<VitalsPagingBehaviour>().vitalsMinigame = __instance;
            }
        }

        //[HarmonyPatch(typeof(ShapeshifterMinigame), nameof(ShapeshifterMinigame.Begin))]
        //public static class ShapeshifterMinigameBeginPatch
        //{
        //    public static void Postfix(ShapeshifterMinigame __instance)
        //    {
        //        __instance.gameObject.AddComponent<ShapeShifterPagingBehaviour>().shapeshifterMinigame = __instance;
        //    }
        //}

        //[HarmonyPatch(typeof(VitalsMinigame), nameof(VitalsMinigame.Begin))]
        //public static class VitalsMinigameBeginPatch
        //{
        //    public static void Postfix(VitalsMinigame __instance)
        //    {
        //        __instance.gameObject.AddComponent<VitalsPagingBehaviour>().vitalsMinigame = __instance;
        //    }
        //}
    }
}