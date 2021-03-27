using System;
using System.Collections.Generic;
using System.Text;
using ProductionManagementSystem.Models;
using ProductionManagementSystem.DataAccess;

namespace ProductionManagementSystem.Controllers
{
    
    public class EmployeeController : BaseController
    {
        public EmployeeController(Employee employee) : base() 
        {
            CurrentEmployee = employee;
            Downloader = new EmployeeDownloader();
            Instance = this;
            Downloader.DownloadData(employee);
            CurrentUserForm.AddEmployeeTabs();
            CurrentUserForm.Show();
        }

        public void UpdateTableView(List<string> arguments)
        {
            Downloader.UpdateData(arguments);
            Downloader.DownloadData(CurrentEmployee);
        }

        public int CalculatePrizePoints(double staticNorm, double employeeNorm)
        {
            double calculatedPrizePoints;

            calculatedPrizePoints = (employeeNorm / staticNorm) * 10;

            int returned = Convert.ToInt32(calculatedPrizePoints);

            return returned;
        }

    }
}
