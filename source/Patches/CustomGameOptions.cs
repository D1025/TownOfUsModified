using TownOfUs.CrewmateRoles.MedicMod;
using TownOfUs.CustomOption;
using TownOfUs.NeutralRoles.ExecutionerMod;
using TownOfUs.CrewmateRoles.HaunterMod;
using TownOfUs.CrewmateRoles.MediumMod;
using TownOfUs.NeutralRoles.GuardianAngelMod;
using System;

namespace TownOfUs
{
    public enum DisableSkipButtonMeetings
    {
        No,
        Emergency,
        Always
    }
    public enum AdminDeadPlayers
    {
        Nobody,
        Spy,
        EveryoneButSpy,
        Everyone
    }
    public enum RoleOptions
    {
        CrewInvest,
        CrewKilling,
        CrewProtective,
        CrewSupport,
        CrewCommon,
        CrewRandom,
        NeutBenign,
        NeutEvil,
        NeutKilling,
        NeutCommon,
        NeutRandom,
        ImpConceal,
        ImpKilling,
        ImpSupport,
        ImpCommon,
        ImpRandom,
        NonImp,
        Any
    }

    public enum GameType
    {
        Standard,
        SherifBomber,
        SameModifier,
        AllCanVent,
        Random
    }
    public static class CustomGameOptions
    {
        public static GameType CustomGameMode => (GameType)Generate.CustomGameMode.Get();
        public static bool AllSameModifier { get; set; } = false;
        public static bool SheriffBomberMode { get; set; } = false;
        public static bool AllVent { get; set; } = false;
        public static bool PoliticianOn => Generate.PoliticianOn.Get();
        public static bool JesterOn => Generate.JesterOn.Get();
        public static bool SheriffOn => Generate.SheriffOn.Get();
        public static bool JanitorOn => Generate.JanitorOn.Get();
        public static bool EngineerOn => Generate.EngineerOn.Get();
        public static bool SwapperOn => Generate.SwapperOn.Get();
        public static bool AmnesiacOn => Generate.AmnesiacOn.Get();
        public static bool InvestigatorOn => Generate.InvestigatorOn.Get();
        public static bool MedicOn => Generate.MedicOn.Get();
        public static bool SeerOn => Generate.SeerOn.Get();
        public static bool GlitchOn => Generate.GlitchOn.Get();
        public static bool MorphlingOn => Generate.MorphlingOn.Get();
        public static bool ExecutionerOn => Generate.ExecutionerOn.Get();
        public static bool SpyOn => Generate.SpyOn.Get();
        public static bool SnitchOn => Generate.SnitchOn.Get();
        public static bool MinerOn => Generate.MinerOn.Get();
        public static bool SwooperOn => Generate.SwooperOn.Get();
        public static bool ArsonistOn => Generate.ArsonistOn.Get();
        public static bool AltruistOn => Generate.AltruistOn.Get();
        public static bool UndertakerOn => Generate.UndertakerOn.Get();
        public static bool PhantomOn => Generate.PhantomOn.Get();
        public static bool HunterOn => Generate.HunterOn.Get();
        public static bool VigilanteOn => Generate.VigilanteOn.Get();
        public static bool HaunterOn => Generate.HaunterOn.Get();
        public static bool GrenadierOn => Generate.GrenadierOn.Get();
        public static bool VeteranOn => Generate.VeteranOn.Get();
        public static bool TrackerOn => Generate.TrackerOn.Get();
        public static bool TrapperOn => Generate.TrapperOn.Get();
        public static bool TraitorOn => Generate.TraitorOn.Get();
        public static bool TransporterOn => Generate.TransporterOn.Get();
        public static bool MediumOn => Generate.MediumOn.Get();
        public static bool SurvivorOn => Generate.SurvivorOn.Get();
        public static bool GuardianAngelOn => Generate.GuardianAngelOn.Get();
        public static bool MysticOn => Generate.MysticOn.Get();
        public static bool BlackmailerOn => Generate.BlackmailerOn.Get();
        public static bool PlaguebearerOn => Generate.PlaguebearerOn.Get();
        public static bool WerewolfOn => Generate.WerewolfOn.Get();
        public static bool DetectiveOn => Generate.DetectiveOn.Get();
        public static bool EscapistOn => Generate.EscapistOn.Get();
        public static bool ImitatorOn => Generate.ImitatorOn.Get();
        public static bool BomberOn => Generate.BomberOn.Get();
        public static bool DoomsayerOn => Generate.DoomsayerOn.Get();
        public static bool VampireOn => Generate.VampireOn.Get();
        public static bool ProsecutorOn => Generate.ProsecutorOn.Get();
        public static bool WarlockOn => Generate.WarlockOn.Get();
        public static bool OracleOn => Generate.OracleOn.Get();
        public static bool VenererOn => Generate.VenererOn.Get();
        public static bool AurialOn => false;
        public static bool WardenOn => Generate.WardenOn.Get();
        public static bool HypnotistOn => Generate.HypnotistOn.Get();
        public static bool JailorOn => Generate.JailorOn.Get();
        public static bool SoulCollectorOn => Generate.SoulCollectorOn.Get();
        public static bool VultureOn => Generate.VultureOn.Get();
        public static bool LookoutOn => Generate.LookoutOn.Get();
        public static bool ScavengerOn => Generate.ScavengerOn.Get();
        public static bool DeputyOn => Generate.DeputyOn.Get();
        public static bool JuggernautOn => Generate.JuggernautOn.Get();
        public static bool WraithOn => Generate.WraithOn.Get();
        public static int PoliticianValue { get; set; } = 10;
        public static int JesterValue { get; set; } = 10;
        public static int SheriffValue { get; set; } = 10;
        public static int JanitorValue { get; set; } = 10;
        public static int EngineerValue { get; set; } = 10;
        public static int SwapperValue { get; set; } = 10;
        public static int AmnesiacValue { get; set; } = 10;
        public static int InvestigatorValue { get; set; } = 10;
        public static int MedicValue { get; set; } = 10;
        public static int SeerValue { get; set; } = 10;
        public static int GlitchValue { get; set; } = 10;
        public static int MorphlingValue { get; set; } = 10;
        public static int ExecutionerValue { get; set; } = 10;
        public static int SpyValue { get; set; } = 10;
        public static int SnitchValue { get; set; } = 10;
        public static int MinerValue { get; set; } = 10;
        public static int SwooperValue { get; set; } = 10;
        public static int ArsonistValue { get; set; } = 10;
        public static int AltruistValue { get; set; } = 10;
        public static int UndertakerValue { get; set; } = 10;
        public static int PhantomValue { get; set; } = 10;
        public static int HunterValue { get; set; } = 10;
        public static int VigilanteValue { get; set; } = 10;
        public static int HaunterValue { get; set; } = 10;
        public static int GrenadierValue { get; set; } = 10;
        public static int VeteranValue { get; set; } = 10;
        public static int TrackerValue { get; set; } = 10;
        public static int TrapperValue { get; set; } = 10;
        public static int TraitorValue { get; set; } = 10;
        public static int TransporterValue { get; set; } = 10;
        public static int MediumValue { get; set; } = 10;
        public static int SurvivorValue { get; set; } = 10;
        public static int GuardianAngelValue { get; set; } = 10;
        public static int MysticValue { get; set; } = 10;
        public static int BlackmailerValue { get; set; } = 10;
        public static int PlaguebearerValue { get; set; } = 10;
        public static int WerewolfValue { get; set; } = 10;
        public static int DetectiveValue { get; set; } = 10;
        public static int EscapistValue { get; set; } = 10;
        public static int ImitatorValue { get; set; } = 10;
        public static int BomberValue { get; set; } = 10;
        public static int DoomsayerValue { get; set; } = 10;
        public static int VampireValue { get; set; } = 10;
        public static int ProsecutorValue { get; set; } = 10;
        public static int WarlockValue { get; set; } = 10;
        public static int OracleValue { get; set; } = 10;
        public static int VenererValue { get; set; } = 10;
        public static int AurialValue { get; set; } = 10;
        public static int WardenValue { get; set; } = 10;
        public static int HypnotistValue { get; set; } = 10;
        public static int JailorValue { get; set; } = 10;
        public static int SoulCollectorValue { get; set; } = 10;
        public static int VultureValue { get; set; } = 10;
        public static int LookoutValue { get; set; } = 10;
        public static int ScavengerValue { get; set; } = 10;
        public static int DeputyValue { get; set; } = 10;
        public static int JuggernautValue { get; set; } = 10;
        public static int WraithValue { get; set; } = 10;
        public static int TorchOn => (int)Generate.TorchOn.Get();
        public static int DiseasedOn => (int)Generate.DiseasedOn.Get();
        public static int FlashOn => (int)Generate.FlashOn.Get();
        public static int TiebreakerOn => (int)Generate.TiebreakerOn.Get();
        public static int GiantOn => (int)Generate.GiantOn.Get();
        public static int ButtonBarryOn => (int)Generate.ButtonBarryOn.Get();
        public static int BaitOn => (int)Generate.BaitOn.Get();
        public static int LoversOn => (int)Generate.LoversOn.Get();
        public static int SleuthOn => (int)Generate.SleuthOn.Get();
        public static int AftermathOn => (int)Generate.AftermathOn.Get();
        public static int RadarOn => (int)Generate.RadarOn.Get();
        public static int DisperserOn => (int)Generate.DisperserOn.Get();
        public static int MultitaskerOn => (int)Generate.MultitaskerOn.Get();
        public static int DoubleShotOn => (int)Generate.DoubleShotOn.Get();
        public static int UnderdogOn => (int)Generate.UnderdogOn.Get();
        public static int FrostyOn => (int)Generate.FrostyOn.Get();
        public static int SixthSenseOn => (int)Generate.SixthSenseOn.Get();
        public static int ShyOn => (int)Generate.ShyOn.Get();
        public static int MiniOn => (int)Generate.MiniOn.Get();
        public static int SaboteurOn => (int)Generate.SaboteurOn.Get();
        public static int DrunkOn => (int)Generate.DrunkOn.Get();
        public static int ErrorOn => (int)Generate.ErrorOn.Get();
        public static float InitialCooldowns => Generate.InitialCooldowns.Get();
        public static bool BothLoversDie => Generate.BothLoversDie.Get();
        public static bool NeutralLovers => Generate.NeutralLovers.Get();
        public static bool ImpLoverKillTeammate => Generate.ImpLoverKillTeammate.Get();
        public static bool SheriffKillOther => Generate.SheriffKillOther.Get();
        public static bool SheriffKillsNE => Generate.SheriffKillsNE.Get();
        public static bool SheriffKillsNK => Generate.SheriffKillsNK.Get();
        public static float SheriffKillCd => Generate.SheriffKillCd.Get();
        public static bool SwapperButton => Generate.SwapperButton.Get();
        public static float FootprintSize => Generate.FootprintSize.Get();
        public static float FootprintInterval => Generate.FootprintInterval.Get();
        public static float FootprintDuration => Generate.FootprintDuration.Get();
        public static bool AnonymousFootPrint => Generate.AnonymousFootPrint.Get();
        public static bool VentFootprintVisible => Generate.VentFootprintVisible.Get();
        public static bool JesterButton => Generate.JesterButton.Get();
        public static bool JesterVent => Generate.JesterVent.Get();
        public static bool JesterImpVision => Generate.JesterImpVision.Get();
        public static bool JesterHaunt => Generate.JesterHaunt.Get();
        public static ShieldOptions ShowShielded => (ShieldOptions)Generate.ShowShielded.Get();

