using System;
using TownOfUs.CrewmateRoles.SheriffMod;
using static UnityEngine.ParticleSystem.PlaybackState;

namespace TownOfUs.CustomOption
{
    public class Generate
    {
        public static CustomHeaderOption ModeSettingHeader;
        public static CustomStringOption CustomGameMode;

        public static CustomHeaderOption CrewInvestigativeRoles;
        public static CustomToggleOption DetectiveOn;
        public static CustomToggleOption HaunterOn;
        public static CustomToggleOption InvestigatorOn;
        public static CustomToggleOption LookoutOn;
        public static CustomToggleOption MysticOn;
        public static CustomToggleOption OracleOn;
        public static CustomToggleOption SeerOn;
        public static CustomToggleOption SnitchOn;
        public static CustomToggleOption SpyOn;
        public static CustomToggleOption TrackerOn;
        public static CustomToggleOption TrapperOn;

        public static CustomHeaderOption CrewKillingRoles;
        public static CustomToggleOption DeputyOn;
        public static CustomToggleOption HunterOn;
        public static CustomToggleOption JailorOn;
        public static CustomToggleOption SheriffOn;
        public static CustomToggleOption VeteranOn;
        public static CustomToggleOption VigilanteOn;

        public static CustomHeaderOption CrewProtectiveRoles;
        public static CustomToggleOption AltruistOn;
        public static CustomToggleOption MedicOn;
        public static CustomToggleOption WardenOn;

        public static CustomHeaderOption CrewSupportRoles;
        public static CustomToggleOption EngineerOn;
        public static CustomToggleOption ImitatorOn;
        public static CustomToggleOption MediumOn;
        public static CustomToggleOption PoliticianOn;
        public static CustomToggleOption ProsecutorOn;
        public static CustomToggleOption SwapperOn;
        public static CustomToggleOption TransporterOn;

        public static CustomHeaderOption NeutralBenignRoles;
        public static CustomToggleOption AmnesiacOn;
        public static CustomToggleOption GuardianAngelOn;
        public static CustomToggleOption SurvivorOn;

        public static CustomHeaderOption NeutralEvilRoles;
        public static CustomToggleOption ExecutionerOn;
        public static CustomToggleOption JesterOn;
        public static CustomToggleOption PhantomOn;
        public static CustomToggleOption SoulCollectorOn;
        public static CustomToggleOption VultureOn;

        public static CustomHeaderOption NeutralKillingRoles;
        public static CustomToggleOption DoomsayerOn;
        public static CustomToggleOption JuggernautOn;
        public static CustomToggleOption PlaguebearerOn;
        public static CustomToggleOption GlitchOn;
        public static CustomToggleOption VampireOn;
        public static CustomToggleOption WerewolfOn;

        public static CustomHeaderOption ImpostorConcealingRoles;
        public static CustomToggleOption EscapistOn;
        public static CustomToggleOption GrenadierOn;
        public static CustomToggleOption MorphlingOn;
        public static CustomToggleOption SwooperOn;
        public static CustomToggleOption VenererOn;
        public static CustomToggleOption WraithOn;

        public static CustomHeaderOption ImpostorKillingRoles;
        public static CustomToggleOption BomberOn;
        public static CustomToggleOption ScavengerOn;
        public static CustomToggleOption TraitorOn;
        public static CustomToggleOption WarlockOn;
        public static CustomToggleOption ArsonistOn;

        public static CustomHeaderOption ImpostorSupportRoles;
        public static CustomToggleOption BlackmailerOn;
        public static CustomToggleOption HypnotistOn;
        public static CustomToggleOption JanitorOn;
        public static CustomToggleOption MinerOn;
        public static CustomToggleOption UndertakerOn;

        public static CustomHeaderOption CrewmateModifiers;
        public static CustomNumberOption AftermathOn;
        public static CustomNumberOption BaitOn;
        public static CustomNumberOption DiseasedOn;
        public static CustomNumberOption FrostyOn;
        public static CustomNumberOption MultitaskerOn;
        public static CustomNumberOption TorchOn;

        public static CustomHeaderOption GlobalModifiers;
        public static CustomNumberOption ButtonBarryOn;
        public static CustomNumberOption FlashOn;
        public static CustomNumberOption GiantOn;
        public static CustomNumberOption LoversOn;
        public static CustomNumberOption MiniOn;
        public static CustomNumberOption RadarOn;
        public static CustomNumberOption ShyOn;
        public static CustomNumberOption SixthSenseOn;
        public static CustomNumberOption SleuthOn;
        public static CustomNumberOption TiebreakerOn;
        public static CustomNumberOption ErrorOn;
        public static CustomNumberOption DrunkOn;

        public static CustomHeaderOption ImpostorModifiers;
        public static CustomNumberOption DisperserOn;
        public static CustomNumberOption DoubleShotOn;
        public static CustomNumberOption SaboteurOn;
        public static CustomNumberOption UnderdogOn;

        public static CustomHeaderOption MapSettings;
        public static CustomToggleOption RandomMapEnabled;
        public static CustomNumberOption RandomMapSkeld;
        public static CustomNumberOption RandomMapMira;
        public static CustomNumberOption RandomMapPolus;
        public static CustomNumberOption RandomMapAirship;
        public static CustomNumberOption RandomMapFungle;
        public static CustomNumberOption RandomMapSubmerged;
        public static CustomNumberOption RandomMapLevelImpostor;
        public static CustomToggleOption SmallMapHalfVision;
        public static CustomNumberOption SmallMapDecreasedCooldown;
        public static CustomNumberOption LargeMapIncreasedCooldown;
        public static CustomNumberOption SmallMapIncreasedShortTasks;
        public static CustomNumberOption SmallMapIncreasedLongTasks;
        public static CustomNumberOption LargeMapDecreasedShortTasks;
        public static CustomNumberOption LargeMapDecreasedLongTasks;

        public static CustomHeaderOption CustomGameSettings;
        public static CustomToggleOption ColourblindComms;
        public static CustomToggleOption CamoCommsKillAnyone;
        public static CustomToggleOption ImpostorSeeRoles;
        public static CustomToggleOption DeadSeeRoles;
        public static CustomNumberOption InitialCooldowns;
        public static CustomToggleOption ParallelMedScans;
        public static CustomStringOption SkipButtonDisable;
        public static CustomToggleOption FirstDeathShield;
        public static CustomToggleOption NeutralEvilWinEndsGame;
        public static CustomToggleOption CrewKillersContinue;
        public static CustomToggleOption VultureJanitorInSameGame;

        public static CustomHeaderOption BetterPolusSettings;
        public static CustomToggleOption VentImprovements;
        public static CustomToggleOption VitalsLab;
        public static CustomToggleOption ColdTempDeathValley;
        public static CustomToggleOption WifiChartCourseSwap;

        public static CustomHeaderOption RoleListSettings;
        public static CustomToggleOption UniqueRoles;
        public static CustomStringOption Slot1;
        public static CustomStringOption Slot2;
        public static CustomStringOption Slot3;
        public static CustomStringOption Slot4;
        public static CustomStringOption Slot5;
        public static CustomStringOption Slot6;
        public static CustomStringOption Slot7;
        public static CustomStringOption Slot8;
        public static CustomStringOption Slot9;
        public static CustomStringOption Slot10;
        public static CustomStringOption Slot11;
        public static CustomStringOption Slot12;
        public static CustomStringOption Slot13;
        public static CustomStringOption Slot14;
        public static CustomStringOption Slot15;

        public static CustomHeaderOption TaskTrackingSettings;
        public static CustomToggleOption SeeTasksDuringRound;
        public static CustomToggleOption SeeTasksDuringMeeting;
        public static CustomToggleOption SeeTasksWhenDead;

        public static CustomHeaderOption Sheriff;
        public static CustomToggleOption SheriffKillOther;
        public static CustomToggleOption SheriffKillsNE;
        public static CustomToggleOption SheriffKillsNK;
        public static CustomNumberOption SheriffKillCd;
        public static CustomToggleOption SheriffBodyReport;

        public static CustomHeaderOption Hunter;
        public static CustomNumberOption HunterKillCd;
        public static CustomNumberOption HunterStalkCd;
        public static CustomNumberOption HunterStalkDuration;
        public static CustomNumberOption HunterStalkUses;
        public static CustomToggleOption RetributionOnVote;
        public static CustomToggleOption HunterBodyReport;

        public static CustomHeaderOption Engineer;
        public static CustomNumberOption MaxFixes;

