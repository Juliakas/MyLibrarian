﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyLibrarian
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        //Properties.Settings.Default.LibraryDatabaseConnectionString;

        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthWindow());
        }

    }
}