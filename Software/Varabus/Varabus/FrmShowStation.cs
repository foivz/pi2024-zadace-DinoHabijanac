using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Varabus.Models;
using Varabus.Repositories;

namespace Varabus
{
    public partial class FrmShowStation : Form
    {
        public FrmShowStation()
        {
            InitializeComponent();
        }

        private void btnAddStation_Click(object sender, EventArgs e)
        {
            FrmDataChange frmDataChange = new FrmDataChange();
            frmDataChange.Show();
        }

        private void FrmShowStation_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_dhabijana22_DB", "PI2324_dhabijana22_User", "gyb{MI8{");
            ShowStations();
        }

        private void ShowStations()
        {
            List<Station> stations = StationRepository.GetStations();
            dgvStations.DataSource = stations;
        }
        private void btnDeleteStation_Click(object sender, EventArgs e)
        {

        }

        private void btnEditStation_Click(object sender, EventArgs e)
        {
            FrmDataChange frmDataChange = new FrmDataChange();
            frmDataChange.Show();
        }

        private void dgvStations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