        public static CustomHeaderOption Investigator;
        public static CustomNumberOption FootprintSize;
        public static CustomNumberOption FootprintInterval;
        public static CustomNumberOption FootprintDuration;
        public static CustomToggleOption AnonymousFootPrint;
        public static CustomToggleOption VentFootprintVisible;
        public static CustomNumberOption AuraInnerRadius;
        public static CustomNumberOption AuraOuterRadius;
        public static CustomNumberOption SenseDuration;

        public static CustomHeaderOption Medic;
        public static CustomStringOption ShowShielded;
        public static CustomStringOption WhoGetsNotification;
        public static CustomToggleOption ShieldBreaks;
        public static CustomToggleOption MedicReportSwitch;
        public static CustomNumberOption MedicReportNameDuration;
        public static CustomNumberOption MedicReportColorDuration;

        public static CustomHeaderOption Seer;
        public static CustomNumberOption SeerCooldown;
        public static CustomToggleOption CrewKillingRed;
        public static CustomToggleOption NeutBenignRed;
        public static CustomToggleOption NeutEvilRed;
        public static CustomToggleOption NeutKillingRed;
        public static CustomToggleOption TraitorColourSwap;

        public static CustomHeaderOption Spy;
        public static CustomStringOption WhoSeesDead;
        public static CustomToggleOption SpyAdminAnywhere;
        public static CustomNumberOption SpyAdminTableCd;
        public static CustomToggleOption SpyVitals;

        public static CustomHeaderOption Swapper;
        public static CustomToggleOption SwapperButton;

        public static CustomHeaderOption Transporter;
        public static CustomNumberOption TransportCooldown;
        public static CustomNumberOption TransportMaxUses;
        public static CustomToggleOption TransporterVitals;

        public static CustomHeaderOption Jester;
        public static CustomToggleOption JesterButton;
        public static CustomToggleOption JesterVent;
        public static CustomToggleOption JesterImpVision;
        public static CustomToggleOption JesterHaunt;

        public static CustomHeaderOption TheGlitch;
        public static CustomNumberOption MimicCooldownOption;
        public static CustomNumberOption MimicDurationOption;
        public static CustomNumberOption HackCooldownOption;
        public static CustomNumberOption HackDurationOption;
        public static CustomNumberOption GlitchKillCooldownOption;
        public static CustomStringOption GlitchHackDistanceOption;
        public static CustomToggleOption GlitchVent;

        public static CustomHeaderOption Juggernaut;
        public static CustomNumberOption JuggKillCooldown;
        public static CustomNumberOption ReducedKCdPerKill;
        public static CustomToggleOption JuggVent;

        public static CustomHeaderOption Morphling;
        public static CustomNumberOption MorphlingCooldown;
        public static CustomNumberOption MorphlingDuration;
        public static CustomToggleOption MorphlingVent;

        public static CustomHeaderOption Executioner;
        public static CustomStringOption OnTargetDead;
        public static CustomToggleOption ExecutionerButton;
        public static CustomToggleOption ExecutionerTorment;

        public static CustomHeaderOption Phantom;
        public static CustomNumberOption PhantomTasksRemaining;
        public static CustomToggleOption PhantomSpook;

        public static CustomHeaderOption Snitch;
        public static CustomToggleOption SnitchSeesNeutrals;
        public static CustomNumberOption SnitchTasksRemaining;
        public static CustomToggleOption SnitchSeesImpInMeeting;
        public static CustomToggleOption SnitchSeesTraitor;

        public static CustomHeaderOption Altruist;
        public static CustomNumberOption ReviveDuration;
        public static CustomToggleOption AltruistTargetBody;

        public static CustomHeaderOption Miner;
        public static CustomNumberOption MineCooldown;

        public static CustomHeaderOption Swooper;
        public static CustomNumberOption SwoopCooldown;
        public static CustomNumberOption SwoopDuration;
        public static CustomToggleOption SwooperVent;

        public static CustomHeaderOption Arsonist;
        public static CustomNumberOption DouseCooldown;
        public static CustomNumberOption MaxDoused;
        public static CustomToggleOption ArsoImpVision;
        public static CustomToggleOption IgniteCdRemoved;

        public static CustomHeaderOption Undertaker;
        public static CustomNumberOption DragCooldown;
        public static CustomNumberOption UndertakerDragSpeed;
        public static CustomToggleOption UndertakerVent;
        public static CustomToggleOption UndertakerVentWithBody;

        public static CustomHeaderOption Assassin;
        public static CustomNumberOption NumberOfImpostorAssassins;
        public static CustomNumberOption NumberOfNeutralAssassins;
        public static CustomToggleOption AmneTurnImpAssassin;
        public static CustomToggleOption AmneTurnNeutAssassin;
        public static CustomToggleOption TraitorCanAssassin;
        public static CustomNumberOption AssassinKills;
        public static CustomToggleOption AssassinMultiKill;
        public static CustomToggleOption AssassinCrewmateGuess;
        public static CustomToggleOption AssassinGuessNeutralBenign;
        public static CustomToggleOption AssassinGuessNeutralEvil;
        public static CustomToggleOption AssassinGuessNeutralKilling;
        public static CustomToggleOption AssassinGuessImpostors;
        public static CustomToggleOption AssassinGuessModifiers;
        public static CustomToggleOption AssassinGuessLovers;

        public static CustomHeaderOption Underdog;
        public static CustomNumberOption UnderdogKillBonus;
        public static CustomToggleOption UnderdogIncreasedKC;

        public static CustomHeaderOption Vigilante;
        public static CustomNumberOption VigilanteKills;
        public static CustomToggleOption VigilanteMultiKill;
        public static CustomToggleOption VigilanteGuessNeutralBenign;
        public static CustomToggleOption VigilanteGuessNeutralEvil;
        public static CustomToggleOption VigilanteGuessNeutralKilling;
        public static CustomToggleOption VigilanteGuessModifiers;
        public static CustomToggleOption VigilanteGuessLovers;

        public static CustomHeaderOption Haunter;
        public static CustomNumberOption HaunterTasksRemainingClicked;
        public static CustomNumberOption HaunterTasksRemainingAlert;
        public static CustomToggleOption HaunterRevealsNeutrals;
        public static CustomStringOption HaunterCanBeClickedBy;

        public static CustomHeaderOption Grenadier;
        public static CustomNumberOption GrenadeCooldown;
        public static CustomNumberOption GrenadeDuration;
        public static CustomToggleOption GrenadierIndicators;
        public static CustomToggleOption GrenadierVent;
        public static CustomNumberOption FlashRadius;

        public static CustomHeaderOption Veteran;
        public static CustomToggleOption KilledOnAlert;
        public static CustomNumberOption AlertCooldown;
        public static CustomNumberOption AlertDuration;
        public static CustomNumberOption MaxAlerts;

        public static CustomHeaderOption Tracker;
        public static CustomNumberOption UpdateInterval;
        public static CustomNumberOption TrackCooldown;
        public static CustomToggleOption ResetOnNewRound;
        public static CustomNumberOption MaxTracks;

        public static CustomHeaderOption Trapper;
        public static CustomNumberOption TrapCooldown;
        public static CustomToggleOption TrapsRemoveOnNewRound;
        public static CustomNumberOption MaxTraps;
        public static CustomNumberOption MinAmountOfTimeInTrap;
        public static CustomNumberOption TrapSize;
        public static CustomNumberOption MinAmountOfPlayersInTrap;

        public static CustomHeaderOption Traitor;
        public static CustomNumberOption LatestSpawn;
        public static CustomToggleOption NeutralKillingStopsTraitor;

        public static CustomHeaderOption Amnesiac;
        public static CustomToggleOption RememberArrows;
        public static CustomNumberOption RememberArrowDelay;

        public static CustomHeaderOption Medium;
        public static CustomNumberOption MediateCooldown;
        public static CustomToggleOption ShowMediatePlayer;
        public static CustomToggleOption ShowMediumToDead;
        public static CustomStringOption DeadRevealed;

        public static CustomHeaderOption Survivor;
        public static CustomNumberOption VestCd;
        public static CustomNumberOption VestDuration;
        public static CustomNumberOption VestKCReset;
        public static CustomNumberOption MaxVests;

        public static CustomHeaderOption GuardianAngel;
        public static CustomNumberOption ProtectCd;
        public static CustomNumberOption ProtectDuration;
        public static CustomNumberOption ProtectKCReset;
        public static CustomNumberOption MaxProtects;
        public static CustomStringOption ShowProtect;
        public static CustomStringOption GaOnTargetDeath;
        public static CustomToggleOption GATargetKnows;
        public static CustomToggleOption GAKnowsTargetRole;
        public static CustomNumberOption EvilTargetPercent;

