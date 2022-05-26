﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    internal class Purchase
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public double Cost { get; set; }
        public DateTime CreatedOn { get; set; }
        public StaffMember? CreatedBy { get; set; }

        public Purchase(string? description, double cost, StaffMember? createdBy)
        {
            Id = Guid.NewGuid();
            Description = description;
            Cost = cost;
            CreatedOn = DateTime.Now;
            CreatedBy = createdBy;
        }
    }
}