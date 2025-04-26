using UnityEngine;
using TMPro;
using System.Collections;
using HarmonyLib;
using BepInEx.Unity.IL2CPP.Utils.Collections;
using Il2CppSystem.Web.Util;

namespace TownOfUs.Patches
{
    [HarmonyPatch(typeof(IntroCutscene), nameof(IntroCutscene.ShowTeam))]
    class AprilFoolsMessagePatch
    {
        private static TMPro.TextMeshPro feedText;

        [HarmonyPostfix]
        public static void Postfix(IntroCutscene __instance, ref Il2CppSystem.Collections.IEnumerator __result)
        {
            var newEnumerator = new PatchedEnumerator()
            {
                enumerator = __result.WrapToManaged(),
                Postfix = ShowModeMessage(__instance)
            };
            __result = newEnumerator.GetEnumerator().WrapToIl2Cpp();
        }

        private static IEnumerator ShowModeMessage(IntroCutscene __instance)
        {
            feedText = UnityEngine.Object.Instantiate(__instance.TeamTitle, __instance.transform);
            var aspectPosition = feedText.gameObject.AddComponent<AspectPosition>();
            aspectPosition.Alignment = AspectPosition.EdgeAlignments.Left;
            aspectPosition.DistanceFromEdge = new Vector2(5.5f, 1.2f);
            aspectPosition.AdjustPosition();
            feedText.transform.localScale = new Vector3(1f, 1f, 1);
            feedText.text = $"<size=280%>{GetAprilFoolsModeMessage()}</size>\n\n";
            feedText.alignment = TMPro.TextAlignmentOptions.Center;
            feedText.autoSizeTextContainer = true;
            feedText.fontSize = 3f;
            feedText.enableAutoSizing = false;
            feedText.color = Color.white;
            var title = __instance.TeamTitle.text;
            __instance.TeamTitle.text = "";
            __instance.BackgroundBar.enabled = false;
            __instance.ImpostorText.gameObject.SetActive(false);
            GameObject.Find("BackgroundLayer")?.SetActive(false);
            foreach (var player in UnityEngine.Object.FindObjectsOfType<PoolablePlayer>())
            {
                if (player.name.Contains("Dummy"))
                {
                    player.gameObject.SetActive(false);
                }
            }
            __instance.FrontMost.gameObject.SetActive(false);


            yield return new WaitForSeconds(3f);
            UnityEngine.Object.Destroy(feedText.gameObject);
            foreach (var player in UnityEngine.Object.FindObjectsOfType<PoolablePlayer>())
            {
                if (player.name.Contains("Dummy"))
                {
                    player.gameObject.SetActive(true);
                }
            }
            __instance.FrontMost.gameObject.SetActive(true);
            __instance.TeamTitle.text = title;
            __instance.BackgroundBar.enabled = true;
            __instance.BackgroundBar.enabled = true;
        }

        private static string GetAprilFoolsModeMessage()
        {
            if (CustomGameOptions.SheriffBomberMode)
                return "Mode:\nLet Play With Bombs";
            if (CustomGameOptions.AllSameModifier)
                return "Mode:\nWe Have Same Modifier!";
            if (CustomGameOptions.AllVent)
                return "Modes:\nAll Can Vent!";
            return "Mode:\nStandard Mode!";
        }

        class PatchedEnumerator : IEnumerable
        {
            public IEnumerator enumerator;
            public IEnumerator Postfix;
            public IEnumerator GetEnumerator()
            {
                while (enumerator.MoveNext())
                    yield return enumerator.Current;
                if ((CustomGameOptions.SheriffBomberMode || CustomGameOptions.AllSameModifier || CustomGameOptions.AllVent))
                    while (Postfix.MoveNext())
                        yield return Postfix.Current;
            }
        }

        public static string cs(Color c, string s)
        {
            return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), s);
        }

        private static byte ToByte(float f)
        {
            f = Mathf.Clamp01(f);
            return (byte)(f * 255);
        }
    }
}
