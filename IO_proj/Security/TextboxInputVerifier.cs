using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace ProductionManagementSystem.Security
{
    class TextboxInputVerifier
    {
        private string dateFormat = "yyyy-MM-dd";
        private string title = "Błąd";
        private DateTime dtOut;
        private int intOut;

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool VerifyEmployeeForm(string date, string parts)
        {
            if (string.IsNullOrWhiteSpace(date) || string.IsNullOrWhiteSpace(parts))
            {
                ShowErrorMessage("Uzupełnij pola formularza!");
                return false;
            }
            else if(!DateTime.TryParseExact(date, dateFormat, null, DateTimeStyles.None, out dtOut) || !int.TryParse(parts, out intOut))
            {
                ShowErrorMessage("Wprowadź dane w poprawnym formacie!");
                return false;
            }
            else
                return true;
        }



    }
}
