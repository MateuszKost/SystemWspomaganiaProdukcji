using IO_proj;
using ProductionManagementSystem.DataAccess;
using ProductionManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProductionManagementSystem
{
    public partial class MainForm : Form
    {

        //andrew68 : haslo

        //kubus123 : ugabuga

        //bogusia420 : weed

        //marcino22 : qwerty

        public MainForm()
        { 
            InitializeComponent();
        }

        public void AddEmployeeTabs()
        {
            tabControl.Controls.Add(employeeTab1);
            tabControl.Controls.Add(employeeTab2);

            employeeTab1.Controls.Add(new EmployeePanel());
            employeeTab2.Controls.Add(new EmployeeProfilePanel());

        }

        public void AddManagerTabs()
        {
            tabControl.Controls.Add(managerTab1);

            managerTab1.Controls.Add(new DepartmentManagerMainPanel());
        }

        public void AddAdminTabs()
        {
            tabControl.Controls.Add(adminTab1);
            tabControl.Controls.Add(adminTab2);
            tabControl.Controls.Add(adminTab3);
            tabControl.Controls.Add(adminTab4);

            adminTab1.Controls.Add(new FacilityManagerPanel());
            adminTab2.Controls.Add(new AddEmployee());
            adminTab3.Controls.Add(new EmployeeManagementPanel());
            adminTab4.Controls.Add(new PrizeManagerPanel());
        }

        public static void ExitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
