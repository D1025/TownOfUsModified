using System.Collections.Generic;
using System.Linq;
using TMPro;
using TownOfUs.Patches;
using UnityEngine;
using TownOfUs.NeutralRoles.ExecutionerMod;
using TownOfUs.NeutralRoles.GuardianAngelMod;
using TownOfUs.Extensions;

namespace TownOfUs.Roles
{
    public class Vigilante : Role, IGuesser
    {
        public Dictionary<byte, (GameObject, GameObject, GameObject, TMP_Text)> Buttons { get; set; } = new();

        private Dictionary<string, Color> ColorMapping = new();

        public Dictionary<string, Color> SortedColorMapping;

        public Dictionary<byte, string> Guesses = new();

        public Vigilante(PlayerControl player) : base(player)
        {
            Name = "Vigilante";
            ImpostorText = () => "Kill Impostors If You Can Guess Their Roles";
            TaskText = () => "Guess the roles of impostors mid-meeting to kill them!";
            Color = Patches.Colors.Vigilante;
            RoleType = RoleEnum.Vigilante;
            AddToRoleHistory(RoleType);

            RemainingKills = CustomGameOptions.VigilanteKills;

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
            if (CustomGameOptions.ArsonistOn) ColorMapping.Add("Arsonist", Colors.Impostor);

            if (CustomGameOptions.VigilanteGuessNeutralBenign)
            {
                if (CustomGameOptions.AmnesiacOn || (CustomGameOptions.ExecutionerOn && CustomGameOptions.OnTargetDead == OnTargetDead.Amnesiac) || (CustomGameOptions.GuardianAngelOn && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Amnesiac)) ColorMapping.Add("Amnesiac", Colors.Amnesiac);
                if (CustomGameOptions.GuardianAngelOn) ColorMapping.Add("Guardian Angel", Colors.GuardianAngel);
                if (CustomGameOptions.SurvivorOn || (CustomGameOptions.ExecutionerOn && CustomGameOptions.OnTargetDead == OnTargetDead.Survivor) || (CustomGameOptions.GuardianAngelOn && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Survivor)) ColorMapping.Add("Survivor", Colors.Survivor);
            }
            if (CustomGameOptions.VigilanteGuessNeutralEvil)
            {
                if (CustomGameOptions.ExecutionerOn) ColorMapping.Add("Executioner", Colors.Executioner);
                if (CustomGameOptions.JesterOn || (CustomGameOptions.ExecutionerOn && CustomGameOptions.OnTargetDead == OnTargetDead.Jester) || (CustomGameOptions.GuardianAngelOn && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Jester)) ColorMapping.Add("Jester", Colors.Jester);
                if (CustomGameOptions.SoulCollectorOn) ColorMapping.Add("Soul Collector", Colors.SoulCollector);
                if (CustomGameOptions.VultureOn) ColorMapping.Add("Vulture", Colors.Vulture);
            }
            if (CustomGameOptions.VigilanteGuessNeutralKilling)
            {
                if (CustomGameOptions.WraithOn) ColorMapping.Add("Wraith", Colors.Wraith);
                if (CustomGameOptions.GlitchOn) ColorMapping.Add("The Glitch", Colors.Glitch);
                if (CustomGameOptions.PlaguebearerOn) ColorMapping.Add("Plaguebearer", Colors.Plaguebearer);
                if (CustomGameOptions.VampireOn) ColorMapping.Add("Vampire", Colors.Vampire);
                if (CustomGameOptions.WerewolfOn) ColorMapping.Add("Werewolf", Colors.Werewolf);
                if (CustomGameOptions.JuggernautOn) ColorMapping.Add("Juggernaut", Colors.Juggernaut);
                if (CustomGameOptions.DoomsayerOn) ColorMapping.Add("Doomsayer", Colors.Doomsayer);
            }
            if (CustomGameOptions.VigilanteGuessLovers && CustomGameOptions.LoversOn > 0) ColorMapping.Add("Lover", Colors.Lovers);

            if (CustomGameOptions.VigilanteGuessModifiers)
            {
                if (CustomGameOptions.DisperserOn > 0) ColorMapping.Add("Disperser", Colors.Impostor);
                if (CustomGameOptions.DoubleShotOn > 0) ColorMapping.Add("Double Shot", Colors.Impostor);
                if (CustomGameOptions.SaboteurOn > 0) ColorMapping.Add("Saboteur", Colors.Impostor);
                if (CustomGameOptions.UnderdogOn > 0) ColorMapping.Add("Underdog", Colors.Impostor);
            }

            SortedColorMapping = ColorMapping.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public bool GuessedThisMeeting { get; set; } = false;

        public int RemainingKills { get; set; }

        public List<string> PossibleGuesses => SortedColorMapping.Keys.ToList();

        internal override bool GameEnd(LogicGameFlowNormal __instance)
        {
            if (Player.Data.IsDead || Player.Data.Disconnected || !CustomGameOptions.CrewKillersContinue) return true;

            if (PlayerControl.AllPlayerControls.ToArray().Count(x => !x.Data.IsDead && !x.Data.Disconnected && x.Data.IsImpostor()) > 0 && RemainingKills > 0) return false;

            return true;
        }
    }
}