        public static CustomHeaderOption Mystic;
        public static CustomNumberOption MysticArrowDuration;
        public static CustomToggleOption MysticSleuthAbility;

        public static CustomHeaderOption Blackmailer;
        public static CustomNumberOption BlackmailCooldown;
        public static CustomToggleOption BlackmailInvisible;
        public static CustomNumberOption LatestNonVote;

        public static CustomHeaderOption Plaguebearer;
        public static CustomNumberOption InfectCooldown;
        public static CustomNumberOption PestKillCooldown;
        public static CustomToggleOption PestVent;

        public static CustomHeaderOption Werewolf;
        public static CustomNumberOption RampageCooldown;
        public static CustomNumberOption RampageDuration;
        public static CustomNumberOption RampageKillCooldown;
        public static CustomToggleOption WerewolfVent;

        public static CustomHeaderOption Vulture;
        public static CustomNumberOption VultureKillCooldown;
        public static CustomToggleOption VultureRememberArrows;
        public static CustomNumberOption VultureRememberArrowDelay;
        public static CustomNumberOption VultureEatCount;

        public static CustomHeaderOption Detective;
        public static CustomNumberOption ExamineCooldown;
        public static CustomToggleOption DetectiveReportOn;
        public static CustomNumberOption DetectiveRoleDuration;
        public static CustomNumberOption DetectiveFactionDuration;

        public static CustomHeaderOption Imitator;
        public static CustomToggleOption ImitatorCanBecomeMayor;
        public static CustomToggleOption ImitateAllCrewmates;

        public static CustomHeaderOption Escapist;
        public static CustomNumberOption EscapeCooldown;
        public static CustomToggleOption EscapistVent;

        public static CustomHeaderOption Bomber;
        public static CustomNumberOption MaxKillsInDetonation;
        public static CustomNumberOption DetonateDelay;
        public static CustomNumberOption DetonateRadius;
        public static CustomToggleOption BomberVent;
        public static CustomToggleOption AllImpsSeeBomb;

        public static CustomHeaderOption Doomsayer;
        public static CustomNumberOption ObserveCooldown;
        public static CustomToggleOption DoomsayerGuessNeutralBenign;
        public static CustomToggleOption DoomsayerGuessNeutralEvil;
        public static CustomToggleOption DoomsayerGuessNeutralKilling;
        public static CustomToggleOption DoomsayerGuessImpostors;
        public static CustomToggleOption DoomsayerCantObserve;
        public static CustomNumberOption DoomsayerKillNeedToVictory;
        public static CustomNumberOption DoomsayerObserveRoleCount;

        public static CustomHeaderOption Vampire;
        public static CustomNumberOption BiteCooldown;
        public static CustomToggleOption VampImpVision;
        public static CustomToggleOption VampVent;
        public static CustomToggleOption NewVampCanAssassin;
        public static CustomNumberOption MaxVampiresPerGame;
        public static CustomToggleOption CanBiteNeutralBenign;
        public static CustomToggleOption CanBiteNeutralEvil;

        public static CustomHeaderOption Prosecutor;
        public static CustomToggleOption ProsDiesOnIncorrectPros;

        public static CustomHeaderOption Warlock;
        public static CustomNumberOption ChargeUpDuration;
        public static CustomNumberOption ChargeUseDuration;

        public static CustomHeaderOption Oracle;
        public static CustomNumberOption ConfessCooldown;
        public static CustomNumberOption RevealAccuracy;
        public static CustomToggleOption NeutralBenignShowsEvil;
        public static CustomToggleOption NeutralEvilShowsEvil;
        public static CustomToggleOption NeutralKillingShowsEvil;

        public static CustomHeaderOption Venerer;
        public static CustomNumberOption AbilityCooldown;
        public static CustomNumberOption AbilityDuration;
        public static CustomNumberOption SprintSpeed;
        public static CustomNumberOption FreezeSpeed;

        public static CustomHeaderOption Wraith;
        public static CustomNumberOption WraithKillCd;
        public static CustomNumberOption WraithCooldown;
        public static CustomNumberOption WraithDuration;
        public static CustomToggleOption WraithVent;

        public static CustomHeaderOption Politician;
        public static CustomNumberOption CampaignCooldown;

        public static CustomHeaderOption Hypnotist;
        public static CustomNumberOption HypnotiseCooldown;

        public static CustomHeaderOption Jailor;
        public static CustomNumberOption JailCooldown;
        public static CustomNumberOption MaxExecutes;

        public static CustomHeaderOption SoulCollector;
        public static CustomNumberOption ReapCooldown;
        public static CustomToggleOption PassiveSoulCollection;
        public static CustomNumberOption SoulsToWin;

        public static CustomHeaderOption Lookout;
        public static CustomNumberOption WatchCooldown;
        public static CustomToggleOption LoResetOnNewRound;
        public static CustomNumberOption MaxWatches;

        public static CustomHeaderOption Scavenger;
        public static CustomNumberOption ScavengeDuration;
        public static CustomNumberOption ScavengeIncreaseDuration;
        public static CustomNumberOption ScavengeCorrectKillCooldown;
        public static CustomNumberOption ScavengeIncorrectKillCooldown;

        public static CustomHeaderOption Giant;
        public static CustomNumberOption GiantSlow;

        public static CustomHeaderOption Flash;
        public static CustomNumberOption FlashSpeed;

        public static CustomHeaderOption Diseased;
        public static CustomNumberOption DiseasedKillMultiplier;

        public static CustomHeaderOption Bait;
        public static CustomNumberOption BaitMinDelay;
        public static CustomNumberOption BaitMaxDelay;

        public static CustomHeaderOption Lovers;
        public static CustomToggleOption BothLoversDie;
        public static CustomNumberOption LovingImpPercent;
        public static CustomToggleOption NeutralLovers;
        public static CustomToggleOption ImpLoverKillTeammate;

        public static CustomHeaderOption Frosty;
        public static CustomNumberOption ChillDuration;
        public static CustomNumberOption ChillStartSpeed;

        public static CustomHeaderOption Shy;
        public static CustomNumberOption InvisDelay;
        public static CustomNumberOption TransformInvisDuration;
        public static CustomNumberOption FinalTransparency;

        public static CustomHeaderOption Saboteur;
        public static CustomNumberOption ReducedSaboCooldown;

        public static Func<object, string> PercentFormat { get; } = value => $"{value:0}%";
        private static Func<object, string> CooldownFormat { get; } = value => $"{value:0.0#}s";
        private static Func<object, string> MultiplierFormat { get; } = value => $"{value:0.0#}x";


        public static void GenerateAll()
        {
            var num = 0;

            CrewInvestigativeRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "Crewmate Investigative Roles");
            DetectiveOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#4D4DFFFF>Detective</color>", false);
            HaunterOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#D3D3D3FF>Haunter</color>", false);
            InvestigatorOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#00B3B3FF>Investigator</color>", false);
            LookoutOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#33FF66FF>Lookout</color>", false);
            MysticOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#4D99E6FF>Mystic</color>", false);
            OracleOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#BF00BFFF>Oracle</color>", false);
            SeerOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFCC80FF>Seer</color>", false);
            SnitchOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#D4AF37FF>Snitch</color>", false);
            SpyOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#CCA3CCFF>Spy</color>", false);
            TrackerOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#009900FF>Tracker</color>", false);
            TrapperOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#A7D1B3FF>Trapper</color>", false);

            CrewKillingRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "Crewmate Killing Roles");
            DeputyOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFCC00FF>Deputy</color>", false);
            HunterOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#29AB87FF>Hunter</color>", false);
            JailorOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#A6A6A6FF>Jailor</color>", false);
            SheriffOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>Sheriff</color>", false);
            VeteranOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#998040FF>Veteran</color>", false);
            VigilanteOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF99FF>Vigilante</color>", false);

            CrewProtectiveRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "Crewmate Protective Roles");
            AltruistOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#660000FF>Altruist</color>", false);
            MedicOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#006600FF>Medic</color>", false);
            WardenOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#9900FFFF>Warden</color>", false);

            CrewSupportRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "Crewmate Support Roles");
            EngineerOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFA60AFF>Engineer</color>", false);
            ImitatorOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#B3D94DFF>Imitator</color>", false);
            MediumOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#A680FFFF>Medium</color>", false);
            PoliticianOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#660099FF>Politician</color>", false);
            ProsecutorOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#B38000FF>Prosecutor</color>", false);
            SwapperOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#66E666FF>Swapper</color>", false);
            TransporterOn = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#00EEFFFF>Transporter</color>", false);


            NeutralBenignRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "Neutral Benign Roles");
            AmnesiacOn = new CustomToggleOption(num++, MultiMenu.neutral, "<color=#80B2FFFF>Amnesiac</color>", false);
            GuardianAngelOn = new CustomToggleOption(num++, MultiMenu.neutral, "<color=#B3FFFFFF>Guardian Angel</color>", false);
            SurvivorOn = new CustomToggleOption(num++, MultiMenu.neutral, "<color=#FFE64DFF>Survivor</color>", false);

            NeutralEvilRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "Neutral Evil Roles");

            ExecutionerOn = new CustomToggleOption(num++, MultiMenu.neutral, "<color=#8C4005FF>Executioner</color>", false);
            JesterOn = new CustomToggleOption(num++, MultiMenu.neutral, "<color=#FFBFCCFF>Jester</color>", false);
            PhantomOn = new CustomToggleOption(num++, MultiMenu.neutral, "<color=#662962FF>Phantom</color>", false);
            SoulCollectorOn = new CustomToggleOption(num++, MultiMenu.neutral, "<color=#99FFCCFF>Soul Collector</color>", false);
            VultureOn = new CustomToggleOption(num++, MultiMenu.neutral, "<color=#FF4D00FF>Vulture</color>", false);

            NeutralKillingRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "Neutral Killing Roles");
            DoomsayerOn = new CustomToggleOption(num++, MultiMenu.neutral, "<color=#00FF80FF>Doomsayer</color>", false);
            JuggernautOn = new CustomToggleOption(num++, MultiMenu.neutral, "<color=#8C004DFF>Juggernaut</color>", false);
            PlaguebearerOn = new CustomToggleOption(num++, MultiMenu.neutral, "<color=#E6FFB3FF>Plaguebearer</color>", false);
            GlitchOn = new CustomToggleOption(num++, MultiMenu.neutral, "<color=#00FF00FF>The Glitch</color>", false);
            VampireOn = new CustomToggleOption(num++, MultiMenu.neutral, "<color=#262626FF>Vampire</color>", false);
            WerewolfOn = new CustomToggleOption(num++, MultiMenu.neutral, "<color=#A86629FF>Werewolf</color>", false);
            WraithOn = new CustomToggleOption(num++, MultiMenu.neutral, "<color=#FF4D00FF>Wraith</color>", false);

            ImpostorConcealingRoles = new CustomHeaderOption(num++, MultiMenu.imposter, "Impostor Concealing Roles");
            EscapistOn = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Escapist</color>", false);
            GrenadierOn = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Grenadier</color>", false);
            MorphlingOn = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Morphling</color>", false);
            SwooperOn = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Swooper</color>", false);
            VenererOn = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Venerer</color>", false);

            ImpostorKillingRoles = new CustomHeaderOption(num++, MultiMenu.imposter, "Impostor Killing Roles");
            ArsonistOn = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Arsonist</color>", false);
            BomberOn = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Bomber</color>", false);
            ScavengerOn = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Scavenger</color>", false);
            TraitorOn = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Traitor</color>", false);
            WarlockOn = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Warlock</color>", false);

            ImpostorSupportRoles = new CustomHeaderOption(num++, MultiMenu.imposter, "Impostor Support Roles");
            BlackmailerOn = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Blackmailer</color>", false);
            HypnotistOn = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Hypnotist</color>", false);
            JanitorOn = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Janitor</color>", false);
            MinerOn = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Miner</color>", false);
            UndertakerOn = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Undertaker</color>", false);

            CrewmateModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "Crewmate Modifiers");
            AftermathOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#A6FFA6FF>Aftermath</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            BaitOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#33B3B3FF>Bait</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DiseasedOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#808080FF>Diseased</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            FrostyOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#99FFFFFF>Frosty</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MultitaskerOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF804DFF>Multitasker</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TorchOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FFFF99FF>Torch</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            GlobalModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "Global Modifiers");
            ButtonBarryOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#E600FFFF>Button Barry</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            FlashOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF8080FF>Flash</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GiantOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FFB34DFF>Giant</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            LoversOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF66CCFF>Lovers</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MiniOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#CCFFE6FF>Mini</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            RadarOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF0080FF>Radar</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            ShyOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FFB3CCFF>Shy</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SixthSenseOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#D9FF8CFF>Sixth Sense</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SleuthOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#803333FF>Sleuth</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TiebreakerOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#99E699FF>Tiebreaker</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            ErrorOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF0000FF>Error</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DrunkOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#99E699FF>Drunk</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "Impostor Modifiers");
            DisperserOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF0000FF>Disperser</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DoubleShotOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF0000FF>Double Shot</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SaboteurOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF0000FF>Saboteur</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            UnderdogOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF0000FF>Underdog</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ModeSettingHeader = new CustomHeaderOption(num++, MultiMenu.main, "Mode Settings");
            CustomGameMode = new CustomStringOption(num++, MultiMenu.main, "Game Mode", new[] { "Standard", "Sherif Bomber", "Same Modifiers", "All Can Vent", "Random" });

            RoleListSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Role List Settings");
            UniqueRoles = new CustomToggleOption(num++, MultiMenu.main, "All Roles Are Unique", true);
            Slot1 = new CustomStringOption(num++, MultiMenu.main, "Slot 1", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot2 = new CustomStringOption(num++, MultiMenu.main, "Slot 2", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot3 = new CustomStringOption(num++, MultiMenu.main, "Slot 3", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot4 = new CustomStringOption(num++, MultiMenu.main, "Slot 4", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 15);
            Slot5 = new CustomStringOption(num++, MultiMenu.main, "Slot 5", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot6 = new CustomStringOption(num++, MultiMenu.main, "Slot 6", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot7 = new CustomStringOption(num++, MultiMenu.main, "Slot 7", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot8 = new CustomStringOption(num++, MultiMenu.main, "Slot 8", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot9 = new CustomStringOption(num++, MultiMenu.main, "Slot 9", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 15);
            Slot10 = new CustomStringOption(num++, MultiMenu.main, "Slot 10", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot11 = new CustomStringOption(num++, MultiMenu.main, "Slot 11", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot12 = new CustomStringOption(num++, MultiMenu.main, "Slot 12", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot13 = new CustomStringOption(num++, MultiMenu.main, "Slot 13", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot14 = new CustomStringOption(num++, MultiMenu.main, "Slot 14", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 15);
            Slot15 = new CustomStringOption(num++, MultiMenu.main, "Slot 15", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);

            MapSettings = new CustomHeaderOption(num++, MultiMenu.main, "Map Settings");
            RandomMapEnabled = new CustomToggleOption(num++, MultiMenu.main, "Choose Random Map", false);
            RandomMapSkeld = new CustomNumberOption(num++, MultiMenu.main, "Skeld Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapMira = new CustomNumberOption(num++, MultiMenu.main, "Mira Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapPolus = new CustomNumberOption(num++, MultiMenu.main, "Polus Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapAirship = new CustomNumberOption(num++, MultiMenu.main, "Airship Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapFungle = new CustomNumberOption(num++, MultiMenu.main, "Fungle Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapSubmerged = new CustomNumberOption(num++, MultiMenu.main, "Submerged Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapLevelImpostor = new CustomNumberOption(num++, MultiMenu.main, "Level Impostor Chance", 0f, 0f, 100f, 10f, PercentFormat);
            SmallMapHalfVision = new CustomToggleOption(num++, MultiMenu.main, "Half Vision On Skeld/Mira HQ", false);
            SmallMapDecreasedCooldown =
                new CustomNumberOption(num++, MultiMenu.main, "Mira HQ Decreased Cooldowns", 0f, 0f, 7.5f, 2.5f, CooldownFormat);
            LargeMapIncreasedCooldown =
                new CustomNumberOption(num++, MultiMenu.main, "Airship/Submerged Increased Cooldowns", 0f, 0f, 7.5f, 2.5f, CooldownFormat);
            SmallMapIncreasedShortTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "Skeld/Mira HQ Increased Short Tasks", 0, 0, 5, 1);
            SmallMapIncreasedLongTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "Skeld/Mira HQ Increased Long Tasks", 0, 0, 3, 1);
            LargeMapDecreasedShortTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "Airship/Submerged Decreased Short Tasks", 0, 0, 5, 1);
            LargeMapDecreasedLongTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "Airship/Submerged Decreased Long Tasks", 0, 0, 3, 1);

            BetterPolusSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Better Polus Settings");
            VentImprovements = new CustomToggleOption(num++, MultiMenu.main, "Better Polus Vent Layout", false);
            VitalsLab = new CustomToggleOption(num++, MultiMenu.main, "Vitals Moved To Lab", false);
            ColdTempDeathValley = new CustomToggleOption(num++, MultiMenu.main, "Cold Temp Moved To Death Valley", false);
            WifiChartCourseSwap =
                new CustomToggleOption(num++, MultiMenu.main, "Reboot Wifi And Chart Course Swapped", false);

            CustomGameSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Custom Game Settings");
            ColourblindComms = new CustomToggleOption(num++, MultiMenu.main, "Camouflaged Comms", false);
            CamoCommsKillAnyone = new CustomToggleOption(num++, MultiMenu.main, "Kill Anyone During Camouflaged Comms", false);
            ImpostorSeeRoles = new CustomToggleOption(num++, MultiMenu.main, "Impostors Can See The Roles Of Their Team", false);
            DeadSeeRoles =
                new CustomToggleOption(num++, MultiMenu.main, "Dead Can See Everyone's Roles/Votes", false);
            InitialCooldowns =
                new CustomNumberOption(num++, MultiMenu.main, "Game Start Cooldowns", 10f, 10f, 30f, 2.5f, CooldownFormat);
            ParallelMedScans = new CustomToggleOption(num++, MultiMenu.main, "Parallel Medbay Scans", false);
            SkipButtonDisable = new CustomStringOption(num++, MultiMenu.main, "Disable Meeting Skip Button", new[] { "No", "Emergency", "Always" });
            FirstDeathShield = new CustomToggleOption(num++, MultiMenu.main, "First Death Shield Next Game", false);
            NeutralEvilWinEndsGame = new CustomToggleOption(num++, MultiMenu.main, "Neutral Evil Win Ends Game", true);
            CrewKillersContinue = new CustomToggleOption(num++, MultiMenu.main, "Crew Killers Continue Game", false);
            VultureJanitorInSameGame = new CustomToggleOption(num++, MultiMenu.main, "Vulture and Janitor together in game", true);

            TaskTrackingSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Task Tracking Settings");
            SeeTasksDuringRound = new CustomToggleOption(num++, MultiMenu.main, "See Tasks During Round", false);
            SeeTasksDuringMeeting = new CustomToggleOption(num++, MultiMenu.main, "See Tasks During Meetings", false);
            SeeTasksWhenDead = new CustomToggleOption(num++, MultiMenu.main, "See Tasks When Dead", true);

            Assassin = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Assassin Ability</color>");
            NumberOfImpostorAssassins = new CustomNumberOption(num++, MultiMenu.imposter, "Number Of Impostor Assassins", 1, 0, 4, 1);
            NumberOfNeutralAssassins = new CustomNumberOption(num++, MultiMenu.imposter, "Number Of Neutral Assassins", 1, 0, 5, 1);
            AmneTurnImpAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "Amnesiac Turned Impostor Gets Ability", false);
            AmneTurnNeutAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "Amnesiac Turned Neutral Killing Gets Ability", false);
            TraitorCanAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "Traitor Gets Ability", false);
            AssassinKills = new CustomNumberOption(num++, MultiMenu.imposter, "Number Of Assassin Kills", 1, 1, 15, 1);
            AssassinMultiKill = new CustomToggleOption(num++, MultiMenu.imposter, "Assassin Can Kill More Than Once Per Meeting", false);
            AssassinCrewmateGuess = new CustomToggleOption(num++, MultiMenu.imposter, "Assassin Can Guess \"Crewmate\"", false);
            AssassinGuessNeutralBenign = new CustomToggleOption(num++, MultiMenu.imposter, "Assassin Can Guess Neutral Benign Roles", false);
            AssassinGuessNeutralEvil = new CustomToggleOption(num++, MultiMenu.imposter, "Assassin Can Guess Neutral Evil Roles", false);
            AssassinGuessNeutralKilling = new CustomToggleOption(num++, MultiMenu.imposter, "Assassin Can Guess Neutral Killing Roles", false);
            AssassinGuessImpostors = new CustomToggleOption(num++, MultiMenu.imposter, "Assassin Can Guess Impostor Roles", false);
            AssassinGuessModifiers = new CustomToggleOption(num++, MultiMenu.imposter, "Assassin Can Guess Crewmate Modifiers", false);
            AssassinGuessLovers = new CustomToggleOption(num++, MultiMenu.imposter, "Assassin Can Guess Lovers", false);

            Detective =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#4D4DFFFF>Detective</color>");
            ExamineCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Examine Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            DetectiveReportOn = new CustomToggleOption(num++, MultiMenu.crewmate, "Show Detective Reports", true);
            DetectiveRoleDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Time Where Detective Will Have Role", 15f, 0f, 60f, 2.5f,
                    CooldownFormat);
            DetectiveFactionDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Time Where Detective Will Have Faction", 30f, 0f, 60f, 2.5f,
                    CooldownFormat);

            Haunter =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#D3D3D3FF>Haunter</color>");
            HaunterTasksRemainingClicked =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "Tasks Remaining When Haunter Can Be Clicked", 5, 1, 15, 1);
            HaunterTasksRemainingAlert =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "Tasks Remaining When Alert Is Sent", 1, 1, 5, 1);
            HaunterRevealsNeutrals = new CustomToggleOption(num++, MultiMenu.crewmate, "Haunter Reveals Neutral Roles", false);
            HaunterCanBeClickedBy = new CustomStringOption(num++, MultiMenu.crewmate, "Who Can Click Haunter", new[] { "All", "Non-Crew", "Imps Only" });

            Investigator =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#00B3B3FF>Investigator</color>");
            FootprintSize = new CustomNumberOption(num++, MultiMenu.crewmate, "Footprint Size", 4f, 1f, 10f, 1f);
            FootprintInterval =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Footprint Interval", 0.1f, 0.05f, 1f, 0.05f, CooldownFormat);
            FootprintDuration = new CustomNumberOption(num++, MultiMenu.crewmate, "Footprint Duration", 10f, 1f, 15f, 0.5f, CooldownFormat);
            AnonymousFootPrint = new CustomToggleOption(num++, MultiMenu.crewmate, "Anonymous Footprint", false);
            VentFootprintVisible = new CustomToggleOption(num++, MultiMenu.crewmate, "Footprint Vent Visible", false);
            AuraInnerRadius =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Radiate Colour Range", 0.5f, 0f, 1f, 0.25f, MultiplierFormat);
            AuraOuterRadius =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Radiate Max Range", 1.5f, 1f, 5f, 0.25f, MultiplierFormat);
            SenseDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Sense Duration", 2f, 1f, 10f, 1f, CooldownFormat);

            Lookout =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#33FF66FF>Lookout</color>");
            WatchCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Watch Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            LoResetOnNewRound = new CustomToggleOption(num++, MultiMenu.crewmate, "Lookout Watches Reset After Each Round", true);
            MaxWatches = new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Players That Can Be Watched", 5, 1, 15, 1);

            Mystic =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#4D99E6FF>Mystic</color>");
            MysticArrowDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Dead Body Arrow Duration", 1.5f, 0f, 5f, 0.25f, CooldownFormat);
            MysticSleuthAbility = new CustomToggleOption(num++, MultiMenu.crewmate, "Mystic Sleuth Ability", false);

            Oracle =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#BF00BFFF>Oracle</color>");
            ConfessCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Confess Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RevealAccuracy = new CustomNumberOption(num++, MultiMenu.crewmate, "Reveal Accuracy", 80f, 0f, 100f, 10f,
                PercentFormat);
            NeutralBenignShowsEvil =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Neutral Benign Roles Show Evil", false);
            NeutralEvilShowsEvil =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Neutral Evil Roles Show Evil", false);
            NeutralKillingShowsEvil =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Neutral Killing Roles Show Evil", true);

            Seer =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFCC80FF>Seer</color>");
            SeerCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Seer Cooldown", 35f, 10f, 60f, 2.5f, CooldownFormat);
            CrewKillingRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Crewmate Killing Roles Are Red", false);
            NeutBenignRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Neutral Benign Roles Are Red", false);
            NeutEvilRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Neutral Evil Roles Are Red", false);
            NeutKillingRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Neutral Killing Roles Are Red", true);
            TraitorColourSwap =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Traitor Does Not Swap Colours", false);

            Snitch = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#D4AF37FF>Snitch</color>");
            SnitchSeesNeutrals = new CustomToggleOption(num++, MultiMenu.crewmate, "Snitch Sees Neutral Roles", false);
            SnitchTasksRemaining =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "Tasks Remaining When Revealed", 2, 1, 5, 1);
            SnitchSeesImpInMeeting = new CustomToggleOption(num++, MultiMenu.crewmate, "Snitch Sees Impostors In Meetings", true);
            SnitchSeesTraitor = new CustomToggleOption(num++, MultiMenu.crewmate, "Snitch Sees Traitor", true);

            Spy =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#CCA3CCFF>Spy</color>");
            WhoSeesDead = new CustomStringOption(num++, MultiMenu.crewmate, "Who Sees Dead Bodies On Admin",
                new[] { "Nobody", "Spy", "Everyone But Spy", "Everyone" });
            SpyAdminAnywhere = new CustomToggleOption(num++, MultiMenu.crewmate, "Spy Can Access Admin Map From Anywhere", true);
            SpyAdminTableCd = new CustomNumberOption(num++, MultiMenu.crewmate, "Admin Table Button From Anywhere Cooldown", 10f, 2.5f, 30f, 2.5f, CooldownFormat);
            SpyVitals = new CustomToggleOption(num++, MultiMenu.crewmate, "Spy Can Use Vitals", false);

            Tracker =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#009900FF>Tracker</color>");
            UpdateInterval =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Arrow Update Interval", 5f, 0.5f, 15f, 0.5f, CooldownFormat);
            TrackCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Track Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ResetOnNewRound = new CustomToggleOption(num++, MultiMenu.crewmate, "Tracker Arrows Reset After Each Round", true);
            MaxTracks = new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Tracks", 5, 1, 15, 1);

            Trapper =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#A7D1B3FF>Trapper</color>");
            MinAmountOfTimeInTrap =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Min Amount Of Time In Trap To Register", 1f, 0f, 15f, 0.5f, CooldownFormat);
            TrapCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Trap Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            TrapsRemoveOnNewRound =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Traps Removed After Each Round", true);
            MaxTraps =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Traps", 5, 1, 15, 1);
            TrapSize =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Trap Size", 0.25f, 0.05f, 1f, 0.05f, MultiplierFormat);
            MinAmountOfPlayersInTrap =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Minimum Number Of Roles Required To Trigger Trap", 3, 1, 5, 1);

            Hunter =
               new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#29AB87FF>Hunter</color>");
            HunterKillCd =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Hunter Kill Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            HunterStalkCd =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Hunter Stalk Cooldown", 10f, 1f, 15f, 1f, CooldownFormat);
            HunterStalkDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Hunter Stalk Duration", 25f, 5f, 60f, 2.5f, CooldownFormat);
            HunterStalkUses =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Stalk Uses", 5, 1, 15, 1);
            RetributionOnVote =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Hunter Kills Last Voter If Voted Out", false);
            HunterBodyReport =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Hunter Can Report Who They've Killed");

            Jailor =
               new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#A6A6A6FF>Jailor</color>");
            JailCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Jail Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MaxExecutes =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Executes", 3, 1, 5, 1);

            Sheriff =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>Sheriff</color>");
            SheriffKillOther =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Sheriff Miskill Kills Crewmate", false);
            SheriffKillsNE =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Sheriff Kills Neutral Evil Roles", false);
            SheriffKillsNK =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Sheriff Kills Neutral Killing Roles", false);
            SheriffKillCd =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Sheriff Kill Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            SheriffBodyReport = new CustomToggleOption(num++, MultiMenu.crewmate, "Sheriff Can Report Who They've Killed");

            Veteran =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#998040FF>Veteran</color>");
            KilledOnAlert =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Can Be Killed On Alert", false);
            AlertCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Alert Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            AlertDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Alert Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            MaxAlerts = new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Alerts", 5, 1, 15, 1);

            Vigilante = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFFF99FF>Vigilante</color>");
            VigilanteKills = new CustomNumberOption(num++, MultiMenu.crewmate, "Number Of Vigilante Kills", 1, 1, 15, 1);
            VigilanteMultiKill = new CustomToggleOption(num++, MultiMenu.crewmate, "Vigilante Can Kill More Than Once Per Meeting", false);
            VigilanteGuessNeutralBenign = new CustomToggleOption(num++, MultiMenu.crewmate, "Vigilante Can Guess Neutral Benign Roles", false);
            VigilanteGuessNeutralEvil = new CustomToggleOption(num++, MultiMenu.crewmate, "Vigilante Can Guess Neutral Evil Roles", false);
            VigilanteGuessNeutralKilling = new CustomToggleOption(num++, MultiMenu.crewmate, "Vigilante Can Guess Neutral Killing Roles", false);
            VigilanteGuessModifiers = new CustomToggleOption(num++, MultiMenu.crewmate, "Vigilante Can Guess Impostor Modifiers", false);
            VigilanteGuessLovers = new CustomToggleOption(num++, MultiMenu.crewmate, "Vigilante Can Guess Lovers", false);

            Altruist = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#660000FF>Altruist</color>");
            ReviveDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Altruist Revive Duration", 10f, 1f, 15f, 1f, CooldownFormat);
            AltruistTargetBody =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Target's Body Disappears On Beginning Of Revive", false);

            Medic =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#006600FF>Medic</color>");
            ShowShielded =
                new CustomStringOption(num++, MultiMenu.crewmate, "Show Shielded Player",
                    new[] { "Self", "Medic", "Self+Medic", "Everyone" });
            WhoGetsNotification =
                new CustomStringOption(num++, MultiMenu.crewmate, "Who Gets Murder Attempt Indicator",
                    new[] { "Medic", "Shielded", "Everyone", "Nobody" });
            ShieldBreaks = new CustomToggleOption(num++, MultiMenu.crewmate, "Shield Breaks On Murder Attempt", false);
            MedicReportSwitch = new CustomToggleOption(num++, MultiMenu.crewmate, "Show Medic Reports");
            MedicReportNameDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Time Where Medic Will Have Name", 0f, 0f, 60f, 2.5f,
                    CooldownFormat);
            MedicReportColorDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Time Where Medic Will Have Color Type", 15f, 0f, 60f, 2.5f,
                    CooldownFormat);

            Engineer =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFA60AFF>Engineer</color>");
            MaxFixes =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Fixes", 5, 1, 15, 1);

            Imitator =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#B3D94DFF>Imitator</color>");
            ImitatorCanBecomeMayor =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Imitator Can Become Mayor", true);
            ImitateAllCrewmates =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Imitator Can Imitate All Crewmates", false);

            Medium =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#A680FFFF>Medium</color>");
            MediateCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Mediate Cooldown", 10f, 1f, 15f, 1f, CooldownFormat);
            ShowMediatePlayer =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Reveal Appearance Of Mediate Target", true);
            ShowMediumToDead =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Reveal The Medium To The Mediate Target", true);
            DeadRevealed =
                new CustomStringOption(num++, MultiMenu.crewmate, "Who Is Revealed With Mediate", new[] { "Oldest Dead", "Newest Dead", "All Dead" });

            Politician =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#660099FF>Politician</color>");
            CampaignCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Campaign Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);

            Prosecutor =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#B38000FF>Prosecutor</color>");
            ProsDiesOnIncorrectPros =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Prosecutor Dies When They Exile A Crewmate", false);

            Swapper =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#66E666FF>Swapper</color>");
            SwapperButton =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Swapper Can Button", true);

            Transporter =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#00EEFFFF>Transporter</color>");
            TransportCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Transport Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            TransportMaxUses =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Transports", 5, 1, 15, 1);
            TransporterVitals =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Transporter Can Use Vitals", false);

            Amnesiac = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#80B2FFFF>Amnesiac</color>");
            RememberArrows =
                new CustomToggleOption(num++, MultiMenu.neutral, "Amnesiac Gets Arrows Pointing To Dead Bodies", true);
            RememberArrowDelay =
                new CustomNumberOption(num++, MultiMenu.neutral, "Time After Death Arrow Appears", 3f, 0f, 15f, 1f, CooldownFormat);

            GuardianAngel =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#B3FFFFFF>Guardian Angel</color>");
            ProtectCd =
                new CustomNumberOption(num++, MultiMenu.neutral, "Protect Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ProtectDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "Protect Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            ProtectKCReset =
                new CustomNumberOption(num++, MultiMenu.neutral, "Kill Cooldown Reset When Protected", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxProtects =
                new CustomNumberOption(num++, MultiMenu.neutral, "Maximum Number Of Protects", 5, 1, 15, 1);
            ShowProtect =
                new CustomStringOption(num++, MultiMenu.neutral, "Show Protected Player",
                    new[] { "Self", "Guardian Angel", "Self+GA", "Everyone" });
            GaOnTargetDeath = new CustomStringOption(num++, MultiMenu.neutral, "GA Becomes On Target Dead",
                new[] { "Crew", "Amnesiac", "Survivor", "Jester" });
            GATargetKnows =
                new CustomToggleOption(num++, MultiMenu.neutral, "Target Knows GA Exists", false);
            GAKnowsTargetRole =
                new CustomToggleOption(num++, MultiMenu.neutral, "GA Knows Targets Role", false);
            EvilTargetPercent = new CustomNumberOption(num++, MultiMenu.neutral, "Odds Of Target Being Evil", 50f, 0f, 100f, 10f,
                PercentFormat);

            Survivor =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FFE64DFF>Survivor</color>");
            VestCd =
                new CustomNumberOption(num++, MultiMenu.neutral, "Vest Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            VestDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "Vest Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            VestKCReset =
                new CustomNumberOption(num++, MultiMenu.neutral, "Kill Cooldown Reset On Attack", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxVests =
                new CustomNumberOption(num++, MultiMenu.neutral, "Maximum Number Of Vests", 5, 1, 15, 1);

            Doomsayer = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#00FF80FF>Doomsayer</color>");
            ObserveCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Observe Cooldown", 45f, 10f, 60f, 2.5f, CooldownFormat);
            DoomsayerGuessNeutralBenign = new CustomToggleOption(num++, MultiMenu.neutral, "Doomsayer Can Guess Neutral Benign Roles", false);
            DoomsayerGuessNeutralEvil = new CustomToggleOption(num++, MultiMenu.neutral, "Doomsayer Can Guess Neutral Evil Roles", false);
            DoomsayerGuessNeutralKilling = new CustomToggleOption(num++, MultiMenu.neutral, "Doomsayer Can Guess Neutral Killing Roles", false);
            DoomsayerGuessImpostors = new CustomToggleOption(num++, MultiMenu.neutral, "Doomsayer Can Guess Impostor Roles", false);
            DoomsayerCantObserve = new CustomToggleOption(num++, MultiMenu.neutral, "Doomsayer Can't Observe", false);
            DoomsayerKillNeedToVictory = new CustomNumberOption(num++, MultiMenu.neutral, "Kill Count Need To Vicotory", 3, 1, 10, 1);
            DoomsayerObserveRoleCount = new CustomNumberOption(num++, MultiMenu.neutral, "Role count shown with observe", 5, 3, 5, 1);

            Executioner =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#8C4005FF>Executioner</color>");
            OnTargetDead = new CustomStringOption(num++, MultiMenu.neutral, "Executioner Becomes On Target Dead",
                new[] { "Crew", "Amnesiac", "Survivor", "Jester" });
            ExecutionerButton =
                new CustomToggleOption(num++, MultiMenu.neutral, "Executioner Can Button", true);
            ExecutionerTorment =
                new CustomToggleOption(num++, MultiMenu.neutral, "Executioner Torments Player On Victory", true);

            Jester =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FFBFCCFF>Jester</color>");
            JesterButton =
                new CustomToggleOption(num++, MultiMenu.neutral, "Jester Can Button", true);
            JesterVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "Jester Can Hide In Vents", false);
            JesterImpVision =
                new CustomToggleOption(num++, MultiMenu.neutral, "Jester Has Impostor Vision", false);
            JesterHaunt =
                new CustomToggleOption(num++, MultiMenu.neutral, "Jester Haunts Player On Victory", true);

            Phantom =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#662962FF>Phantom</color>");
            PhantomTasksRemaining =
                 new CustomNumberOption(num++, MultiMenu.neutral, "Tasks Remaining When Phantom Can Be Clicked", 5, 1, 15, 1);
            PhantomSpook =
                new CustomToggleOption(num++, MultiMenu.neutral, "Phantom Spooks Player On Victory", true);

            SoulCollector =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#99FFCCFF>Soul Collector</color>");
            ReapCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Reap Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PassiveSoulCollection =
                new CustomToggleOption(num++, MultiMenu.neutral, "Passively Collect A Soul Each Round", true);
            SoulsToWin =
                 new CustomNumberOption(num++, MultiMenu.neutral, "Amount Of Souls Required To Win", 5, 1, 15, 1);

            Wraith = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FF4D00FF>Wraith</color>");
            WraithKillCd = new CustomNumberOption(num++, MultiMenu.neutral, "Wraith Kill Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            WraithCooldown = new CustomNumberOption(num++, MultiMenu.neutral, "Wraith Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            WraithDuration = new CustomNumberOption(num++, MultiMenu.neutral, "Wraith Duration", 10f, 5f, 25f, 1f, CooldownFormat);
            WraithVent = new CustomToggleOption(num++, MultiMenu.neutral, "Wraith Can Vent", false);

            Juggernaut =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#8C004DFF>Juggernaut</color>");
            JuggKillCooldown = new CustomNumberOption(num++, MultiMenu.neutral, "Juggernaut Initial Kill Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ReducedKCdPerKill = new CustomNumberOption(num++, MultiMenu.neutral, "Reduced Kill Cooldown Per Kill", 5f, 2.5f, 10f, 2.5f, CooldownFormat);
            JuggVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "Juggernaut Can Vent", false);

            Plaguebearer = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#E6FFB3FF>Plaguebearer</color>");
            InfectCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Infect Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PestKillCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Pestilence Kill Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PestVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "Pestilence Can Vent", false);

            TheGlitch =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#00FF00FF>The Glitch</color>");
            MimicCooldownOption = new CustomNumberOption(num++, MultiMenu.neutral, "Mimic Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MimicDurationOption = new CustomNumberOption(num++, MultiMenu.neutral, "Mimic Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            HackCooldownOption = new CustomNumberOption(num++, MultiMenu.neutral, "Hack Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            HackDurationOption = new CustomNumberOption(num++, MultiMenu.neutral, "Hack Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            GlitchKillCooldownOption =
                new CustomNumberOption(num++, MultiMenu.neutral, "Glitch Kill Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            GlitchHackDistanceOption =
                new CustomStringOption(num++, MultiMenu.neutral, "Glitch Hack Distance", new[] { "Short", "Normal", "Long" });
            GlitchVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "Glitch Can Vent", false);

            Vampire = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#262626FF>Vampire</color>");
            BiteCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Vampire Bite Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            VampImpVision =
                new CustomToggleOption(num++, MultiMenu.neutral, "Vampires Have Impostor Vision", false);
            VampVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "Vampires Can Vent", false);
            NewVampCanAssassin =
                new CustomToggleOption(num++, MultiMenu.neutral, "New Vampire Can Assassinate", false);
            MaxVampiresPerGame =
                new CustomNumberOption(num++, MultiMenu.neutral, "Maximum Vampires Per Game", 2, 2, 5, 1);
            CanBiteNeutralBenign =
                new CustomToggleOption(num++, MultiMenu.neutral, "Can Convert Neutral Benign Roles", false);
            CanBiteNeutralEvil =
                new CustomToggleOption(num++, MultiMenu.neutral, "Can Convert Neutral Evil Roles", false);

            Werewolf = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#A86629FF>Werewolf</color>");
            RampageCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Rampage Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RampageDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "Rampage Duration", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RampageKillCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Rampage Kill Cooldown", 10f, 0.5f, 15f, 0.5f, CooldownFormat);
            WerewolfVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "Werewolf Can Vent When Rampaged", false);

            Vulture = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FF4D00FF>Vulture</color>");
            VultureKillCooldown = new CustomNumberOption(num++, MultiMenu.neutral, "Vulture Eat Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            VultureRememberArrows =
                new CustomToggleOption(num++, MultiMenu.neutral, "Vulture Gets Arrows Pointing To Dead Bodies", true);
            VultureRememberArrowDelay =
                new CustomNumberOption(num++, MultiMenu.neutral, "Time After Death Arrow Appears", 3f, 0f, 15f, 1f, CooldownFormat);
            VultureEatCount = new CustomNumberOption(num++, MultiMenu.neutral, "Eat Count Need To Vicotory", 3, 1, 15, 1);

            Escapist =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Escapist</color>");
            EscapeCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Recall Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            EscapistVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "Escapist Can Vent", false);

            Grenadier =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Grenadier</color>");
            GrenadeCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Flash Grenade Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            GrenadeDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Flash Grenade Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            FlashRadius =
                new CustomNumberOption(num++, MultiMenu.imposter, "Flash Radius", 1f, 0.25f, 5f, 0.25f, MultiplierFormat);
            GrenadierIndicators =
                new CustomToggleOption(num++, MultiMenu.imposter, "Indicate Flashed Crewmates", false);
            GrenadierVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "Grenadier Can Vent", false);

            Morphling =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Morphling</color>");
            MorphlingCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Morphling Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MorphlingDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Morphling Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            MorphlingVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "Morphling Can Vent", false);

            Swooper = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Swooper</color>");
            SwoopCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Swoop Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            SwoopDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Swoop Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            SwooperVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "Swooper Can Vent", false);

            Venerer = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Venerer</color>");
            AbilityCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Ability Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            AbilityDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Ability Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            SprintSpeed = new CustomNumberOption(num++, MultiMenu.imposter, "Sprint Speed", 1.25f, 1.05f, 2.5f, 0.05f, MultiplierFormat);
            FreezeSpeed = new CustomNumberOption(num++, MultiMenu.imposter, "Freeze Speed", 0.75f, 0.25f, 1f, 0.05f, MultiplierFormat);

            Arsonist = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Arsonist</color>");
            DouseCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Douse Cooldown", 15f, 10f, 60f, 2.5f, CooldownFormat);
            MaxDoused =
                new CustomNumberOption(num++, MultiMenu.imposter, "Maximum Alive Players Doused", 5, 1, 15, 1);
            ArsoImpVision =
                new CustomToggleOption(num++, MultiMenu.imposter, "Arsonist Has Impostor Vision", true);
            IgniteCdRemoved =
                new CustomToggleOption(num++, MultiMenu.imposter, "Ignite Cooldown Removed When Arsonist Is Last Killer", false);

            Bomber =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Bomber</color>");
            DetonateDelay =
                new CustomNumberOption(num++, MultiMenu.imposter, "Detonate Delay", 5f, 1f, 15f, 1f, CooldownFormat);
            MaxKillsInDetonation =
                new CustomNumberOption(num++, MultiMenu.imposter, "Max Kills In Detonation", 5, 1, 15, 1);
            DetonateRadius =
                new CustomNumberOption(num++, MultiMenu.imposter, "Detonate Radius", 0.25f, 0.05f, 1f, 0.05f, MultiplierFormat);
            BomberVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "Bomber Can Vent", false);
            AllImpsSeeBomb =
                new CustomToggleOption(num++, MultiMenu.imposter, "All Impostors See Bomb", false);

            Scavenger = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Scavenger</color>");
            ScavengeDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Scavenge Duration", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ScavengeIncreaseDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Scavenge Duration Increase Per Kill", 10f, 5f, 15f, 0.5f, CooldownFormat);
            ScavengeCorrectKillCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Scavenge Kill Cooldown On Correct Kill", 10f, 5f, 15f, 0.5f, CooldownFormat);
            ScavengeIncorrectKillCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Kill Cooldown Multiplier On Incorrect Kill", 3f, 1.25f, 5f, 0.25f, MultiplierFormat);

            Traitor = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Traitor</color>");
            LatestSpawn = new CustomNumberOption(num++, MultiMenu.imposter, "Minimum People Alive When Traitor Can Spawn", 5, 3, 15, 1);
            NeutralKillingStopsTraitor =
                new CustomToggleOption(num++, MultiMenu.imposter, "Traitor Won't Spawn If Any Neutral Killing Is Alive", false);

            Warlock = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Warlock</color>");
            ChargeUpDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Time It Takes To Fully Charge", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ChargeUseDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Time It Takes To Use Full Charge", 1f, 0.05f, 5f, 0.05f, CooldownFormat);

            Blackmailer = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Blackmailer</color>");
            BlackmailCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Initial Blackmail Cooldown", 10f, 1f, 15f, 1f, CooldownFormat);
            BlackmailInvisible =
                new CustomToggleOption(num++, MultiMenu.imposter, "Only Target Sees Blackmail", false);
            LatestNonVote = new CustomNumberOption(num++, MultiMenu.imposter, "Maximum People Alive Where Blackmailed Can Vote", 5, 1, 15, 1);

            Hypnotist = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Hypnotist</color>");
            HypnotiseCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Hypnotize Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);

            Miner = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Miner</color>");
            MineCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Mine Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);

            Undertaker = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Undertaker</color>");
            DragCooldown = new CustomNumberOption(num++, MultiMenu.imposter, "Drag Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            UndertakerDragSpeed =
                new CustomNumberOption(num++, MultiMenu.imposter, "Undertaker Drag Speed", 0.75f, 0.25f, 1f, 0.05f, MultiplierFormat);
            UndertakerVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "Undertaker Can Vent", false);
            UndertakerVentWithBody =
                new CustomToggleOption(num++, MultiMenu.imposter, "Undertaker Can Vent While Dragging", false);

            Bait = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#33B3B3FF>Bait</color>");
            BaitMinDelay = new CustomNumberOption(num++, MultiMenu.modifiers, "Minimum Delay for the Bait Report", 0f, 0f, 15f, 0.5f, CooldownFormat);
            BaitMaxDelay = new CustomNumberOption(num++, MultiMenu.modifiers, "Maximum Delay for the Bait Report", 2f, 0f, 15f, 0.5f, CooldownFormat);

            Diseased = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#808080FF>Diseased</color>");
            DiseasedKillMultiplier = new CustomNumberOption(num++, MultiMenu.modifiers, "Diseased Kill Multiplier", 3f, 1.5f, 5f, 0.5f, MultiplierFormat);

            Frosty = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#99FFFFFF>Frosty</color>");
            ChillDuration = new CustomNumberOption(num++, MultiMenu.modifiers, "Chill Duration", 10f, 1f, 15f, 1f, CooldownFormat);
            ChillStartSpeed = new CustomNumberOption(num++, MultiMenu.modifiers, "Chill Start Speed", 0.75f, 0.25f, 0.95f, 0.05f, MultiplierFormat);

            Flash = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF8080FF>Flash</color>");
            FlashSpeed = new CustomNumberOption(num++, MultiMenu.modifiers, "Flash Speed", 1.25f, 1.05f, 2.5f, 0.05f, MultiplierFormat);

            Giant = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FFB34DFF>Giant</color>");
            GiantSlow = new CustomNumberOption(num++, MultiMenu.modifiers, "Giant Speed", 0.75f, 0.25f, 1f, 0.05f, MultiplierFormat);

            Lovers =
                new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF66CCFF>Lovers</color>");
            BothLoversDie = new CustomToggleOption(num++, MultiMenu.modifiers, "Both Lovers Die");
            LovingImpPercent = new CustomNumberOption(num++, MultiMenu.modifiers, "Loving Impostor Probability", 50f, 0f, 100f, 10f,
                PercentFormat);
            NeutralLovers = new CustomToggleOption(num++, MultiMenu.modifiers, "Neutral Roles Can Be Lovers");
            ImpLoverKillTeammate = new CustomToggleOption(num++, MultiMenu.modifiers, "Impostor Lover Can Kill Teammate", false);

            Shy = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FFB3CCFF>Shy</color>");
            InvisDelay = new CustomNumberOption(num++, MultiMenu.modifiers, "Transparency Delay", 5f, 1f, 15f, 1f, CooldownFormat);
            TransformInvisDuration = new CustomNumberOption(num++, MultiMenu.modifiers, "Turn Transparent Duration", 5f, 1f, 15f, 1f, CooldownFormat);
            FinalTransparency = new CustomNumberOption(num++, MultiMenu.modifiers, "Final Opacity", 20f, 0f, 80f, 10f, PercentFormat);

            Saboteur = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF0000FF>Saboteur</color>");
            ReducedSaboCooldown = new CustomNumberOption(num++, MultiMenu.modifiers, "Reduced Sabotage Bonus", 10f, 5f, 15f, 1f, CooldownFormat);

            Underdog = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF0000FF>Underdog</color>");
            UnderdogKillBonus = new CustomNumberOption(num++, MultiMenu.modifiers, "Kill Cooldown Bonus", 5f, 2.5f, 10f, 2.5f, CooldownFormat);
            UnderdogIncreasedKC = new CustomToggleOption(num++, MultiMenu.modifiers, "Increased Kill Cooldown When 2+ Imps", true);
        }
    }
}