        public static NotificationOptions NotificationShield =>
            (NotificationOptions)Generate.WhoGetsNotification.Get();

        public static bool ShieldBreaks => Generate.ShieldBreaks.Get();
        public static float MedicReportNameDuration => Generate.MedicReportNameDuration.Get();
        public static float MedicReportColorDuration => Generate.MedicReportColorDuration.Get();
        public static bool ShowReports => Generate.MedicReportSwitch.Get();
        public static float SeerCd => Generate.SeerCooldown.Get();
        public static bool CrewKillingRed => Generate.CrewKillingRed.Get();
        public static bool NeutBenignRed => Generate.NeutBenignRed.Get();
        public static bool NeutEvilRed => Generate.NeutEvilRed.Get();
        public static bool NeutKillingRed => Generate.NeutKillingRed.Get();
        public static bool TraitorColourSwap => Generate.TraitorColourSwap.Get();
        public static float MimicCooldown => Generate.MimicCooldownOption.Get();
        public static float MimicDuration => Generate.MimicDurationOption.Get();
        public static float HackCooldown => Generate.HackCooldownOption.Get();
        public static float HackDuration => Generate.HackDurationOption.Get();
        public static float GlitchKillCooldown => Generate.GlitchKillCooldownOption.Get();
        public static int GlitchHackDistance => Generate.GlitchHackDistanceOption.Get();
        public static bool GlitchVent => Generate.GlitchVent.Get();
        public static float JuggKCd => Generate.JuggKillCooldown.Get();
        public static float ReducedKCdPerKill => Generate.ReducedKCdPerKill.Get();
        public static bool JuggVent => Generate.JuggVent.Get();
        public static float MorphlingCd => Generate.MorphlingCooldown.Get();
        public static float MorphlingDuration => Generate.MorphlingDuration.Get();
        public static bool MorphlingVent => Generate.MorphlingVent.Get();
        public static bool ColourblindComms => Generate.ColourblindComms.Get();
        public static OnTargetDead OnTargetDead => (OnTargetDead)Generate.OnTargetDead.Get();
        public static bool ExecutionerButton => Generate.ExecutionerButton.Get();
        public static bool ExecutionerTorment => Generate.ExecutionerTorment.Get();
        public static bool SnitchSeesNeutrals => Generate.SnitchSeesNeutrals.Get();
        public static int SnitchTasksRemaining => (int)Generate.SnitchTasksRemaining.Get();
        public static bool SnitchSeesImpInMeeting => Generate.SnitchSeesImpInMeeting.Get();
        public static bool SnitchSeesTraitor => Generate.SnitchSeesTraitor.Get();
        public static float MineCd => Generate.MineCooldown.Get();
        public static float SwoopCd => Generate.SwoopCooldown.Get();
        public static float SwoopDuration => Generate.SwoopDuration.Get();
        public static bool SwooperVent => Generate.SwooperVent.Get();
        public static bool ImpostorSeeRoles => Generate.ImpostorSeeRoles.Get();
        public static bool DeadSeeRoles => Generate.DeadSeeRoles.Get();
        public static bool FirstDeathShield => Generate.FirstDeathShield.Get();
        public static bool NeutralEvilWinEndsGame => Generate.NeutralEvilWinEndsGame.Get();
        public static bool SeeTasksDuringRound => Generate.SeeTasksDuringRound.Get();
        public static bool SeeTasksDuringMeeting => Generate.SeeTasksDuringMeeting.Get();
        public static bool SeeTasksWhenDead => Generate.SeeTasksWhenDead.Get();
        public static float DouseCd => Generate.DouseCooldown.Get();
        public static int MaxDoused => (int)Generate.MaxDoused.Get();
        public static bool ArsoImpVision => Generate.ArsoImpVision.Get();
        public static bool IgniteCdRemoved => Generate.IgniteCdRemoved.Get();
        public static bool ParallelMedScans => Generate.ParallelMedScans.Get();
        public static int MaxFixes => (int)Generate.MaxFixes.Get();
        public static float ReviveDuration => Generate.ReviveDuration.Get();
        public static bool AltruistTargetBody => Generate.AltruistTargetBody.Get();
        public static bool SheriffBodyReport => Generate.SheriffBodyReport.Get();
        public static float DragCd => Generate.DragCooldown.Get();
        public static float UndertakerDragSpeed => Generate.UndertakerDragSpeed.Get();
        public static bool UndertakerVent => Generate.UndertakerVent.Get();
        public static bool UndertakerVentWithBody => Generate.UndertakerVentWithBody.Get();
        public static bool AssassinGuessNeutralBenign => Generate.AssassinGuessNeutralBenign.Get();
        public static bool AssassinGuessNeutralEvil => Generate.AssassinGuessNeutralEvil.Get();
        public static bool AssassinGuessNeutralKilling => Generate.AssassinGuessNeutralKilling.Get();
        public static bool AssassinGuessImpostors => Generate.AssassinGuessImpostors.Get();
        public static bool AssassinGuessModifiers => Generate.AssassinGuessModifiers.Get();
        public static bool AssassinGuessLovers => Generate.AssassinGuessLovers.Get();
        public static bool AssassinCrewmateGuess => Generate.AssassinCrewmateGuess.Get();
        public static int AssassinKills => (int)Generate.AssassinKills.Get();
        public static int NumberOfImpostorAssassins => (int)Generate.NumberOfImpostorAssassins.Get();
        public static int NumberOfNeutralAssassins => (int)Generate.NumberOfNeutralAssassins.Get();
        public static bool AmneTurnImpAssassin => Generate.AmneTurnImpAssassin.Get();
        public static bool AmneTurnNeutAssassin => Generate.AmneTurnNeutAssassin.Get();
        public static bool TraitorCanAssassin => Generate.TraitorCanAssassin.Get();
        public static bool AssassinMultiKill => Generate.AssassinMultiKill.Get();
        public static float UnderdogKillBonus => Generate.UnderdogKillBonus.Get();
        public static bool UnderdogIncreasedKC => Generate.UnderdogIncreasedKC.Get();
        public static int PhantomTasksRemaining => (int)Generate.PhantomTasksRemaining.Get();
        public static bool PhantomSpook => Generate.PhantomSpook.Get();
        public static bool VigilanteGuessNeutralBenign => Generate.VigilanteGuessNeutralBenign.Get();
        public static bool VigilanteGuessNeutralEvil => Generate.VigilanteGuessNeutralEvil.Get();
        public static bool VigilanteGuessNeutralKilling => Generate.VigilanteGuessNeutralKilling.Get();
        public static bool VigilanteGuessModifiers => Generate.VigilanteGuessModifiers.Get();
        public static bool VigilanteGuessLovers => Generate.VigilanteGuessLovers.Get();
        public static int VigilanteKills => (int)Generate.VigilanteKills.Get();
        public static bool VigilanteMultiKill => Generate.VigilanteMultiKill.Get();
        public static float CampaignCd => Generate.CampaignCooldown.Get();
        public static int HaunterTasksRemainingClicked => (int)Generate.HaunterTasksRemainingClicked.Get();
        public static int HaunterTasksRemainingAlert => (int)Generate.HaunterTasksRemainingAlert.Get();
        public static bool HaunterRevealsNeutrals => Generate.HaunterRevealsNeutrals.Get();
        public static HaunterCanBeClickedBy HaunterCanBeClickedBy => (HaunterCanBeClickedBy)Generate.HaunterCanBeClickedBy.Get();
        public static float GrenadeCd => Generate.GrenadeCooldown.Get();
        public static float GrenadeDuration => Generate.GrenadeDuration.Get();
        public static bool GrenadierIndicators => Generate.GrenadierIndicators.Get();
        public static bool GrenadierVent => Generate.GrenadierVent.Get();
        public static float FlashRadius => Generate.FlashRadius.Get();
        public static int LovingImpPercent => (int)Generate.LovingImpPercent.Get();
        public static bool KilledOnAlert => Generate.KilledOnAlert.Get();
        public static float AlertCd => Generate.AlertCooldown.Get();
        public static float AlertDuration => Generate.AlertDuration.Get();
        public static int MaxAlerts => (int)Generate.MaxAlerts.Get();
        public static float UpdateInterval => Generate.UpdateInterval.Get();
        public static float TrackCd => Generate.TrackCooldown.Get();
        public static bool ResetOnNewRound => Generate.ResetOnNewRound.Get();
        public static int MaxTracks => (int)Generate.MaxTracks.Get();
        public static int LatestSpawn => (int)Generate.LatestSpawn.Get();
        public static bool NeutralKillingStopsTraitor => Generate.NeutralKillingStopsTraitor.Get();
        public static float TransportCooldown => Generate.TransportCooldown.Get();
        public static int TransportMaxUses => (int)Generate.TransportMaxUses.Get();
        public static bool TransporterVitals => Generate.TransporterVitals.Get();
        public static bool SpyVitals => Generate.SpyVitals.Get();
        public static bool RememberArrows => Generate.RememberArrows.Get();
        public static float RememberArrowDelay => Generate.RememberArrowDelay.Get();
        public static float MediateCooldown => Generate.MediateCooldown.Get();
        public static bool ShowMediatePlayer => Generate.ShowMediatePlayer.Get();
        public static bool ShowMediumToDead => Generate.ShowMediumToDead.Get();
        public static DeadRevealed DeadRevealed => (DeadRevealed)Generate.DeadRevealed.Get();
        public static float VestCd => Generate.VestCd.Get();
        public static float VestDuration => Generate.VestDuration.Get();
        public static float VestKCReset => Generate.VestKCReset.Get();
        public static int MaxVests => (int)Generate.MaxVests.Get();
        public static float ProtectCd => Generate.ProtectCd.Get();
        public static float ProtectDuration => Generate.ProtectDuration.Get();
        public static float ProtectKCReset => Generate.ProtectKCReset.Get();
        public static int MaxProtects => (int)Generate.MaxProtects.Get();
        public static ProtectOptions ShowProtect => (ProtectOptions)Generate.ShowProtect.Get();
        public static BecomeOptions GaOnTargetDeath => (BecomeOptions)Generate.GaOnTargetDeath.Get();
        public static bool GATargetKnows => Generate.GATargetKnows.Get();
        public static bool GAKnowsTargetRole => Generate.GAKnowsTargetRole.Get();
        public static int EvilTargetPercent => (int)Generate.EvilTargetPercent.Get();
        public static float MysticArrowDuration => Generate.MysticArrowDuration.Get();
        public static bool MysticSleuthAbility => Generate.MysticSleuthAbility.Get();
        public static float BlackmailCd => Generate.BlackmailCooldown.Get();
        public static bool BlackmailInvisible => Generate.BlackmailInvisible.Get();
        public static int LatestNonVote => (int)Generate.LatestNonVote.Get();
        public static float GiantSlow => Generate.GiantSlow.Get();
        public static float FlashSpeed => Generate.FlashSpeed.Get();
        public static float DiseasedMultiplier => Generate.DiseasedKillMultiplier.Get();
        public static float BaitMinDelay => Generate.BaitMinDelay.Get();
        public static float BaitMaxDelay => Generate.BaitMaxDelay.Get();
        public static float InfectCd => Generate.InfectCooldown.Get();
        public static float PestKillCd => Generate.PestKillCooldown.Get();
        public static bool PestVent => Generate.PestVent.Get();
        public static float RampageCd => Generate.RampageCooldown.Get();
        public static float RampageDuration => Generate.RampageDuration.Get();
        public static float RampageKillCd => Generate.RampageKillCooldown.Get();
        public static bool WerewolfVent => Generate.WerewolfVent.Get();
        public static int VultureKillCooldown => (int) Generate.VultureKillCooldown.Get();
        public static bool VultureRememberArrows => Generate.VultureRememberArrows.Get();
        public static int VultureRememberArrowDelay => (int) Generate.VultureRememberArrowDelay.Get();
        public static int VultureEatCount => (int) Generate.VultureEatCount.Get();
        public static float TrapCooldown => Generate.TrapCooldown.Get();
        public static bool TrapsRemoveOnNewRound => Generate.TrapsRemoveOnNewRound.Get();
        public static int MaxTraps => (int)Generate.MaxTraps.Get();
        public static float MinAmountOfTimeInTrap => Generate.MinAmountOfTimeInTrap.Get();
        public static float TrapSize => Generate.TrapSize.Get();
        public static int MinAmountOfPlayersInTrap => (int) Generate.MinAmountOfPlayersInTrap.Get();
        public static float ExamineCd => Generate.ExamineCooldown.Get();
        public static bool DetectiveReportOn => Generate.DetectiveReportOn.Get();
        public static float DetectiveRoleDuration => Generate.DetectiveRoleDuration.Get();
        public static float DetectiveFactionDuration => Generate.DetectiveFactionDuration.Get();
        public static float EscapeCd => Generate.EscapeCooldown.Get();
        public static bool EscapistVent => Generate.EscapistVent.Get();
        public static bool ImitatorCanBecomeMayor => Generate.ImitatorCanBecomeMayor.Get();

