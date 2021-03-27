using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManagementSystem.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string PartName { get; set; }
        public int MinimalAmount { get; set; }

    }
}
