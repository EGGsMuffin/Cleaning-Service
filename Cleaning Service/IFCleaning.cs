using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    public interface IFCleaning
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
