using System;
using System.Linq;
using TownOfUs.Extensions;
using UnityEngine;


namespace TownOfUs.Roles
{
    public class Wraith : Role
    {
        private KillButton _noclipButton;
        public DateTime LastNoclip;
        public bool Enabled;
        public Vector3 NoclipSafePoint = new();
        public float TimeRemaining;
        public PlayerControl ClosestPlayer;
        public DateTime LastKilled { get; set; }

        public bool WraithWins { get; set; }

        public Wraith(PlayerControl player) : base(player)
        {
            Name = "Wraith";
            ImpostorText = () => "Walk Through Walls and Kill Your Enemies";
            TaskText = () => "Use your power to surprise your enemies";
            Color = Patches.Colors.Wraith;
            LastKilled = DateTime.UtcNow;
            RoleType = RoleEnum.Wraith;
            AddToRoleHistory(RoleType);
            Faction = Faction.NeutralKilling;

        }

        public KillButton NoclipButton
        {
            get => _noclipButton;
            set
            {
                _noclipButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }
        public bool Noclipped => TimeRemaining > 0f;
        public float NoclipTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastNoclip;
            var cooldown = CustomGameOptions.WraithCd * 1000f;
            var flag2 = cooldown - (float)timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (cooldown - (float)timeSpan.TotalMilliseconds) / 1000f;
        }

        public void WallWalk()
        {
            Enabled = true;
            TimeRemaining -= Time.deltaTime;
            Player.Collider.enabled = false;
            Player.gameObject.layer = LayerMask.NameToLayer("Ghost");
            if (Player.Data.IsDead)
            {
                TimeRemaining = 0f;
                //Debug.Log($"[UnWallWalk] Noclip deactivated for player: {Player.name}");
            }
        }
        public void UnWallWalk()
        {
            Enabled = false;
            LastNoclip = DateTime.UtcNow;
            Player.gameObject.layer = LayerMask.NameToLayer("Players");
            Player.Collider.enabled = true;
            //Debug.Log($"[UnWallWalk] Player {Player.name} unmorphed.");
        }

        internal override bool GameEnd(LogicGameFlowNormal __instance)
        {
            if (Player.Data.IsDead || Player.Data.Disconnected) return true;

            if (PlayerControl.AllPlayerControls.ToArray().Count(x => !x.Data.IsDead && !x.Data.Disconnected) <= 2 &&
                    PlayerControl.AllPlayerControls.ToArray().Count(x => !x.Data.IsDead && !x.Data.Disconnected &&
                    (x.Data.IsImpostor() || x.Is(Faction.NeutralKilling) || x.IsCrewKiller())) == 1)
            {
                Utils.Rpc(CustomRPC.WraithWin, Player.PlayerId);
                Wins();
                Utils.EndGame();
                return false;
            }

            return false;
        }


        public void Wins()
        {
            WraithWins = true;
        }

        protected override void IntroPrefix(IntroCutscene._ShowTeam_d__38 __instance)
        {
            var wraithTeam = new Il2CppSystem.Collections.Generic.List<PlayerControl>();
            wraithTeam.Add(PlayerControl.LocalPlayer);
            __instance.teamToShow = wraithTeam;
        }

        public float KillTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastKilled;
            var num = CustomGameOptions.WraithKillCd * 1000f;
            var flag2 = num - (float)timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float)timeSpan.TotalMilliseconds) / 1000f;
        }
    }
}