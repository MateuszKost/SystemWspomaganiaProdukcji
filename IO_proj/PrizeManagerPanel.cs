using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ProductionManagementSystem.Controllers;
using ProductionManagementSystem.Models;
using System.Linq;
using ProductionManagementSystem.DataAccess;

namespace ProductionManagementSystem
{
    public partial class PrizeManagerPanel : UserControl
    {
        private List<Prize> currentPrizes;

        public PrizeManagerPanel()
        {
            Dock = DockStyle.Fill;
            InitializeComponent();
            currentPrizes = new List<Prize>(BaseController.Instance.Downloader.PrizeList);
            currentPrizes.Sort((x, y) => x.RequiredPoints.CompareTo(y.RequiredPoints));
            showPrizes();
        }

        private void showPrizes()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            currentPrizes = new List<Prize>(BaseController.Instance.Downloader.PrizeList);
            currentPrizes.Sort((x, y) => x.RequiredPoints.CompareTo(y.RequiredPoints));
            dataGridView1.DataSource = currentPrizes.Select(i => new { Column1 = i.PrizeName, Column2 = i.RequiredPoints }).ToList();
            dataGridView1.Columns[0].HeaderText = "Nazwa";
            dataGridView1.Columns[1].HeaderText = "punkty";
            Invalidate();
        }

        private void addPrizeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(prizeNameBox.Text) || string.IsNullOrEmpty(pointsRequiredBox.Text))
                MessageBox.Show("Błędnie wprowadzone dane !");
            else
            {
                var newPrize = new Prize
                {
                    PrizeId = 0,
                    PrizeName = prizeNameBox.Text,
                    RequiredPoints = int.Parse(pointsRequiredBox.Text)
                };
                (BaseController.Instance.Downloader as FacilityManagerDownloader).NewPrize = newPrize;
                currentPrizes.Add(newPrize);
                Invalidate();
                Refresh();

                (BaseController.Instance.Downloader as FacilityManagerDownloader).UpdateData(null);

                MessageBox.Show("Dodano nagrode");

                BaseController.Instance.Downloader.DownloadData(BaseController.Instance.CurrentEmployee);
                showPrizes();
            }
        }
    }
}
