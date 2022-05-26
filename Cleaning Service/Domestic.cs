using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cleaning_Service.Enums;

namespace Cleaning_Service
{
    public class Domestic : IFProperty
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public DomesticType Type { get; set; }
        public int Rooms { get; set; }
        public Customer CurrentCustomer { get; set; }
        public List<IFCleaning> Cleaning { get; set; }

        public Domestic(string address, DomesticType type, int rooms, Customer customer)
        {
            Id = Guid.NewGuid();
            Address = address;
            Type = type;
            Rooms = rooms;
            CurrentCustomer = customer;
            Cleaning = new List<IFCleaning>();
        }

        public override string? ToString()
        {
            return $"Address: {Address} Type: {Type} Number Of Rooms: {Rooms}";
        }
    }
}
