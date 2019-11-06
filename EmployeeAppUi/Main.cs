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
            Units units = new Units();//Создаем объект класса Units
            units.ShowDialog();//Вызываем метод ShowDialog() класса Units 
            //(Выводит форму в виде модального окна)
            units.Dispose();//Вызываем метод Dispose() класса Units
            //(Удаляет объект класса Units.)
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

        private void ShowBaseButton_Click(object sender, EventArgs e)
        {
            ShowBaseForm baseForm = new ShowBaseForm();
            baseForm.ShowDialog();
            baseForm.Dispose();
        }
    }
}
