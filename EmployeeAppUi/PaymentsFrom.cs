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
using EmployeeAppLib;

namespace EmployeeAppUi
{
    public partial class PaymentsFrom : Form
    {
        public List<EmployeeModel> employees = new List<EmployeeModel>().GetEmployeeWithPosititon();
        public PaymentsFrom()
        {
            InitializeComponent();
            foreach (var employee in employees)
            {
                UnitBox.Items.Add(employee.Unit.UnitName);
            }
            foreach (var employee in employees)
            {
                EmployeesBox.Items.Add($"{employee.FullName}:{employee.Position.DayliSalary}");
            }
        }

        private void MakePaymentButton_Click(object sender, EventArgs e)
        {
            EmployeeModel employee = employees[EmployeesBox.SelectedIndex];
            if (ValidatePaymenForm()) {
                PaymentModel payment = new PaymentModel()
                {
                    PaymentAmount = CalculatePayment(employee),
                    PaymentDate = DateTime.Now,
                    EmployeeId = employee.Id
                };
                payment.AddPayment();
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных", "Ошибка в заполнении формы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private decimal CalculatePayment(EmployeeModel employee)
        {
            decimal output;
            int workdays = GetAllWorkDays(BeginnigDate.Value, EndingDate.Value);
            output = employee.Position.DayliSalary * workdays * 0.13M ;
            AmountLabel.Text = $"{output.ToString()}.руб";
            return output;
        }
        private int GetAllWorkDays(DateTime begin, DateTime end)
        {
            int counter = 0;
            while (begin.DayOfYear < end.DayOfYear)
            {
                if (begin.DayOfWeek != DayOfWeek.Saturday && begin.DayOfWeek != DayOfWeek.Sunday)
                    counter++;
                begin = begin.AddDays(1);
            }
            return counter;
        }
        private bool ValidatePaymenForm()
        {
            bool output = true;
            if (UnitBox.SelectedIndex == -1 && EmployeesBox.SelectedIndex == -1)
                output = false;
            if (BeginnigDate.Value.Date == EndingDate.Value.Date)
                output = false;
            return output;
        }

        private void UnitBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
