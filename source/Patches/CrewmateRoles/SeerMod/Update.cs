using HarmonyLib;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using TownOfUs.Roles.Modifiers;
using UnityEngine;

namespace TownOfUs.CrewmateRoles.SeerMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class Update
    {
        private static void UpdateMeeting(MeetingHud __instance, Seer seer)
        {
            foreach (var player in PlayerControl.AllPlayerControls)
            {
                if (!seer.Investigated.Contains(player.PlayerId)) continue;
                foreach (var state in __instance.playerStates)
                {
                    if (player.PlayerId != state.TargetPlayerId) continue;
                    var roleType = Utils.GetRole(player);
                    Color colour;
                    switch (roleType)
                    {
                        default:
                            if ((player.Is(Faction.Crewmates) && !(player.Is(RoleEnum.Sheriff) || player.Is(RoleEnum.Veteran) ||
                                player.Is(RoleEnum.Vigilante) || player.Is(RoleEnum.Hunter) || player.Is(RoleEnum.Jailor))) ||
                                ((player.Is(RoleEnum.Sheriff) || player.Is(RoleEnum.Veteran) || player.Is(RoleEnum.Vigilante) ||
                                player.Is(RoleEnum.Hunter) || player.Is(RoleEnum.Jailor)) && !CustomGameOptions.CrewKillingRed) ||
                                (player.Is(Faction.NeutralBenign) && !CustomGameOptions.NeutBenignRed) ||
                                (player.Is(Faction.NeutralEvil) && !CustomGameOptions.NeutEvilRed) ||
                                (player.Is(Faction.NeutralKilling) && !CustomGameOptions.NeutKillingRed))
                            {
                                colour = Color.green;
                            }
                            else if (player.Is(RoleEnum.Traitor) && CustomGameOptions.TraitorColourSwap)
                            {
                                colour = Color.red;
                                foreach (var role in Role.GetRoles(RoleEnum.Traitor))
                                {
                                    var traitor = (Traitor)role;
                                    if ((traitor.formerRole == RoleEnum.Sheriff || traitor.formerRole == RoleEnum.Vigilante ||
                                         traitor.formerRole == RoleEnum.Veteran || traitor.formerRole == RoleEnum.Hunter ||
                                         traitor.formerRole == RoleEnum.Jailor) && CustomGameOptions.CrewKillingRed)
                                    {
                                        colour = Color.red;
                                    }
                                    else
                                    {
                                        colour = Color.green;
                                    }
                                }
                            }
                            else
                            {
                                colour = Color.red;
                            }
                            break;
                    }
                    if (player.Is(ModifierEnum.Error))
                    {
                        if (colour == Color.red)
                            colour = Color.green;
                        else if (colour == Color.green)
                            colour = Color.red;
                        else
                            colour = Color.red;
                    }
                    state.NameText.color = colour;
                }
            }
        }

        [HarmonyPriority(Priority.Last)]
        private static void Postfix(HudManager __instance)

        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (PlayerControl.LocalPlayer.Data.IsDead) return;

            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Seer)) return;
            var seer = Role.GetRole<Seer>(PlayerControl.LocalPlayer);
            if (MeetingHud.Instance != null) UpdateMeeting(MeetingHud.Instance, seer);

            if (!PlayerControl.LocalPlayer.IsHypnotised())
            {
                foreach (var player in PlayerControl.AllPlayerControls)
                {
                    if (!seer.Investigated.Contains(player.PlayerId)) continue;
                    var roleType = Utils.GetRole(player);
                    switch (roleType)
                    {
                        default:
                            var colour = Color.red;
                            if ((player.Is(Faction.Crewmates) && !(player.Is(RoleEnum.Sheriff) || player.Is(RoleEnum.Veteran) || player.Is(RoleEnum.Vigilante) || player.Is(RoleEnum.Hunter) || player.Is(RoleEnum.Jailor))) ||
                                ((player.Is(RoleEnum.Sheriff) || player.Is(RoleEnum.Veteran) || player.Is(RoleEnum.Vigilante) || player.Is(RoleEnum.Hunter) || player.Is(RoleEnum.Jailor)) && !CustomGameOptions.CrewKillingRed) ||
                                (player.Is(Faction.NeutralBenign) && !CustomGameOptions.NeutBenignRed) ||
                                (player.Is(Faction.NeutralEvil) && !CustomGameOptions.NeutEvilRed) ||
                                (player.Is(Faction.NeutralKilling) && !CustomGameOptions.NeutKillingRed))
                            {
                                    colour = Color.green;
                            }
                            else if (player.Is(RoleEnum.Traitor) && CustomGameOptions.TraitorColourSwap)
                            {
                                foreach (var role in Role.GetRoles(RoleEnum.Traitor))
                                {
                                    var traitor = (Traitor)role;
                                    if ((traitor.formerRole == RoleEnum.Sheriff || traitor.formerRole == RoleEnum.Vigilante ||
                                        traitor.formerRole == RoleEnum.Veteran || traitor.formerRole == RoleEnum.Hunter ||
                                        traitor.formerRole == RoleEnum.Jailor) && CustomGameOptions.CrewKillingRed) colour = Color.red;
                                    else colour = Color.green;
                                }
                            }

                            if (player.Is(ModifierEnum.Shy)) colour.a = Modifier.GetModifier<Shy>(player).Opacity;
                            if (player.Is(ModifierEnum.Error))
                            {
                                switch (colour)
                                {
                                    case Color c when c == Color.red:
                                        colour = Color.green;
                                        break;
                                    case Color c when c == Color.green:
                                        colour = Color.red;
                                        break;
                                    default:
                                        colour = Color.red;
                                        break;
                                }
                            }
                            player.nameText().color = colour;
                            break;
                    }
                }
            }
        }
    }
}