        public static bool ImitateAllCrewmates => Generate.ImitateAllCrewmates.Get();
        public static float DetonateDelay => Generate.DetonateDelay.Get();
        public static int MaxKillsInDetonation => (int) Generate.MaxKillsInDetonation.Get();
        public static float DetonateRadius => Generate.DetonateRadius.Get();
        public static bool BomberVent => Generate.BomberVent.Get();
        public static bool AllImpsSeeBomb => Generate.AllImpsSeeBomb.Get();
        public static float ObserveCooldown => Generate.ObserveCooldown.Get();
        public static bool DoomsayerGuessNeutralBenign => Generate.DoomsayerGuessNeutralBenign.Get();
        public static bool DoomsayerGuessNeutralEvil => Generate.DoomsayerGuessNeutralEvil.Get();
        public static bool DoomsayerGuessNeutralKilling => Generate.DoomsayerGuessNeutralKilling.Get();
        public static bool DoomsayerGuessImpostors => Generate.DoomsayerGuessImpostors.Get();
        public static int DoomsayerKillNeedToVictory => (int) Generate.DoomsayerKillNeedToVictory.Get();

        public static int DoomsayerObserveRoleCount => (int) Generate.DoomsayerObserveRoleCount.Get();
        public static float BiteCd => Generate.BiteCooldown.Get();
        public static bool VampImpVision => Generate.VampImpVision.Get();
        public static bool VampVent => Generate.VampVent.Get();
        public static bool NewVampCanAssassin => Generate.NewVampCanAssassin.Get();
        public static int MaxVampiresPerGame => (int)Generate.MaxVampiresPerGame.Get();
        public static bool CanBiteNeutralBenign => Generate.CanBiteNeutralBenign.Get();
        public static bool CanBiteNeutralEvil => Generate.CanBiteNeutralEvil.Get();
        public static bool ProsDiesOnIncorrectPros => Generate.ProsDiesOnIncorrectPros.Get();
        public static float ChargeUpDuration => Generate.ChargeUpDuration.Get();
        public static float ChargeUseDuration => Generate.ChargeUseDuration.Get();
        public static float ConfessCd => Generate.ConfessCooldown.Get();
        public static float RevealAccuracy => Generate.RevealAccuracy.Get();
        public static bool NeutralBenignShowsEvil => Generate.NeutralBenignShowsEvil.Get();
        public static bool NeutralEvilShowsEvil => Generate.NeutralEvilShowsEvil.Get();
        public static bool NeutralKillingShowsEvil => Generate.NeutralKillingShowsEvil.Get();
        public static float AbilityCd => Generate.AbilityCooldown.Get();
        public static float AbilityDuration => Generate.AbilityDuration.Get();
        public static float SprintSpeed => Generate.SprintSpeed.Get();
        public static float FreezeSpeed => Generate.FreezeSpeed.Get();
        public static float ChillDuration => Generate.ChillDuration.Get();
        public static float ChillStartSpeed => Generate.ChillStartSpeed.Get();
        public static float AuraInnerRadius => (float)Generate.AuraInnerRadius.Get();
        public static float AuraOuterRadius => (float)Generate.AuraOuterRadius.Get();
        public static float SenseDuration => (float)Generate.SenseDuration.Get();
        public static AdminDeadPlayers WhoSeesDead => (AdminDeadPlayers)Generate.WhoSeesDead.Get();
        public static bool SpyAdminAnywhere => Generate.SpyAdminAnywhere.Get();
        public static float SpyAdminTableCd => (float)Generate.SpyAdminTableCd.Get();
        public static bool VentImprovements => Generate.VentImprovements.Get();
        public static bool VitalsLab => Generate.VitalsLab.Get();
        public static bool ColdTempDeathValley => Generate.ColdTempDeathValley.Get();
        public static bool WifiChartCourseSwap => Generate.WifiChartCourseSwap.Get();
        public static bool RandomMapEnabled => Generate.RandomMapEnabled.Get();
        public static float RandomMapSkeld => Generate.RandomMapSkeld.Get();
        public static float RandomMapMira => Generate.RandomMapMira.Get();
        public static float RandomMapPolus => Generate.RandomMapPolus.Get();
        public static float RandomMapAirship => Generate.RandomMapAirship.Get();
        public static float RandomMapFungle => Generate.RandomMapFungle.Get();
        public static float RandomMapSubmerged => Patches.SubmergedCompatibility.Loaded ? Generate.RandomMapSubmerged.Get() : 0f;
        public static float RandomMapLevelImpostor => RandomMap.LevelImpLoaded ? Generate.RandomMapLevelImpostor.Get() : 0f;
        public static bool SmallMapHalfVision => Generate.SmallMapHalfVision.Get();
        public static float SmallMapDecreasedCooldown => Generate.SmallMapDecreasedCooldown.Get();
        public static float LargeMapIncreasedCooldown => Generate.LargeMapIncreasedCooldown.Get();
        public static int SmallMapIncreasedShortTasks => (int)Generate.SmallMapIncreasedShortTasks.Get();
        public static int SmallMapIncreasedLongTasks => (int)Generate.SmallMapIncreasedLongTasks.Get();
        public static int LargeMapDecreasedShortTasks => (int)Generate.LargeMapDecreasedShortTasks.Get();
        public static int LargeMapDecreasedLongTasks => (int)Generate.LargeMapDecreasedLongTasks.Get();
        public static DisableSkipButtonMeetings SkipButtonDisable => (DisableSkipButtonMeetings)Generate.SkipButtonDisable.Get();
        public static bool UniqueRoles => Generate.UniqueRoles.Get();
        public static RoleOptions Slot1 => (RoleOptions)Generate.Slot1.Get();
        public static RoleOptions Slot2 => (RoleOptions)Generate.Slot2.Get();
        public static RoleOptions Slot3 => (RoleOptions)Generate.Slot3.Get();
        public static RoleOptions Slot4 => (RoleOptions)Generate.Slot4.Get();
        public static RoleOptions Slot5 => (RoleOptions)Generate.Slot5.Get();
        public static RoleOptions Slot6 => (RoleOptions)Generate.Slot6.Get();
        public static RoleOptions Slot7 => (RoleOptions)Generate.Slot7.Get();
        public static RoleOptions Slot8 => (RoleOptions)Generate.Slot8.Get();
        public static RoleOptions Slot9 => (RoleOptions)Generate.Slot9.Get();
        public static RoleOptions Slot10 => (RoleOptions)Generate.Slot10.Get();
        public static RoleOptions Slot11 => (RoleOptions)Generate.Slot11.Get();
        public static RoleOptions Slot12 => (RoleOptions)Generate.Slot12.Get();
        public static RoleOptions Slot13 => (RoleOptions)Generate.Slot13.Get();
        public static RoleOptions Slot14 => (RoleOptions)Generate.Slot14.Get();
        public static RoleOptions Slot15 => (RoleOptions)Generate.Slot15.Get();
        public static bool CamoCommsKillAnyone => Generate.CamoCommsKillAnyone.Get();
        public static bool CrewKillersContinue => Generate.CrewKillersContinue.Get();
        public static bool VultureJanitorInSameGame => Generate.VultureJanitorInSameGame.Get();
        public static float HunterKillCd => Generate.HunterKillCd.Get();
        public static float HunterStalkCd => Generate.HunterStalkCd.Get();
        public static float HunterStalkDuration => Generate.HunterStalkDuration.Get();
        public static int HunterStalkUses => (int)Generate.HunterStalkUses.Get();
        public static bool RetributionOnVote => Generate.RetributionOnVote.Get();
        public static bool HunterBodyReport => Generate.HunterBodyReport.Get();
        public static bool DoomsayerCantObserve => Generate.DoomsayerCantObserve.Get();
        public static float HypnotiseCd => Generate.HypnotiseCooldown.Get();
        public static float WraithCd => Generate.WraithCooldown.Get();
        public static float WraithDuration => Generate.WraithDuration.Get();
        public static bool WraithVent => Generate.WraithVent.Get();
        public static float WraithKillCd => Generate.WraithKillCd.Get();
        public static float JailCd => Generate.JailCooldown.Get();
        public static int MaxExecutes => (int)Generate.MaxExecutes.Get();
        public static float ReapCd => Generate.ReapCooldown.Get();
        public static bool PassiveSoulCollection => Generate.PassiveSoulCollection.Get();
        public static int SoulsToWin => (int)Generate.SoulsToWin.Get();
        public static float InvisDelay => Generate.InvisDelay.Get();
        public static float TransformInvisDuration => Generate.TransformInvisDuration.Get();
        public static float FinalTransparency => Generate.FinalTransparency.Get();
        public static float WatchCooldown => (float)Generate.WatchCooldown.Get();
        public static bool LoResetOnNewRound => Generate.LoResetOnNewRound.Get();
        public static int MaxWatches => (int)Generate.MaxWatches.Get();
        public static float ScavengeDuration => (float)Generate.ScavengeDuration.Get();
        public static float ScavengeIncreaseDuration => (float)Generate.ScavengeIncreaseDuration.Get();
        public static float ScavengeCorrectKillCooldown => (float)Generate.ScavengeCorrectKillCooldown.Get();
        public static float ScavengeIncorrectKillCooldown => (float)Generate.ScavengeIncorrectKillCooldown.Get();
        public static float ReducedSaboCd => Generate.ReducedSaboCooldown.Get();

        public static int DrunkDuration => 10;
    }
}