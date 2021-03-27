using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ProductionManagementSystem.Models;
using ProductionManagementSystem.DataAccess;
using ProductionManagementSystem.Controllers;

namespace ProductionManagementSystem
{
    public partial class EmployeeProfilePanel : UserControl
    {
        public EmployeeProfilePanel()
        {
            Dock = DockStyle.Fill;
            InitializeComponent();
            ShowCurrentEmployeeInfo();
            setComboBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getPrizeButtonAction(object sender, EventArgs e)
        {
            Employee employee = BaseController.Instance.CurrentEmployee;
            List<Prize> tmpPrizeList = new List<Prize>(BaseController.Instance.Downloader.PrizeList);
            int index = prizePicker.SelectedIndex;

            if (index >=0)
            {
                List<string> arguments = new List<string>();
                
                // zrobić update tak, żeby po ponownym naciśnięciu przycisku wyrzuciło na nowo zaktualizowaną liczbę punktów
                /* if (index >= 0) // sprawdzanie wartości indexu, jeżeli żadna nagroda nie została wybrana, liczba punktów się nie zmieni
                 {
                     prizePoints -= tmpPrizeList[index].RequiredPoints;
                 }*/

                arguments.Add(employee.UserId.ToString());
                arguments.Add(tmpPrizeList[index].PrizeId.ToString());
                arguments.Add(tmpPrizeList[index].RequiredPoints.ToString());

                //tutaj updatowanie danej osoby, ktora wybrala nagrode w bazie danych
                (BaseController.Instance as EmployeeController).UpdateTableView(arguments);

                int prizePoints = BaseController.Instance.Downloader.CurrentUserPrizePoints;

                labelCurrentUserPoints.Text = BaseController.Instance.Downloader.CurrentUserPrizePoints.ToString(); // updatowanie ilosci punktow uzytkownika

                MessageBox.Show("Wybrales: " + tmpPrizeList[index].PrizeName + "\nPozostalo Ci: " + prizePoints);
            }
            else
                MessageBox.Show("Wybierz nagrode", "błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            prizePicker.Items.Clear(); //czyszczenie comboboxa aby elementy sie nie powtarzaly
            setComboBox();
        }

        private void setComboBox()
        {
            Employee employee = BaseController.Instance.CurrentEmployee;
            List<Prize> tmpPrizeList = new List<Prize>(BaseController.Instance.Downloader.PrizeList);

           int prizePoints = BaseController.Instance.Downloader.CurrentUserPrizePoints;

            for (int i = 0; i < tmpPrizeList.Count; i++)
            {
                if (prizePoints > tmpPrizeList[i].RequiredPoints)
                {
                    prizePicker.Items.Add(tmpPrizeList[i].PrizeName + " " + tmpPrizeList[i].RequiredPoints + "pkt");
                }
            }
        }

        //usuniecie opcji z combocboxa i wprowadzenie nowych

        private void ShowCurrentEmployeeInfo()
        {
            //EmployeeDownloader employeeDownloader = new EmployeeDownloader();
            Employee employee = EmployeeController.Instance.CurrentEmployee;
            userDataListValues.Items.Add(employee.Name + " " + employee.LastName);
            userDataListValues.Items.Add(employee.Pesel);
            userDataListValues.Items.Add(employee.DateOfBirth);
            userDataListValues.Items.Add(employee.PlaceOfResidence);
            userDataListValues.Items.Add(BaseController.Instance.Downloader.CurrentDepartmentName.ToString());
            labelCurrentUserPoints.Text = BaseController.Instance.Downloader.CurrentUserPrizePoints.ToString();

        }
    }
}
