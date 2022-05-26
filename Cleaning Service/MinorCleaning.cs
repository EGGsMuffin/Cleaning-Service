using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    internal class MinorCleaning : IFCleaning
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Open { get; set; }

        public MinorCleaning(Guid id, string description, DateTime date, bool open)
        {
            Id = Guid.NewGuid();
            Description = description;
            Date = date;
            Open = open;
        }
    }
}
