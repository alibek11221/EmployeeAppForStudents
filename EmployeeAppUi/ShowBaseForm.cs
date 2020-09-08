using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeAppLib.Models;
using EmployeeAppLib;

namespace EmployeeAppUi
{
    public partial class ShowBaseForm : Form
    {
        public ShowBaseForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private async void Initialize()
        {
            List<UnitModel> units = await new List<UnitModel>().GetAllUnits();
            dataGridView1.DataSource = units;
        }
    }
}