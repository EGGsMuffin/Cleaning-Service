using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    internal class MajorCleaning : IFCleaning
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Open { get; set; }

        public MajorCleaning(string description, DateTime date, bool open)
        {
            Id = Guid.NewGuid();
            Description = description;
            Date = DateTime.Now;
            Open = open;
        }
    }
}
