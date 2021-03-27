using System;
using System.Collections.Generic;
using System.Text;
using ProductionManagementSystem.Models;
using ProductionManagementSystem.DataAccess;
using System.Windows.Forms;
using System.Linq;

namespace ProductionManagementSystem.Controllers
{
    public class FacilityManagerController : BaseController
    {
        public FacilityManagerController(Employee employee) : base()
        {
            CurrentEmployee = employee;
            Downloader = new FacilityManagerDownloader();
            Instance = this;
            Downloader.DownloadData(employee);
            CurrentUserForm.AddAdminTabs();
            CurrentUserForm.Show();
        }

        private void setDepartmentNameLabel(Label departmentName, String depName)
        {
            departmentName.Text = depName;
        }

        private void setPartsPerMonthLabel(Label partsPerMonth)
        {
            partsPerMonth.Text = Instance.Downloader.stats[1].ToString();
        }

        private void setPartsPerEmployeeLabel(Label partsPerEmployee)
        {
            int partsAmount = Instance.Downloader.stats[1];
            int employeesAmount = Instance.Downloader.DepManagersList[0].EmployeesList.Count;

            partsPerEmployee.Text = (employeesAmount > 0 ? partsAmount / employeesAmount : 0).ToString();
        }

        private void setTodaysPartsAmountLabel(Label todaysParts)
        {
            todaysParts.Text = Instance.Downloader.stats[0].ToString();
        }

        public void showDepartmentsList(DataGridView departmentsListGridView)
        {
            departmentsListGridView.Enabled = true;
            //this.Dock = DockStyle.Fill;
            departmentsListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            departmentsListGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            var departmentsList = BaseController.Instance.Downloader.DepartmentsList;
            departmentsListGridView.DataSource = departmentsList.Select(i => new { Column1 = i.DepartmentName }).ToList();
            departmentsListGridView.Columns[0].HeaderText = "Dział";
        }

        public void departmentExecute(DataGridView departmentsListGridView, DataGridView employeeListGridView, DataGridViewCellEventArgs e, Label departmentName, Label partsPerMonth, Label partsPerEmployee, Label todaysParts)
        {
            if (e.RowIndex != -1 && departmentsListGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                departmentsListGridView.CurrentRow.Selected = true;
                string selectedDepName = departmentsListGridView.CurrentCell.Value.ToString();
                foreach (var dep in BaseController.Instance.Downloader.DepManagersList)
                {
                    if (dep.Department.DepartmentName == selectedDepName)
                    {
                        employeeListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        employeeListGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        employeeListGridView.DataSource = dep.ManagerTableList;

                        employeeListGridView.Columns[0].HeaderText = "Imię";
                        employeeListGridView.Columns[1].HeaderText = "Nazwisko";
                        employeeListGridView.Columns[2].HeaderText = "Części za dzień";
                        employeeListGridView.Columns[3].HeaderText = "Data";

                        Instance.Downloader.stats = Instance.Downloader.GetDepartmentStats(dep.Department.DepartmentId);
                        setDepartmentNameLabel(departmentName, selectedDepName);
                        setPartsPerMonthLabel(partsPerMonth);
                        setPartsPerEmployeeLabel(partsPerEmployee);
                        setTodaysPartsAmountLabel(todaysParts);
                    }
                }
            }
            else { }
        }

        public void setPane(DataGridView departmentsListGridView)
        {
            showDepartmentsList(departmentsListGridView);
        }

        public Employee FindEmployee(string name, string surname, string pesel)
        {
            foreach (DepartmentManager dep in Instance.Downloader.DepManagersList)
            {
                foreach (Employee employee in dep.EmployeesList)
                {
                    if (employee.Name == name && employee.LastName == surname && employee.Pesel == pesel)
                        return employee;
                }
            }
            return null;
        }

        public bool MoveEmployee(int newDepartmentId, Employee selectedEmployee)
        {
            if (selectedEmployee != null && newDepartmentId != 0 &&
                selectedEmployee.DepartmentId != newDepartmentId && selectedEmployee != Instance.CurrentEmployee)
            {
                foreach (DepartmentManager dep in Instance.Downloader.DepManagersList)
                {
                    foreach (Employee employee in dep.EmployeesList)
                    {
                        if (employee.Equals(selectedEmployee)) employee.DepartmentId = newDepartmentId;
                        // TODO update bazy pod kątem wrzucenia listy użytkowników lub UPDATE department_id (nowa metoda DBManager)
                        DBManager.Instance.MoveEmployee(employee, newDepartmentId);
                        Instance.Downloader.DownloadData(Instance.CurrentEmployee);
                        return true;
                    }
                }
            }
            return false;
        }

        public bool RemoveEmployee(Employee selectedEmployee)
        {
            if (selectedEmployee != null && selectedEmployee != Instance.CurrentEmployee)
            {
                foreach (DepartmentManager dep in Instance.Downloader.DepManagersList)
                {
                    foreach (Employee employee in dep.EmployeesList)
                    {
                        if (employee.Equals(selectedEmployee)) dep.EmployeesList.Remove(employee);
                        // TODO update bazy pod kątem wrzucenia listy użytkowników lub DELETE employee (nowa metoda DBManager)
                        DBManager.Instance.DeleteEmployee(employee);
                        Instance.Downloader.DownloadData(Instance.CurrentEmployee);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
