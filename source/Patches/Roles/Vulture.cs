using System;
using System.Collections.Generic;
using System.Linq;
using Object = UnityEngine.Object;

namespace TownOfUs.Roles
{
    public class Vulture : Role
    {
        public KillButton _cleanButton;
        public int eatenBodies = 0;
        public bool vultureWin = false;
        public Dictionary<byte, ArrowBehaviour> BodyArrows = new Dictionary<byte, ArrowBehaviour>();
        public DateTime LastEaten { get; set; }
        public TMPro.TextMeshPro EatCountText;

        public Vulture(PlayerControl player) : base(player)
        {
            Name = "Vulture";
            ImpostorText = () => "Eat the corpses";
            TaskText = () => "Eat enough corpses to win";
            Color = Patches.Colors.Vulture;
            RoleType = RoleEnum.Vulture;
            AddToRoleHistory(RoleType);
            Faction = Faction.NeutralEvil;
        }

        public DeadBody CurrentTarget { get; set; }

        public KillButton CleanButton
        {
            get => _cleanButton;
            set
            {
                _cleanButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }

        protected override void IntroPrefix(IntroCutscene._ShowTeam_d__38 __instance)
        {
            var scTeam = new Il2CppSystem.Collections.Generic.List<PlayerControl>();
            scTeam.Add(PlayerControl.LocalPlayer);
            __instance.teamToShow = scTeam;
        }

        internal override bool GameEnd(LogicGameFlowNormal __instance)
        {
            if (Player.Data.IsDead) return true;
            if (!CustomGameOptions.NeutralEvilWinEndsGame) return true;
            if (eatenBodies < CustomGameOptions.VultureEatCount) return true;
            Utils.Rpc(CustomRPC.VultureWin, Player.PlayerId);
            Wins();
            Utils.EndGame();
            return false;
        }

        public void Wins()
        {
            vultureWin = true;
        }

        public void DestroyArrow(byte targetPlayerId)
        {
            var arrow = BodyArrows.FirstOrDefault(x => x.Key == targetPlayerId);
            if (arrow.Value != null) Object.Destroy(arrow.Value);
            if (arrow.Value.gameObject != null) Object.Destroy(arrow.Value.gameObject);
            BodyArrows.Remove(arrow.Key);
        }

        public float VultureTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastEaten;
            var num = CustomGameOptions.VultureKillCooldown * 1000f;
            var flag2 = num - (float)timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float)timeSpan.TotalMilliseconds) / 1000f;
        }
    }
}
