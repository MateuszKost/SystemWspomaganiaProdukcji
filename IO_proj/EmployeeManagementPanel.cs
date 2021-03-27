using ProductionManagementSystem.Controllers;
using ProductionManagementSystem.Models;
using System;
using System.Windows.Forms;

namespace ProductionManagementSystem
{
    public partial class EmployeeManagementPanel : UserControl
    {
        public EmployeeManagementPanel()
        {
            Dock = DockStyle.Fill;
            InitializeComponent();
            SetDepComboBox();
        }


        private void ConfirmEmployeeData(object sender, EventArgs e)
        {
            var name = nameBox.Text;
            var surname = surnameBox.Text;
            var pesel = peselMaskedBox.Text;

            if (name != "" && surname != "" && pesel.Length == 11)
            {
                Employee employee = (BaseController.Instance as FacilityManagerController).FindEmployee(name, surname, pesel);

                if (employee != null)
                {
                    employeeInfoLabel.Text =
                        name + ' ' + surname + '\n' + pesel + '\n' + employee.PlaceOfResidence;
                    departmentNameLabel.Text = BaseController.Instance.Downloader.DepartmentsList.Find(match:
                        x => x.DepartmentId == employee.DepartmentId).DepartmentName;

                    BaseController.Instance.Downloader.Employee = employee;
                }
                else
                {
                    employeeInfoLabel.Text = " ";
                    departmentNameLabel.Text = " ";
                }
            }
        }

        private void SetDepComboBox()
        {
            foreach (Department d in BaseController.Instance.Downloader.DepartmentsList)
            {
                depChoiceComboBox.Items.Add(d.DepartmentName);
            }
        }

        private void MoveEmployeeButton(object sender, EventArgs e)
        {
            Department selectedDep = BaseController.Instance.Downloader.DepartmentsList.Find(
                             match: x => x.DepartmentName == depChoiceComboBox.SelectedItem);
            bool isMoved = (BaseController.Instance as FacilityManagerController)
                            .MoveEmployee(selectedDep.DepartmentId, BaseController.Instance.Downloader.Employee);
            if (isMoved)
            {
                MessageBox.Show($"Przeniesiono do działu: {selectedDep.DepartmentName}");
                nameBox.Clear();
                surnameBox.Clear();
                peselMaskedBox.Clear();
                departmentNameLabel.Text = "Przeniesiony do działu: " + selectedDep.DepartmentName;
                BaseController.Instance.Downloader.Employee = null;
            }
            else
                MessageBox.Show("Nie można było przenieść");
        }

        private void RemoveEmployeeButton(object sender, EventArgs e)
        {
            bool isRemoved = (BaseController.Instance as FacilityManagerController)
                            .RemoveEmployee(BaseController.Instance.Downloader.Employee);
            if (isRemoved)
            {
                MessageBox.Show($"Usunięto pracownika: " +
                    $"{BaseController.Instance.Downloader.Employee.Name + ' ' + BaseController.Instance.Downloader.Employee.LastName}");
                BaseController.Instance.Downloader.Employee = null;
            }
            else
                MessageBox.Show("Nie można było usunąć");
        }
    }
}
