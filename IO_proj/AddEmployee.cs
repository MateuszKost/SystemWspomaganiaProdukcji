using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ProductionManagementSystem.Controllers;
using ProductionManagementSystem.Models;
using ProductionManagementSystem.DataAccess;

namespace ProductionManagementSystem
{
    public partial class AddEmployee : UserControl
    {
        public AddEmployee()
        {
            Dock = DockStyle.Fill;
            InitializeComponent();
            SetTypeComboBox();
            SetDepComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmButtonClickAction(object sender, EventArgs e)
        {
            UserType selectedType = BaseController.Instance.Downloader.UserTypes.Find(match: x => x.TypeName == typeComboBox.SelectedItem);
            Department selectedDep = BaseController.Instance.Downloader.DepartmentsList.Find(match: x => x.DepartmentName == depComboBox.SelectedItem);

            BaseController.Instance.Downloader.Employee = new Employee
            {
                UserId = 0,
                TypeId = selectedType.TypeId,
                Name = nameBox.Text,
                LastName = surnameBox.Text,
                Pesel = peselMaskedBox.Text,
                DateOfBirth = DateTime.Parse(dateBox.Text),
                PlaceOfResidence = addressBox.Text.ToString(),
                DepartmentId = selectedDep.DepartmentId
            };

            (BaseController.Instance.Downloader as FacilityManagerDownloader).UpdateData(null);
            MessageBox.Show((BaseController.Instance.Downloader as FacilityManagerDownloader).Message);
        }

        private void SetTypeComboBox()
        {
            
            foreach(UserType u in BaseController.Instance.Downloader.UserTypes)
            {
                    typeComboBox.Items.Add(u.TypeName);
            }
        }

        private void SetDepComboBox()
        {
            foreach (Department d in BaseController.Instance.Downloader.DepartmentsList)
            {
                depComboBox.Items.Add(d.DepartmentName);
            }
        }

        private void ClearAllFields(object sender, EventArgs e)
        {
            nameBox.Text = "";
            surnameBox.Text = "";
            peselMaskedBox.Text = "";
            dateBox.Text = "";
            addressBox.Text = "";
        }
    }
}
