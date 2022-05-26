using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    internal class TimeLog
    {
        public Guid Id { get; set; }
        public int AmountInMins { get; set; }
        public DateTime LoggedOn { get; set; }
        public StaffMember MemberOfTeam { get; set; }

        public TimeLog(int amountInMins, StaffMember memberOfTeam)
        {
            Id = Guid.NewGuid();
            AmountInMins = amountInMins;
            LoggedOn = DateTime.Now;
            MemberOfTeam = memberOfTeam;
        }
    }
}
