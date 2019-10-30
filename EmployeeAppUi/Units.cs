using EmployeeAppLib;
using EmployeeAppLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeAppUi
{
    public partial class Units : Form
    {
        public List<UnitModel> units;
        private void Itnitialize()
        {
            if (units == null)
            {
                units =  new List<UnitModel>().GetAllUnitsWithPositions();
            }
        }
        public Units()
        {
            InitializeComponent();

        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UnitsList.Items.Clear();
            List<PositionModel> positions;
            foreach (UnitModel unit in units)
            {
                UnitsList.Items.Add($"{unit.Id} : {unit.UnitName}\n");
                positions = new List<PositionModel>().GetPositionByUnit(unit);
                foreach (PositionModel position in positions)
                {
                    UnitsList.Items.Add($"\t{position.PositionName}");
                }
            }
        }
        private bool ValidateUnitForm()
        {
            bool output = true;
            if (UnitNameTextBox.Text == string.Empty)
                output = false;
            return output;
        }

        private void AddUnitButton_Click(object sender, EventArgs e)
        {
            if (ValidateUnitForm())
            {
                UnitModel unit = new UnitModel
                {
                    UnitName = UnitNameTextBox.Text
                };
                unit.AddUnit();
                units =  units.GetAllUnitsWithPositions();
            }
            else
            {
                MessageBox.Show("Введите название отдела", "Не введено название", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPositionButton_Click(object sender, EventArgs e)
        {
            if (ValidatePostion())
            {
                PositionModel position = new PositionModel
                {
                    PositionName = string.Format(PositionNameBox.Text),
                    DayliSalary = int.Parse(PositionSalaryBox.Text),
                    UnitID = UnitComboBox.SelectedIndex + 1
                };
                position.AddPosition();
                units =  units.GetAllUnitsWithPositions();
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных", "Не заполнены все поля", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidatePostion()
        {
            bool output = true;
            if (UnitComboBox.SelectedIndex == -1)
                output = false;
            if (PositionNameBox.Text == string.Empty)
                output = false;
            if (!int.TryParse(PositionSalaryBox.Text, out _))
                output = false;
            return output;
        }
        private  void UnitComboBox_DropDown(object sender, EventArgs e)
        {
            UnitComboBox.Items.Clear();
             Itnitialize();
            foreach (UnitModel unit in units)
            {
                UnitComboBox.Items.Add($"{unit.UnitName}");
            }
        }

        private void UnitComboBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void Units_Load(object sender, EventArgs e)
        {
             Itnitialize();
        }
    }
}
