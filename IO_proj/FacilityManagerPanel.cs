using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ProductionManagementSystem;
using System.Linq;
using ProductionManagementSystem.Controllers;

namespace IO_proj
{
    public partial class FacilityManagerPanel : UserControl
    {
        public FacilityManagerPanel()
        { Dock = DockStyle.Fill;
            InitializeComponent();
           
            (BaseController.Instance as FacilityManagerController).setPane(departmentsListGridView);
            
            
            //showDepartmentsList();
            //showEmployeeList();
        }

        private void departmentsListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // set currentSelectedRow
            (BaseController.Instance as FacilityManagerController).departmentExecute(departmentsListGridView, employeeListGridView,  e, departmentNameLabel, partsPerMonthCountLabel, partsPerEmpCountLabel, partsProducedCountLabel);

            /*if (e.RowIndex != -1 && departmentsListGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                departmentsListGridView.CurrentRow.Selected = true;
                string selectedDepName = departmentsListGridView.CurrentCell.Value.ToString();
                foreach (var dep in BaseController.Instance.Downloader.DepManagersList)
                {
                    if (dep.Department.DepartmentName == selectedDepName)
                    {
                        employeeListGridView.DataSource = dep.ManagerTableList;

                        employeeListGridView.Columns[0].HeaderText = "Imię";
                        employeeListGridView.Columns[1].HeaderText = "Nazwisko";
                        employeeListGridView.Columns[2].HeaderText = "Data";
                        employeeListGridView.Columns[3].HeaderText = "Części za dzień";
                    }
                }
            }
            else { }     */       
        }
        /*public void showDepartmentsList()
        {
            departmentsListGridView.Enabled = true;
            this.Dock = DockStyle.Fill;
            departmentsListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            departmentsListGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            var departmentsList = BaseController.Instance.Downloader.DepartmentsList;
            departmentsListGridView.DataSource = departmentsList.Select(i => new{ Column1 = i.DepartmentName }).ToList();
            departmentsListGridView.Columns[0].HeaderText = "Dział";
        }

        public void showEmployeeList()
        {
            //employeeListGridView.Enabled = true;
            //employeeListGridView.AutoGenerateColumns = false;
            employeeListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeListGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void FacilityManagerPanel_Load(object sender, EventArgs e)
        {

        }*/

        private void logOutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Wylogowanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                ((Form)this.TopLevelControl).Hide();
            }
        }
        

        //override public void ShowDepartmentInfo()
        //{
        //}
    }
}
