using System;
using System.Collections.Generic;
using System.Text;
using ProductionManagementSystem.Models;
using ProductionManagementSystem.DataAccess;
using System.Windows.Forms;

namespace ProductionManagementSystem.Controllers
{
    public class BaseController
    {
        #region private members

        private static BaseController instance = null;
        private static readonly object synclock = new object();

        #endregion

        #region public properties and methods

        public Employee CurrentEmployee { get; set; }

        public MainForm CurrentUserForm { get; set; }

        public DataDownloader Downloader { get; set; }


        protected BaseController() 
        {
            CurrentUserForm = new MainForm();
        }

        public static BaseController Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synclock)
                    {
                        if (instance == null) instance = new BaseController();
                    }
                }
                return instance;
            }
            protected set
            {
                instance = value;
            }
        }



        #endregion

    }
}