using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cleaning_Service.Enums;

namespace Cleaning_Service
{
    public class MajorCleaning : IFCleaning
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public CleaningSeverity Severity { get; set; }
        public bool Open { get; set; }
        public List<Purchase> PurchaseList { get; set; }

        public MajorCleaning(string description, CleaningSeverity severity)
        {
            Id = Guid.NewGuid();
            Description = description;
            Date = DateTime.Now;
            Severity = severity;
            Open = true;
            PurchaseList = new List<Purchase>();
        }

        public override string? ToString()
        {
            return $"Description: {Description} Priority: {Severity} Created On: {Date}";
        }
    }
}
