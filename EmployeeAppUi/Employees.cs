using EmployeeAppLib;
using EmployeeAppLib.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class EmployeesForm : Form
    {
        public List<UnitModel> units = new List<UnitModel>().GetAllUnitsWithPositions();
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {            
            foreach (var unit in units)
            {
                UnitComboBox.Items.Add(unit.UnitName);
            }
        }
        private void UnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PositionListBox.Items.Clear();
            if (UnitComboBox.SelectedIndex != -1)
            { 
                foreach (var postition in units[UnitComboBox.SelectedIndex].Positions)
                {
                    PositionListBox.Items.Add(postition.PositionName);
                }
            }
        }
        private bool ValidateEmployeeForm()
        {
            bool output = true;
            if (SurnameBox.Text.Trim() == string.Empty && NameBox.Text.Trim() == string.Empty && MiddlenameBox.Text.Trim() == string.Empty)
                output = false;
            if (DateTime.Now.Year - BornYearDate.Value.Year < 18)
                output = false;
            if (FemaleRadio.Checked == false && MaleRadio.Checked == false)
                output = false;
            if (UnitComboBox.SelectedIndex == -1 && PositionListBox.SelectedIndex == -1)
                output = false;
            return output;
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            try{
                if (ValidateEmployeeForm())
                {
                    UnitModel unit = units[UnitComboBox.SelectedIndex];
                    PositionModel position = unit.Positions[PositionListBox.SelectedIndex];
                    EmployeeModel employee = new EmployeeModel() { };
                    employee.FullName = $"{SurnameBox.Text} {NameBox.Text} {MiddlenameBox.Text}";
                    employee.BornYear = BornYearDate.Value.Date;
                    employee.Gender = MaleRadio.Checked ? true : false;
                    employee.IsMaried = IsMarried.Checked ? true : false;
                    employee.HasKids = HasKidsCheckBox.Checked ? true : false;
                    employee.AmountOfKids = Convert.ToInt32(KidsAmountNumeric.Value);
                    employee.UnitId = unit.Id;
                    employee.PositionId = position.Id;
                    employee.AddEmployee();
                    JobDone();
                }
                else
                {
                    MessageBox.Show("Заполнены не все поля формы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(DbUpdateException) 
            {
                MessageBox.Show("Сотрудник с такой должностью уже числится в базе", "Должность уже занята", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void JobDone()
        {
            SurnameBox.Text = "";
            NameBox.Text = "";
            MiddlenameBox.Text = "";
            MaleRadio.Checked = false;
            FemaleRadio.Checked = false;
            IsMarried.Checked = false;
            BornYearDate.Value = DateTime.Now;
            HasKidsCheckBox.Checked = false;
            KidsAmountNumeric.Value = 0;
            UnitComboBox.SelectedIndex = -1;
            PositionListBox.SelectedIndex = -1;
            MessageBox.Show("Сотрудник успешно добавлен в базу", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void HasKidsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            KidsAmountNumeric.Enabled = !KidsAmountNumeric.Enabled;
        }
    }
}
