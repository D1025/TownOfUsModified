using Il2CppInterop.Runtime.Attributes;
using Reactor.Utilities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;

namespace TownOfUs.Patches.Lobby
{
    [RegisterInIl2Cpp]
    public class VitalsPagingBehaviour : AbstractPagingBehaviour
    {
        public VitalsPagingBehaviour(IntPtr ptr) : base(ptr) { }

        public VitalsMinigame vitalsMinigame = null!;

        [HideFromIl2Cpp]
        public IEnumerable<VitalsPanel> Targets => vitalsMinigame.vitals.ToArray();
        public int PlayerCount => Targets.Count();
        public override int MaxPageIndex => (Targets.Count() - 1) / MaxPerPage;

        //public override void Start()
        //{
        //    PageText = Instantiate(HudManager.Instance.KillButton.cooldownTimerText, vitalsMinigame.transform);
        //    PageText.name = PAGE_INDEX_GAME_OBJECT_NAME;
        //    PageText.enableWordWrapping = false;
        //    PageText.gameObject.SetActive(true);
        //    PageText.transform.localPosition = new Vector3(2.7f, -2f, -1f);
        //    PageText.transform.localScale *= 0.5f;
        //    OnPageChanged();
        //}

        public override void OnPageChanged()
        {
            var i = 0;

            foreach (var panel in Targets)
            {
                if (PlayerCount > 15)
                {
                    panel.gameObject.SetActive(true);

                    var relativeIndex = i % MaxPerPage;
                    var row = relativeIndex / 4;
                    var col = relativeIndex % 4;
                    var panelTransform = panel.transform;
                    panelTransform.localScale = new UnityEngine.Vector3(
                            0.75f,
                            0.75f,
                            0.75f
                        );
                    panelTransform.localPosition =
                                              new UnityEngine.Vector3(
                                                  vitalsMinigame.XStart + vitalsMinigame.XOffset * 0.75f * col - 0.6f,
                                                  vitalsMinigame.YStart + vitalsMinigame.YOffset * 0.75f * row,
                                                  panelTransform.localPosition.z * 0.75f
                                              );
                }
                else
                {
                    panel.gameObject.SetActive(true);
                    var relativeIndex = i % MaxPerPage;
                    var row = relativeIndex / 3;
                    var col = relativeIndex % 3;
                    var panelTransform = panel.transform;
                    panelTransform.localPosition =
                                              new UnityEngine.Vector3(
                                                        vitalsMinigame.XStart + vitalsMinigame.XOffset * col,
                                                        vitalsMinigame.YStart + vitalsMinigame.YOffset * row,
                                                  panelTransform.localPosition.z
                                              );
                }
                i++;
            }
        }
    }
}
