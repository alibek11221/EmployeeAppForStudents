﻿using EmployeeAppLib;
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
            
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.ShowDialog();
            employee.Dispose();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
