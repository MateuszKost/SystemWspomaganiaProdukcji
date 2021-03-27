using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using ProductionManagementSystem.Security;

namespace ProductionManagementSystem
{
    public partial class RegisterControl : UserControl
    {
        private static int[] weights = { 1,3,7,9,1,3,7,9,1,3 };
        public RegisterControl()
        {
            InitializeComponent();
        }

        //to trzeba poprawić xd
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string pesel, userName, password;
            CredentialManager manager = new CredentialManager();
            var fieldNames = new List<string>();
            if (FieldsEmpty(out fieldNames))
            {
                var names = new StringBuilder();
                foreach (var name in fieldNames) names.Append(name+", ");
                DisplayErrorMessage($"Pola: {names} nie mogą być puste");
                return;
            }

            if (!PeselCorrect())
            {
                DisplayErrorMessage("Wprowadzono niepoprawny PESEL");
                return;
            }
            else
            {
                pesel = PeselTextBox.Text;
            }

            if (PassMismatch())
            {
                DisplayErrorMessage("Wprowadzone hasła różnią się");
                return;
            }
            else
            {
                password = PasswordTextBox.Text;
            }
            userName = LoginTextBox.Text;
            if(string.IsNullOrEmpty(userName))
            {
                DisplayErrorMessage("Pole login nie może być puste");
                return;
            }

            var resultCode = manager.RegisterUser(pesel, userName, password);

            switch(resultCode)
            {
                case StatusCode.PeselNotFound:
                    DisplayErrorMessage("Nie znaleziono numeru PESEL w bazie");
                    break;
                case StatusCode.UserNameTaken:
                    DisplayErrorMessage("Podana nazwa użytkownika jest już zajęta");
                    break;
                case StatusCode.UnkonownError:
                    DisplayErrorMessage("Nieznany błąd");
                    break;
                case StatusCode.Ok:
                    MessageBox.Show("Pomyślnie dodano użytkownika");
                    break;
            }
        }

        private bool PeselCorrect()
        {
            var input = PeselTextBox.Text;
            if (input.Length != 11) return false;
            int[] number = new int[11];
            for(int i=0; i<11; i++)
            {
                if(!int.TryParse(input[i].ToString(), out number[i])) return false;
            }
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += (weights[i] * number[i]) % 10;
            }
            int controlDigit = 10 - sum % 10;
            if (controlDigit == number[10]) return true;
            return false;
        }

        private bool PassMismatch()
        {
            if (PasswordTextBox.Text.Equals(PasswordCfrmTextBox.Text)) return false;
            return true;
        }

        private void ResetFields()
        {
            foreach(var control in Controls)
            {
                if(control.GetType().Equals(typeof(TextBox)))
                {
                    var textBox = control as TextBox;
                    textBox.Text = string.Empty;
                }
            }
        }

        private bool FieldsEmpty(out List<string> fieldNames)
        {
            fieldNames = new List<string>();
            foreach (var control in Controls)
            {
                if (control.GetType().Equals(typeof(TextBox)))
                {
                    var textBox = control as TextBox;
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        fieldNames.Add(textBox.Tag.ToString());
                    }
                        
                }
            }
            if (fieldNames.Any()) return true;
            return false;
        }

        private void DisplayErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
