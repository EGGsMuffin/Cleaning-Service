using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cleaning_Service.Enums;

namespace Cleaning_Service
{
    public class Commercial : IFProperty
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string BusinessName { get; set; }
        public CommericalType Type { get; set; }
        public double SizeInSqFoot { get; set; }
        public Customer CurrentCustomer { get; set; }
        public List<IFCleaning> Cleaning { get; set; }

        public Commercial(string address, string businessName, CommericalType type, double sizeInSqFoot, Customer customer)
        {
            Id = Guid.NewGuid();
            Address = address;
            BusinessName = businessName;
            Type = type;
            SizeInSqFoot = sizeInSqFoot;
            CurrentCustomer = customer;
            Cleaning = new List<IFCleaning>();
        }

        public override string? ToString()
        {
            return $"Address: {Address} Name: {BusinessName} Type: {Type} Size: {SizeInSqFoot}";
        }
    }
}
