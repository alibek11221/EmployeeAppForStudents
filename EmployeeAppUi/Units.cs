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
    public partial class Units : Form
    {
  
        public Units()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UnitsList.Items.Clear();
            List<UnitModel> units = new List<UnitModel>().GetAllUnits();
            foreach (UnitModel unit in units)
            {
                UnitsList.Items.Add($"{unit.Id} : {unit.UnitName}");
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
                UnitModel unit = new UnitModel();
                unit.UnitName = UnitNameTextBox.Text;
                unit.AddUnit();
            }
            else
            {
                MessageBox.Show("Введите название отдела", "Не введено название", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPositionButton_Click(object sender, EventArgs e)
        {

        }

    }
}
