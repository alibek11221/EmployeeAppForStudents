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
        public Units()
        {
            InitializeComponent();
            Itnitialize();
        }

        public List<UnitModel> units;
        private void Itnitialize()
        {
            units = new List<UnitModel>().GetAllUnitsWithPositions();
        }

        private void RefreshAll()
        {
            UnitNameTextBox.Text = "";
            PositionNameBox.Text = "";
            PositionSalaryBox.Text = "";
            UnitComboBox.SelectedItem = default;
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

        private bool ValidateUnitForm()
        {
            bool output = true;
            if (UnitNameTextBox.Text == string.Empty)
                output = false;
            return output;
        }

        private void AddUnitButton_Click(object sender, EventArgs e)
        {
            if (ValidateUnitForm())//Если заполнены все необходимые поля
            {
                UnitModel unit = new UnitModel//Создать объект класса UnitModel
                {
                    UnitName = UnitNameTextBox.Text//Присвоить свойству UnitName значение.
                };
                unit.AddUnit();//Вызвать метод AddUnit для сохранения данных в БД
                units = units.GetAllUnitsWithPositions();//Обновляем значение свойства units.
                RefreshAll();//Опустошаем все поля.
            }
            else//Иначе
            {
                MessageBox.Show("Проверьте правильность введенных данных",
                                "Не заполнены все поля",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);//Вывести сообщение об ошибке на экран.
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
                    UnitId = UnitComboBox.SelectedIndex + 1
                };
                position.AddPosition();
                units = units.GetAllUnitsWithPositions();
                RefreshAll();
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных",
                                "Не заполнены все поля",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
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


        private void UnitComboBox_DropDown(object sender, EventArgs e)
        {
            UnitComboBox.Items.Clear();
            Itnitialize();
            foreach (UnitModel unit in units)
            {
                UnitComboBox.Items.Add($"{unit.UnitName}");
            }
        }


    }
}
