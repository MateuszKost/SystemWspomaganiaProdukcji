using ProductionManagementSystem.Controllers;
using ProductionManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManagementSystem.DataAccess
{
    public class DepartmentManagerDownloader : DataDownloader
    {

        public DepartmentManagerDownloader()
        {
            DepartmentsList = new List<Department>();
            DepManagersList = new List<DepartmentManager>();
        }
        override public void DownloadData(Employee signedInUser)
        {

            DepartmentsList = DBManager.Instance.GetAllDepartmets();

            DepartmentManager departmentManager = new DepartmentManager();

            departmentManager.Department = DBManager.Instance.GetDepartmentById(signedInUser.DepartmentId);

            departmentManager.EmployeesList = DBManager.Instance.GetEmployeesList(signedInUser.DepartmentId);

            for (int i = 0; i < departmentManager.EmployeesList.Count; i++)
            {
                departmentManager.EmployeesList[i].SetFormList(DBManager.Instance.GetEmployeeForm(departmentManager.EmployeesList[i].UserId));
            }

            DepManagersList.Insert(0, departmentManager);

            DepManagersList[0].SetManagerTableList();

            CurrentDepartmentName = departmentManager.Department.DepartmentName;

            stats = GetDepartmentStats(signedInUser.DepartmentId);

        }
        override public void UpdateData(List<string> arguments)
        {

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
