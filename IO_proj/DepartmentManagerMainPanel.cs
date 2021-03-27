using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ProductionManagementSystem.Models;
using ProductionManagementSystem.Controllers;
using IO_proj;

namespace ProductionManagementSystem
{
    public partial class DepartmentManagerMainPanel : UserControl
    {
        public DepartmentManagerMainPanel()
        {Dock = DockStyle.Fill;
            InitializeComponent();
            
            (BaseController.Instance as ManagerController).setPane(employeesDataGridView, myDepartmentNameLabel, partsPerMonthCountLabel, partsPerEmpCountLabel, partsProducedCountLabel);
            //ShowList();
            //ShowDepartmentInfo();
        }

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
    }
}
