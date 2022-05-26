﻿using System;
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
        public List<Purchase> PurchaseList { get; set; }

        public MinorCleaning(string description)
        {
            Id = Guid.NewGuid();
            Description = description;
            Date = DateTime.Now;
            Open = true;
            PurchaseList = new List<Purchase>();
        }
    }
}
