using EmployeeAppLib;
using EmployeeAppLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeAppUi
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void UnitsButton_Click(object sender, EventArgs e)
        {
            Units unit = new Units();
            unit.ShowDialog();
            unit.Dispose();
        }

        private void PaymentsButton_Click(object sender, EventArgs e)
        {
            PaymentsFrom paymentsFrom = new PaymentsFrom();
            paymentsFrom.ShowDialog();
            paymentsFrom.Dispose();
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            EmployeesForm employee = new EmployeesForm();
            employee.ShowDialog();
            employee.Dispose();
        }
    }
}
