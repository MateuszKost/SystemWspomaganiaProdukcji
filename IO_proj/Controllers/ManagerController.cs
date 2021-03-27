using System;
using System.Collections.Generic;
using System.Text;
using ProductionManagementSystem.Models;
using ProductionManagementSystem.DataAccess;
using System.Windows.Forms;

namespace ProductionManagementSystem.Controllers
{
    public class ManagerController : BaseController
    { 
        public ManagerController(Employee employee) : base()
        {
            CurrentEmployee = employee;
            Downloader = new DepartmentManagerDownloader();
            Instance = this;
            Downloader.DownloadData(employee);
            CurrentUserForm.AddManagerTabs();
            CurrentUserForm.Show();
        }

        private void setTable(DataGridView dataGridView)
        {
            dataGridView.Enabled = true;
            
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView.DataSource = Downloader.DepManagersList[0].ManagerTableList;

            dataGridView.Columns[0].HeaderText = "IMIĘ";
            dataGridView.Columns[1].HeaderText = "NAZWISKO";
            dataGridView.Columns[2].HeaderText = "ILOŚĆ CZĘŚCI";
            dataGridView.Columns[3].HeaderText = "DATA";
        }

        private void setDepartmentNameLabel(Label departmentName)
        {
            departmentName.Text = Downloader.CurrentDepartmentName.ToString();
        }

        private void setPartsPerMonthLabel(Label partsPerMonth)
        { 
            partsPerMonth.Text = Downloader.stats[1].ToString();
        }

        private void setPartsPerEmployeeLabel(Label partsPerEmployee)
        {
            int partsAmount = Downloader.stats[1];
            int employeesAmount = Downloader.DepManagersList[0].EmployeesList.Count;

            partsPerEmployee.Text = (employeesAmount > 0 ? partsAmount / employeesAmount : 0).ToString();
        }

        private void setTodaysPartsAmountLabel(Label todaysParts)
        {
            todaysParts.Text = Downloader.stats[0].ToString();
        }

        public void setPane(DataGridView dataGridView,Label departmentName,Label partsPerMonth, Label partsPerEmployee, Label todaysParts)
        {
            setTable(dataGridView);
            setDepartmentNameLabel(departmentName);
            setPartsPerMonthLabel(partsPerMonth);
            setPartsPerEmployeeLabel(partsPerEmployee);
            setTodaysPartsAmountLabel(todaysParts);
        }

       

        
    }
}
