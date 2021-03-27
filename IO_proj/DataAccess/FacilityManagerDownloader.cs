using ProductionManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManagementSystem.DataAccess
{
    public class FacilityManagerDownloader : DataDownloader
    {
        public string Message = "Nie dodano użytkownika";
        public Prize NewPrize = null;
        public FacilityManagerDownloader()
        {
            DepartmentsList = new List<Department>();
            DepManagersList = new List<DepartmentManager>();
        }
        override public void DownloadData(Employee signedInUser)
        {

            List<Department> tmpList = new List<Department>();

            tmpList = DBManager.Instance.GetAllDepartmets();
            DepartmentsList = tmpList;
            for (int i = 0; i < tmpList.Count; i++)
            {
                DepartmentManager departmentManager = new DepartmentManager();

                departmentManager.Department = DBManager.Instance.GetDepartmentById(tmpList[i].DepartmentId);

                departmentManager.EmployeesList = DBManager.Instance.GetEmployeesList(tmpList[i].DepartmentId);

                for (int j = 0; j < departmentManager.EmployeesList.Count; j++)
                {
                    departmentManager.EmployeesList[j].SetFormList(DBManager.Instance.GetEmployeeForm(departmentManager.EmployeesList[j].UserId));
                }
                DepManagersList.Add(departmentManager);
            }
            for (int i = 0; i < DepManagersList.Count; i++)
            {
                DepManagersList[i].SetManagerTableList();
            }

            PrizeList = new List<Prize>(DBManager.Instance.GetPrizesList(signedInUser.UserId));

            UserTypes = GetUserTypes();


        }

        override public void UpdateData(List<string> arguments)
        {
            if(Employee != null)
                if (DBManager.Instance.InsertEmployee(Employee) == 0) Message = "Dodano pracownika";
                else Message = "Nie dodano użytkownika";


            if(NewPrize != null)
                if (DBManager.Instance.InsertPrize(NewPrize) == 0) Message = "Dodano nagrode";
                else Message = "Nie dodano";

        }

        public void SetNewEmployee(Employee newEmployee)
        {
            Employee = newEmployee;
        }

        public List<Department> GetDepartments()
        {
            return DepartmentsList;
        }

        public List<UserType> GetUserTypes()
        {
            List<UserType> userTypes = new List<UserType>
            {
                new UserType{ TypeId = 1, TypeName = "administrator" },
                new UserType{ TypeId = 2, TypeName = "manager" },
                new UserType{ TypeId = 3, TypeName = "pracownik" },
            };

            return userTypes;
        }

        override public int[] GetDepartmentStats(int depId)
        {
            int[] stats = new int[4];
            //int depId = BaseController.Instance.Downloader.DepManagersList[0].Department.DepartmentId;

            var stat = DBManager.Instance.GetDepartmentStatistics(depId, "day");
            stats[0] = stat;
            stat = DBManager.Instance.GetDepartmentStatistics(depId, "month");
            stats[1] = stat;
            stat = DBManager.Instance.GetDepartmentStatistics(depId, "year");
            stats[2] = stat;
            stat = DBManager.Instance.GetDepartmentStatistics(depId, "total");
            stats[3] = stat;

            return stats;
        }
    }
}
