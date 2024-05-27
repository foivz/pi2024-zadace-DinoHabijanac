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
            numSearch.Value = 0;
        }

        public void btnAddStation_Click(object sender, EventArgs e)
        {
            int id = 0;
            FrmDataChange frmDataChange = new FrmDataChange(id, this);
            Hide();
            frmDataChange.ShowDialog();
        }

        public void FrmShowStation_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_dhabijana22_DB", "PI2324_dhabijana22_User", "gyb{MI8{");
            ShowStations();
        }

        public void ShowStations()
        {
            dgvStations.DataSource = null;
            List<Station> stations = StationRepository.GetStations();
            dgvStations.DataSource = stations;
        }

        public void ShowStationsLine(int line)
        {
            dgvStations.DataSource = null;
            List<Station> stations = StationRepository.GetStationsLine(line);
            dgvStations.DataSource = stations;
        }

        public void btnDeleteStation_Click(object sender, EventArgs e)
        {
            if (dgvStations.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvStations.SelectedRows[0].Cells["Id"].Value);
                StationRepository.DeleteEvaluation(id);
                ShowStations();
            }
        }
        public void btnEditStation_Click(object sender, EventArgs e)
        {
            if (dgvStations.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvStations.SelectedRows[0].Cells["Id"].Value);
                Hide();
                FrmDataChange frmDataChange = new FrmDataChange(id, this);
                frmDataChange.ShowDialog();
            }
        }

        private void dgvStations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int line = int.Parse(numSearch.Text);
            if (line != 0)
            {
                ShowStationsLine(line);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowStations();
        }
    }
}
