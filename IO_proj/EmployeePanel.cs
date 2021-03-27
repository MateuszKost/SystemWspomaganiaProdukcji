using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ProductionManagementSystem.DataAccess;
using System.Globalization;
using ProductionManagementSystem;
using System.Drawing.Drawing2D;
using ProductionManagementSystem.Security;
using ProductionManagementSystem.Controllers;

namespace IO_proj
{
    public partial class EmployeePanel : UserControl
    {
        public EmployeePanel()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
            showForms();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int intOut;
            if (int.TryParse(partsAssembledTextBox.Text, out intOut) && !string.IsNullOrWhiteSpace(partsAssembledTextBox.Text))
            {
                List<string> arguments = new List<string>();
                arguments.Add(dateTimePicker.Value.ToString("yyyy-MM-dd"));//date
                arguments.Add(partsAssembledTextBox.Text);//amount

                (BaseController.Instance as EmployeeController).UpdateTableView(arguments);
                MessageBox.Show("Dodano nowy formularz", "Jest git", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Wprowadź poprawne dane", "błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showForms();


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

        private void showForms()
        {
            this.Dock = DockStyle.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.DataSource = BaseController.Instance.CurrentEmployee.formList;
           // dateTimePicker.Anchor = AnchorStyles.Bottom;
            partsAssembledTextBox.Anchor = AnchorStyles.Bottom;
           // textBox3.Anchor = AnchorStyles.Bottom;
          //  textBox4.Anchor = AnchorStyles.Bottom;
          //  saveButton.Anchor = AnchorStyles.Bottom;
          //  button2.Anchor = AnchorStyles.Bottom;
          //  logOutButton.Anchor = AnchorStyles.Bottom;
          //  label1.Anchor = AnchorStyles.Bottom;
          //  label2.Anchor = AnchorStyles.Bottom;
         //   label3.Anchor = AnchorStyles.Bottom;
         //   label4.Anchor = AnchorStyles.Bottom;
            dataGridView2.Columns[0].HeaderText = "DATA";
            dataGridView2.Columns[1].HeaderText = "ILOŚĆ CZĘŚCI";
            dataGridView2.Columns[2].HeaderText = "NORMA";
            dataGridView2.Columns[3].HeaderText = "PUNKTY NAGRÓD";

        }
    }
}
