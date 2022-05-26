using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    public class Enums
    {
        public enum DomesticType
        {
            DETACHED,
            SEMI_DETACHED,
            TERRACED,
            BUNGALOW,
            COTTAGE,
            FLAT
        }
        public enum CommericalType
        {
            OFFICE,
            WAREHOUSE,
            FACTORY,
            INDUSTRIAL_UNIT,
            RETAIL
        }

        public enum CleaningSeverity
        {
            HIGH,
            MEDIUM,
            LOW
        }

        public enum StaffType
        {
            ADMIN,
            MANAGER,
            TEAM_MEMBER
        }
    }
}
