using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using TownOfUs.Extensions;
using TownOfUs.NeutralRoles.ExecutionerMod;
using TownOfUs.NeutralRoles.GuardianAngelMod;
using TownOfUs.Patches;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Doomsayer : Role, IGuesser
    {
        public Dictionary<byte, (GameObject, GameObject, GameObject, TMP_Text)> Buttons { get; set; } = new();
        public Dictionary<byte, TMP_Text> RoleGuess { get; set; } = new();
        private Dictionary<string, Color> ColorMapping = new();
        public Dictionary<string, Color> SortedColorMapping;
        public Dictionary<byte, string> Guesses = new();
        public DateTime LastObserved;
        public List<PlayerControl> LastObservedPlayers = new List<PlayerControl>();
        public PlayerControl ClosestPlayer;
        public int KillCountToVictory;

        public Doomsayer(PlayerControl player) : base(player)
        {
            Name = "Doomsayer";
            ImpostorText = () => "Guess People's Roles To Win!";
            TaskText = () => "Win by guessing player's roles\nFake Tasks:";
            Color = Patches.Colors.Doomsayer;
            RoleType = RoleEnum.Doomsayer;
            LastObserved = DateTime.UtcNow;
            Faction = Faction.NeutralKilling;
            AddToRoleHistory(RoleType);
            ColorMapping.Add("Crewmate", Colors.Crewmate);
            if (CustomGameOptions.PoliticianOn) ColorMapping.Add("Politician", Colors.Politician);
            if (CustomGameOptions.SheriffOn) ColorMapping.Add("Sheriff", Colors.Sheriff);
            if (CustomGameOptions.EngineerOn) ColorMapping.Add("Engineer", Colors.Engineer);
            if (CustomGameOptions.SwapperOn) ColorMapping.Add("Swapper", Colors.Swapper);
            if (CustomGameOptions.InvestigatorOn) ColorMapping.Add("Investigator", Colors.Investigator);
            if (CustomGameOptions.MedicOn) ColorMapping.Add("Medic", Colors.Medic);
            if (CustomGameOptions.SeerOn) ColorMapping.Add("Seer", Colors.Seer);
            if (CustomGameOptions.SpyOn) ColorMapping.Add("Spy", Colors.Spy);
            if (CustomGameOptions.SnitchOn) ColorMapping.Add("Snitch", Colors.Snitch);
            if (CustomGameOptions.AltruistOn) ColorMapping.Add("Altruist", Colors.Altruist);
            if (CustomGameOptions.VigilanteOn) ColorMapping.Add("Vigilante", Colors.Vigilante);
            if (CustomGameOptions.VeteranOn) ColorMapping.Add("Veteran", Colors.Veteran);
            if (CustomGameOptions.HunterOn) ColorMapping.Add("Hunter", Colors.Hunter);
            if (CustomGameOptions.TrackerOn) ColorMapping.Add("Tracker", Colors.Tracker);
            if (CustomGameOptions.TrapperOn) ColorMapping.Add("Trapper", Colors.Trapper);
            if (CustomGameOptions.TransporterOn) ColorMapping.Add("Transporter", Colors.Transporter);
            if (CustomGameOptions.MediumOn) ColorMapping.Add("Medium", Colors.Medium);
            if (CustomGameOptions.MysticOn) ColorMapping.Add("Mystic", Colors.Mystic);
            if (CustomGameOptions.DetectiveOn) ColorMapping.Add("Detective", Colors.Detective);
            if (CustomGameOptions.ImitatorOn) ColorMapping.Add("Imitator", Colors.Imitator);
            if (CustomGameOptions.ProsecutorOn) ColorMapping.Add("Prosecutor", Colors.Prosecutor);
            if (CustomGameOptions.OracleOn) ColorMapping.Add("Oracle", Colors.Oracle);
            if (CustomGameOptions.AurialOn) ColorMapping.Add("Aurial", Colors.Aurial);
            if (CustomGameOptions.WardenOn) ColorMapping.Add("Warden", Colors.Warden);
            if (CustomGameOptions.JailorOn) ColorMapping.Add("Jailor", Colors.Jailor);
            if (CustomGameOptions.LookoutOn) ColorMapping.Add("Lookout", Colors.Lookout);
            if (CustomGameOptions.DeputyOn) ColorMapping.Add("Deputy", Colors.Deputy);
            if (CustomGameOptions.DoomsayerGuessImpostors && !PlayerControl.LocalPlayer.Is(Faction.Impostors))
            {
                ColorMapping.Add("Impostor", Colors.Impostor);
                if (CustomGameOptions.JanitorOn) ColorMapping.Add("Janitor", Colors.Impostor);
                if (CustomGameOptions.MorphlingOn) ColorMapping.Add("Morphling", Colors.Impostor);
                if (CustomGameOptions.MinerOn) ColorMapping.Add("Miner", Colors.Impostor);
                if (CustomGameOptions.SwooperOn) ColorMapping.Add("Swooper", Colors.Impostor);
                if (CustomGameOptions.UndertakerOn) ColorMapping.Add("Undertaker", Colors.Impostor);
                if (CustomGameOptions.EscapistOn) ColorMapping.Add("Escapist", Colors.Impostor);
                if (CustomGameOptions.GrenadierOn) ColorMapping.Add("Grenadier", Colors.Impostor);
                if (CustomGameOptions.TraitorOn) ColorMapping.Add("Traitor", Colors.Impostor);
                if (CustomGameOptions.BlackmailerOn) ColorMapping.Add("Blackmailer", Colors.Impostor);
                if (CustomGameOptions.BomberOn) ColorMapping.Add("Bomber", Colors.Impostor);
                if (CustomGameOptions.WarlockOn) ColorMapping.Add("Warlock", Colors.Impostor);
                if (CustomGameOptions.VenererOn) ColorMapping.Add("Venerer", Colors.Impostor);
                if (CustomGameOptions.HypnotistOn) ColorMapping.Add("Hypnotist", Colors.Impostor);
                if (CustomGameOptions.ScavengerOn) ColorMapping.Add("Scavenger", Colors.Impostor);
                if (CustomGameOptions.WraithOn) ColorMapping.Add("Wraith", Colors.Impostor);
            }
            if (CustomGameOptions.DoomsayerGuessNeutralBenign)
            {
                if (CustomGameOptions.AmnesiacOn || (CustomGameOptions.ExecutionerOn && CustomGameOptions.OnTargetDead == OnTargetDead.Amnesiac) || (CustomGameOptions.GuardianAngelOn && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Amnesiac))
                    ColorMapping.Add("Amnesiac", Colors.Amnesiac);
                if (CustomGameOptions.GuardianAngelOn) ColorMapping.Add("Guardian Angel", Colors.GuardianAngel);
                if (CustomGameOptions.SurvivorOn || (CustomGameOptions.ExecutionerOn && CustomGameOptions.OnTargetDead == OnTargetDead.Survivor) || (CustomGameOptions.GuardianAngelOn && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Survivor))
                    ColorMapping.Add("Survivor", Colors.Survivor);
            }
            if (CustomGameOptions.DoomsayerGuessNeutralEvil)
            {
                if (!CustomGameOptions.UniqueRoles) ColorMapping.Add("Doomsayer", Colors.Doomsayer);
                if (CustomGameOptions.ExecutionerOn) ColorMapping.Add("Executioner", Colors.Executioner);
                if (CustomGameOptions.JesterOn || (CustomGameOptions.ExecutionerOn && CustomGameOptions.OnTargetDead == OnTargetDead.Jester) || (CustomGameOptions.GuardianAngelOn && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Jester))
                    ColorMapping.Add("Jester", Colors.Jester);
                if (CustomGameOptions.SoulCollectorOn) ColorMapping.Add("Soul Collector", Colors.SoulCollector);
                if (CustomGameOptions.VultureOn) ColorMapping.Add("Vulture", Colors.Vulture);
            }
            if (CustomGameOptions.DoomsayerGuessNeutralKilling)
            {
                if (CustomGameOptions.ArsonistOn) ColorMapping.Add("Arsonist", Colors.Arsonist);
                if (CustomGameOptions.GlitchOn) ColorMapping.Add("The Glitch", Colors.Glitch);
                if (CustomGameOptions.PlaguebearerOn) ColorMapping.Add("Plaguebearer", Colors.Plaguebearer);
                if (CustomGameOptions.VampireOn) ColorMapping.Add("Vampire", Colors.Vampire);
                if (CustomGameOptions.WerewolfOn) ColorMapping.Add("Werewolf", Colors.Werewolf);
                if (CustomGameOptions.JuggernautOn) ColorMapping.Add("Juggernaut", Colors.Juggernaut);
            }
            SortedColorMapping = ColorMapping.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public float ObserveTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastObserved;
            var num = CustomGameOptions.ObserveCooldown * 1000f;
            if (num - (float)timeSpan.TotalMilliseconds < 0f)
                return 0;
            return (num - (float)timeSpan.TotalMilliseconds) / 1000f;
        }

        public int NumberOfGuesses = 0;
        public int IncorrectGuesses = 0;
        public bool WonByGuessing = false;
        public List<string> PossibleGuesses => SortedColorMapping.Keys.ToList();

        protected override void IntroPrefix(IntroCutscene._ShowTeam_d__38 __instance)
        {
            var doomTeam = new Il2CppSystem.Collections.Generic.List<PlayerControl>();
            doomTeam.Add(PlayerControl.LocalPlayer);
            __instance.teamToShow = doomTeam;
        }

        internal override bool GameEnd(LogicGameFlowNormal __instance)
        {
            if (Player.Data.IsDead || Player.Data.Disconnected) return true;
            if (PlayerControl.AllPlayerControls.ToArray().Count(x => !x.Data.IsDead && !x.Data.Disconnected) <= 2 
                && 
                CustomGameOptions.DoomsayerKillNeedToVictory + PlayerControl.AllPlayerControls.ToArray().Count(x => !x.Data.IsDead && !x.Data.Disconnected && x.Is(RoleEnum.Mayor)) - CorrectAssassinKills > 1) 
                return true;
            if (WonByGuessing)
            {
                Utils.EndGame();
                return true;
            }
            return false;
        }
    }
}
