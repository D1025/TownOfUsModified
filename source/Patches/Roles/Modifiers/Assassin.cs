using System.Collections.Generic;
using System.Linq;
using TMPro;
using TownOfUs.Patches;
using UnityEngine;
using TownOfUs.NeutralRoles.ExecutionerMod;
using TownOfUs.NeutralRoles.GuardianAngelMod;

namespace TownOfUs.Roles.Modifiers
{
    public class Assassin : Ability, IGuesser
    {
        public Dictionary<byte, (GameObject, GameObject, GameObject, TMP_Text)> Buttons { get; set; } = new();


        private Dictionary<string, Color> ColorMapping = new();

        public Dictionary<string, Color> SortedColorMapping;

        public Dictionary<byte, string> Guesses = new();


        public Assassin(PlayerControl player) : base(player)
        {
            Name = "Assassin";
            TaskText = () => "Guess the roles of the people and kill them mid-meeting";
            Color = Patches.Colors.Impostor;
            AbilityType = AbilityEnum.Assassin;

            RemainingKills = CustomGameOptions.AssassinKills;

            // Adds all the roles that have a non-zero chance of being in the game.
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

            // Add Neutral roles if enabled
            if (CustomGameOptions.AssassinGuessNeutralBenign)
            {
                if (CustomGameOptions.AmnesiacOn || (CustomGameOptions.ExecutionerOn && CustomGameOptions.OnTargetDead == OnTargetDead.Amnesiac) || (CustomGameOptions.GuardianAngelOn && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Amnesiac)) ColorMapping.Add("Amnesiac", Colors.Amnesiac);
                if (CustomGameOptions.GuardianAngelOn) ColorMapping.Add("Guardian Angel", Colors.GuardianAngel);
                if (CustomGameOptions.SurvivorOn || (CustomGameOptions.ExecutionerOn && CustomGameOptions.OnTargetDead == OnTargetDead.Survivor) || (CustomGameOptions.GuardianAngelOn && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Survivor)) ColorMapping.Add("Survivor", Colors.Survivor);
            }
            if (CustomGameOptions.AssassinGuessNeutralEvil)
            {
                if (CustomGameOptions.ExecutionerOn) ColorMapping.Add("Executioner", Colors.Executioner);
                if (CustomGameOptions.JesterOn || (CustomGameOptions.ExecutionerOn && CustomGameOptions.OnTargetDead == OnTargetDead.Jester) || (CustomGameOptions.GuardianAngelOn && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Jester)) ColorMapping.Add("Jester", Colors.Jester);
                if (CustomGameOptions.SoulCollectorOn) ColorMapping.Add("Soul Collector", Colors.SoulCollector);
                if (CustomGameOptions.VultureOn) ColorMapping.Add("Vulture", Colors.Vulture);
            }
            if (CustomGameOptions.AssassinGuessNeutralKilling)
            {
                if (CustomGameOptions.DoomsayerOn && !PlayerControl.LocalPlayer.Is(RoleEnum.Doomsayer)) ColorMapping.Add("Doomsayer", Colors.Doomsayer);
                if (CustomGameOptions.ArsonistOn && !PlayerControl.LocalPlayer.Is(RoleEnum.Arsonist)) ColorMapping.Add("Arsonist", Colors.Arsonist);
                if (CustomGameOptions.GlitchOn && !PlayerControl.LocalPlayer.Is(RoleEnum.Glitch)) ColorMapping.Add("The Glitch", Colors.Glitch);
                if (CustomGameOptions.PlaguebearerOn && !PlayerControl.LocalPlayer.Is(RoleEnum.Plaguebearer)) ColorMapping.Add("Plaguebearer", Colors.Plaguebearer);
                if (CustomGameOptions.VampireOn && !PlayerControl.LocalPlayer.Is(RoleEnum.Vampire)) ColorMapping.Add("Vampire", Colors.Vampire);
                if (CustomGameOptions.WerewolfOn && !PlayerControl.LocalPlayer.Is(RoleEnum.Werewolf)) ColorMapping.Add("Werewolf", Colors.Werewolf);
                if (CustomGameOptions.JuggernautOn && !PlayerControl.LocalPlayer.Is(RoleEnum.Juggernaut)) ColorMapping.Add("Juggernaut", Colors.Juggernaut);
            }
            if (CustomGameOptions.AssassinGuessImpostors && !PlayerControl.LocalPlayer.Is(Faction.Impostors))
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

            // Add vanilla crewmate if enabled
            if (CustomGameOptions.AssassinCrewmateGuess) ColorMapping.Add("Crewmate", Colors.Crewmate);
            //Add modifiers if enabled
            if (CustomGameOptions.AssassinGuessModifiers)
            {
                if (CustomGameOptions.BaitOn > 0) ColorMapping.Add("Bait", Colors.Bait);
                if (CustomGameOptions.AftermathOn > 0) ColorMapping.Add("Aftermath", Colors.Aftermath);
                if (CustomGameOptions.DiseasedOn > 0) ColorMapping.Add("Diseased", Colors.Diseased);
                if (CustomGameOptions.FrostyOn > 0) ColorMapping.Add("Frosty", Colors.Frosty);
                if (CustomGameOptions.MultitaskerOn > 0) ColorMapping.Add("Multitasker", Colors.Multitasker);
                if (CustomGameOptions.TorchOn > 0) ColorMapping.Add("Torch", Colors.Torch);
            }
            if (CustomGameOptions.AssassinGuessLovers && CustomGameOptions.LoversOn > 0) ColorMapping.Add("Lover", Colors.Lovers);

            // Sorts the list alphabetically. 
            SortedColorMapping = ColorMapping.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public bool GuessedThisMeeting { get; set; } = false;

        public int RemainingKills { get; set; }

        public List<string> PossibleGuesses => SortedColorMapping.Keys.ToList();
    }
}
