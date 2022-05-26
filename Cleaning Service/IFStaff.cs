using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cleaning_Service.Enums;

namespace Cleaning_Service
{
    internal interface IFStaff
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public StaffType Type { get; set; }
    }
}
