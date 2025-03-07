using HarmonyLib;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Reactor.Utilities;

namespace TownOfUs.CrewmateRoles.JailorMod
{
    [HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.Start))]
    public class JailNotificationAnimation
    {
        public static Sprite CellSprite => TownOfUs.InJailSprite;

        public static IEnumerator JailShhh()
        {
            yield return HudManager.Instance.CoFadeFullScreen(Color.clear, new Color(0f, 0f, 0f, 0.98f));

            GameObject jailBars = new GameObject("JailBars");

            Image jailBarsImage = jailBars.AddComponent<Image>();

            jailBarsImage.sprite = CellSprite;

            jailBarsImage.preserveAspect = true;

            RectTransform rect = jailBars.GetComponent<RectTransform>();

            rect.anchorMin = new Vector2(0, 0);

            rect.anchorMax = new Vector2(1, 1);

            rect.offsetMin = Vector2.zero;

            rect.offsetMax = Vector2.zero;

            jailBars.transform.SetParent(HudManager.Instance.FullScreen.transform, false);

            RectTransform parentRect = HudManager.Instance.FullScreen.GetComponent<RectTransform>();

            float scaleX = parentRect.rect.width / 100f;

            float scaleY = parentRect.rect.height / 100f;

            rect.localScale = new Vector3(scaleX, scaleY, 1f);

            Vector3 tempPosition = HudManager.Instance.shhhEmblem.transform.localPosition;

            float tempDuration = HudManager.Instance.shhhEmblem.HoldDuration;

            HudManager.Instance.shhhEmblem.transform.localPosition = new Vector3(
                HudManager.Instance.shhhEmblem.transform.localPosition.x,
                HudManager.Instance.shhhEmblem.transform.localPosition.y,
                HudManager.Instance.FullScreen.transform.position.z + 1f
            );

            HudManager.Instance.shhhEmblem.TextImage.text = "YOU ARE JAILED";

            HudManager.Instance.shhhEmblem.HoldDuration = 2.5f;

            yield return HudManager.Instance.ShowEmblem(true);

            HudManager.Instance.shhhEmblem.transform.localPosition = tempPosition;

            HudManager.Instance.shhhEmblem.HoldDuration = tempDuration;

            Object.Destroy(jailBars);

            yield return HudManager.Instance.CoFadeFullScreen(new Color(0f, 0f, 0f, 0.98f), Color.clear);

            yield return null;
        }

        [HarmonyPostfix]
        public static void Postfix(MeetingHud __instance)
        {
            if (PlayerControl.LocalPlayer != null && PlayerControl.LocalPlayer.IsJailed())
            {
                Coroutines.Start(JailShhh());
            }
        }
    }
}
