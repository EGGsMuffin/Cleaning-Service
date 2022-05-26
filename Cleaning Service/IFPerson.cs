using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    internal interface IFPerson
    {
        public Guid Id { get; set; }
        public string Fname { get; set; }
        public string Sname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
