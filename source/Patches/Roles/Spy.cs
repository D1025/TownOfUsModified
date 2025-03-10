using System;
using System.Linq;
using TownOfUs.Extensions;

namespace TownOfUs.Roles
{
    public class Spy : Role
    {
        public DateTime LastCheckAdmin { get; set; }

        public Spy(PlayerControl player) : base(player)
        {
            Name = "Spy";
            ImpostorText = () => "Snoop Around And Find Stuff Out";
            TaskText = () => "Gain extra information on the Admin Table";
            Color = Patches.Colors.Spy;
            RoleType = RoleEnum.Spy;
            AddToRoleHistory(RoleType);
        }

        public float SpyTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastCheckAdmin;
            var num = CustomGameOptions.SpyAdminTableCd * 1000f;
            var flag2 = num - (float)timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float)timeSpan.TotalMilliseconds) / 1000f;
        }
    }
}