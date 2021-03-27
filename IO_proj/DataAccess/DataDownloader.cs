using ProductionManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManagementSystem.DataAccess
{
    public class DataDownloader
    {

        public List<Department> DepartmentsList { set; get; }
        public List<DepartmentManager> DepManagersList { set; get; }
        public List<Prize> PrizeList { set; get; }
        public List<TakenPrize> TakenPrizeList { set; get; }
        public List<UserType> UserTypes { set; get; }
        public int CurrentUserPrizePoints { get; set; }
        public string CurrentDepartmentName { get; set; }
        public Employee Employee { get; set; }

        //tablica przechowująca staty za dzień, miesiąc, rok, całość
        public int[] stats = new int[4];

        virtual public void DownloadData(Employee signedInUser)
        {

        }

        virtual public void UpdateData(List<string> arguments)
        {

        }

        virtual public int[] GetDepartmentStats(int depId)
        {
            return null;
        }

    }
}
