using ProductionManagementSystem.Controllers;
using ProductionManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProductionManagementSystem.DataAccess
{
    public class EmployeeDownloader : DataDownloader
    {

        override public void DownloadData(Employee signedInUser)
        {
            DepartmentsList = null;
            DepManagersList = null;
            
            BaseController.Instance.CurrentEmployee.formList = DBManager.Instance.GetEmployeeForm(signedInUser.UserId);
            PrizeList = new List<Prize>(DBManager.Instance.GetPrizesList(signedInUser.UserId));
            TakenPrizeList = new List<TakenPrize>(DBManager.Instance.GetTakenPrizesList(signedInUser.UserId));

            CurrentUserPrizePoints = GetCurrentUserPoints();
            CurrentDepartmentName = GetCurrentDepartmentName();
        }
        override public void UpdateData(List<string> arguments)
        {

            if (arguments.Count == 2)
            {
                DateTime tmpDate = DateTime.Parse(arguments[0]);
                int amount = int.Parse(arguments[1]);

                Department tmp = DBManager.Instance.GetDepartmentById(BaseController.Instance.CurrentEmployee.DepartmentId);
                int norm = tmp.MinimalAmount;

                int calculatedPrizePoints = (BaseController.Instance as EmployeeController).CalculatePrizePoints(Convert.ToDouble(norm), Convert.ToDouble(amount));

                DBManager.Instance.InsertEmployeeForm(tmpDate, amount, norm, calculatedPrizePoints);
            }


                if (arguments.Count == 3)
            {
                TakenPrize taken = new TakenPrize();

                taken.UserId = int.Parse(arguments[0]);
                taken.PrizeId = int.Parse(arguments[1]);
                taken.PrizeCost = int.Parse(arguments[2]);

                DBManager.Instance.InsertTakenPrize(taken);
            }

            if (arguments.Count == 5)
            {
                DateTime tmpDate = DateTime.Parse(arguments[0]);
                int amount = int.Parse(arguments[1]);

                Department tmp = DBManager.Instance.GetDepartmentById(BaseController.Instance.CurrentEmployee.DepartmentId);
                int norm = tmp.MinimalAmount;

                int calculatedPrizePoints = (BaseController.Instance as EmployeeController).CalculatePrizePoints(Convert.ToDouble(norm), Convert.ToDouble(amount));

                DBManager.Instance.InsertEmployeeForm(tmpDate, amount, norm, calculatedPrizePoints);


                TakenPrize taken = new TakenPrize();

                taken.UserId = int.Parse(arguments[2]);
                taken.PrizeId = int.Parse(arguments[3]);
                taken.PrizeCost = int.Parse(arguments[4]);

                DBManager.Instance.InsertTakenPrize(taken);
            }
        }
        
        public string GetCurrentDepartmentName()
        {
            var department = DBManager.Instance.GetDepartmentById(BaseController.Instance.CurrentEmployee.DepartmentId);
            return department.DepartmentName;
        }

        public int GetCurrentUserPoints()
        {
            return DBManager.Instance.SumThePrizePoints(BaseController.Instance.CurrentEmployee.UserId);
        }

    }
}
