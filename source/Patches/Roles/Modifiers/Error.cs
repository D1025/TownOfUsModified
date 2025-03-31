using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownOfUs.Roles.Modifiers;

namespace TownOfUs.Patches.Roles.Modifiers
{
    public class ErrorMod : Modifier
    {
        public ErrorMod(PlayerControl player) : base(player)
        {
            Name = "Error";
            TaskText = () => "Interactions with you are changed. As impostor you cannot vent.";
            Color = Patches.Colors.Error;
            ModifierType = ModifierEnum.Error;
        }
    }
}
