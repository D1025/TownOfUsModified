using HarmonyLib;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace TownOfUs.Patches
{
    [HarmonyPatch]
    public static class AprilFoolsModeViewPatch
    {
        static void ShowAprilFoolsModeView()
        {
            if (DateTime.Now.Month == 4 && DateTime.Now.Day == 1)
            {
                Canvas canvas = Object.FindObjectOfType<Canvas>();
                if (canvas != null)
                {
                    GameObject panel = new GameObject("AprilFoolsModePanel");
                    panel.transform.SetParent(canvas.transform, false);
                    RectTransform rt = panel.AddComponent<RectTransform>();
                    rt.anchorMin = new Vector2(0, 0);
                    rt.anchorMax = new Vector2(1, 1);
                    rt.offsetMin = Vector2.zero;
                    rt.offsetMax = Vector2.zero;

                    Image bg = panel.AddComponent<Image>();
                    bg.color = new Color(0, 0, 0, 0.7f);

                    GameObject textObj = new GameObject("AprilFoolsModeText");
                    textObj.transform.SetParent(panel.transform, false);
                    RectTransform rtText = textObj.AddComponent<RectTransform>();
                    rtText.anchorMin = new Vector2(0.5f, 0.5f);
                    rtText.anchorMax = new Vector2(0.5f, 0.5f);
                    rtText.anchoredPosition = Vector2.zero;
                    TextMeshProUGUI text = textObj.AddComponent<TextMeshProUGUI>();
                    text.alignment = TextAlignmentOptions.Center;
                    text.fontSize = 60;
                    text.text = GetAprilFoolsModeMessage();
                    text.color = Color.magenta;

                    panel.AddComponent<AprilFoolsPanelFadeOut>();
                }
            }
        }

        private static string GetAprilFoolsModeMessage()
        {
            if (CustomGameOptions.SheriffBomberMode)
                return "Prima Aprilis: Let Play With Bombs";
            if (CustomGameOptions.AllDrunk)
                return "Prima Aprilis: Who Got Free Beer?";
            if (CustomGameOptions.AllSameModifier)
                return "Prima Aprilis: We Have Same Modifier!";
            if (CustomGameOptions.AllVent)
                return "Prima Aprilis: All Can Vent!";
            return "Prima Aprilis: Standard Mode!";
        }

        [HarmonyPatch(typeof(IntroCutscene), "BeginCrewmate")]
        public static class IntroCutscene_BeginCrewmate_AprilFools
        {
            public static void Prefix() => ShowAprilFoolsModeView();
        }

        [HarmonyPatch(typeof(IntroCutscene), "BeginImpostor")]
        public static class IntroCutscene_BeginImpostor_AprilFools
        {
            public static void Prefix() => ShowAprilFoolsModeView();
        }
    }

    public class AprilFoolsPanelFadeOut : MonoBehaviour
    {
        public float Duration = 3f;
        private float timer = 0f;
        private CanvasGroup canvasGroup;

        void Start()
        {
            canvasGroup = gameObject.AddComponent<CanvasGroup>();
            canvasGroup.alpha = 1f;
        }

        void Update()
        {
            timer += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(1f, 0f, timer / Duration);
            if (timer >= Duration)
            {
                Destroy(gameObject);
            }
        }
    }
}
