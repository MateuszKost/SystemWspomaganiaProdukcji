using ProductionManagementSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManagementSystem.Models
{
    public class DepartmentManager
    {
        public Department Department { get; set; }

        public List<Employee> EmployeesList { get; set; }

        public List<ManagerTable> ManagerTableList { get; set; }

        public DepartmentManager()
        {

            EmployeesList = new List<Employee>();

            ManagerTableList = new List<ManagerTable>();
       
        }

        public void SetManagerTableList()
        {
            if (ManagerTableList == null)
                ManagerTableList = new List<ManagerTable>();
            else
                ManagerTableList.Clear();
            
            for (int i=0; i< EmployeesList.Count;i++)
                for (int j=0;j< EmployeesList[i].formList.Count;j++)
                {
                    ManagerTable tmp = new ManagerTable();

                    tmp.Date = EmployeesList[i].formList[j].Date;
                    tmp.LastName = EmployeesList[i].LastName;
                    tmp.Name = EmployeesList[i].Name;
                    tmp.Parts = EmployeesList[i].formList[j].Amount;

                    ManagerTableList.Add(tmp);
                }
        }
    }
}
