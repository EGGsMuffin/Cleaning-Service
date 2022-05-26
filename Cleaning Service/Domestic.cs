using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cleaning_Service.Enums;

namespace Cleaning_Service
{
    internal class Domestic : IFProperty
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public DomesticType Type { get; set; }
        public int NumberOfBedrooms { get; set; }
        public Customer CurrentCustomer { get; set; }
        public List<IFCleaning> Cleaning { get; set; }

        public Domestic(string address, DomesticType type, int numberOfBedrooms, Customer customer)
        {
            Id = Guid.NewGuid();
            Address = address;
            Type = type;
            NumberOfBedrooms = numberOfBedrooms;
            CurrentCustomer = customer;
        }
    }
}
