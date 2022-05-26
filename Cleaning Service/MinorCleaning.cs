using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cleaning_Service.Enums;

namespace Cleaning_Service
{
    public class MinorCleaning : IFCleaning
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        public MinorCleaning(string description)
        {
            Id = Guid.NewGuid();
            Description = description;
        }

        public override string? ToString()
        {
            return $"Description: {Description}";
        }
    }
}
