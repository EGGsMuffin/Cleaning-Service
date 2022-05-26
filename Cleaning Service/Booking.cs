using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    public class Booking
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public List<Customer> Customer { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public List<StaffMember> StaffMember { get; set;}
        public List<TimeLog> TimeLog { get; set; }

        public Booking(string address, string description)
        {
            Id = Guid.NewGuid();
            Address = address;
            Customer = new List<Customer>();
            Description = description;
            Created = DateTime.Now;
            StaffMember = new List<StaffMember>();
            TimeLog = new List<TimeLog>();
        }
    }
}
