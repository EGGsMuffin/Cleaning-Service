using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cleaning_Service.Enums;

namespace Cleaning_Service
{
    internal class StaffMember : IFPerson, IFStaff
    {
        public Guid Id { get; set; }
        public string Fname { get; set; }
        public string Sname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public StaffType Type { get; set; }

        public StaffMember(string fname, string sname, string email, string phoneNumber, string username, string password, StaffType type)
        {
            Id = Guid.NewGuid();
            Fname = fname;
            Sname = sname;
            Email = email;
            PhoneNumber = phoneNumber;
            Username = username;
            Password = password;
            Type = StaffType.TEAM_MEMBER;
        }
    }
}
