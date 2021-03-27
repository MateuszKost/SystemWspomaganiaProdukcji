using System;
using System.Windows.Forms;
using ProductionManagementSystem.Security;
using ProductionManagementSystem.DataAccess;
using ProductionManagementSystem.Models;
using ProductionManagementSystem.Controllers;
using IO_proj;

namespace ProductionManagementSystem
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            CredentialManager manager = new CredentialManager();

            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            int userId;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                DisplayErrorMessage("Wpisz login i hasło");
                return;
            }

            StatusCode resultCode = manager.Login(login, password, out userId);

            switch (resultCode)
            {
                case StatusCode.WrongCredentials:
                    DisplayErrorMessage("Zły login i/lub hasło.");
                    break;
                case StatusCode.UnkonownError:
                    DisplayErrorMessage("Nieznany błąd.");
                    break;
                case StatusCode.Ok:
                    {
                        Employee currentUser = DBManager.Instance.GetUserById(userId);
                        BaseController controller;

                        if (currentUser != null)
                            switch (currentUser.TypeId)
                            {
                                case (int)global.UserType.Employee:
                                    controller = new EmployeeController(currentUser);
                                    break;
                                case (int)global.UserType.Manager:
                                    controller = new ManagerController(currentUser);
                                    break;
                                case (int)global.UserType.Admin:
                                    controller = new FacilityManagerController(currentUser);
                                    break;
                            }
                    }
                    TableLayoutPanel tlp = Parent as TableLayoutPanel;
                    LoginForm form = tlp.Parent as LoginForm;
                    form.Hide();
                    break;
            }
        }
        private void DisplayErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
