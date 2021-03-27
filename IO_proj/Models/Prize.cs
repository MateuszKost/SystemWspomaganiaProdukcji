using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManagementSystem.Models
{
    public class Prize
    {
        public int PrizeId { get; set; }
        public string PrizeName { get; set; }
        public int RequiredPoints { get; set; }
    }
}