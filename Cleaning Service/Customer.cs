using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    internal class Customer : IFPerson
    {
        public Guid Id { get; set; }
        public string Fname { get; set; }
        public string Sname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(string fname, string sname, string email, string phoneNumber)
        {
            Id = Guid.NewGuid();
            Fname = fname;
            Sname = sname;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
