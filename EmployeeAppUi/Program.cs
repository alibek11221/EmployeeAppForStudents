using EmployeeAppLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeAppLib;

namespace EmployeeAppUi
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        private const string CnnString = "EmployeeCnn";

        [STAThread]
        static void Main()
        {
            GeneralConfig.SetCnnString(CnnString);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
