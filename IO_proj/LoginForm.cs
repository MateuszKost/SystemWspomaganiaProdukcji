using ProductionManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO_proj
{
    public partial class LoginForm : Form
    {
        private LoginControl loginControl;
        private RegisterControl registerControl;
        private bool registerMode = true;
        public LoginForm()
        {
            InitializeComponent();
            loginControl = new LoginControl();
            registerControl = new RegisterControl();
            mainContainer.Controls.Add(loginControl, 0, 0);
            mainContainer.Controls.Add(registerControl, 0, 0);
            registerControl.Hide();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if(registerMode)
            {
                button.Text = "Wróć";
                loginControl.Hide();
                registerControl.Show();
                registerControl.BringToFront();
                registerMode = !registerMode;
            } 
            else
            {
                button.Text = "Zarejestruj";
                registerControl.Hide();
                loginControl.Show();
                loginControl.BringToFront();
                registerMode = !registerMode;
            }
        }

        public static void ExitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
