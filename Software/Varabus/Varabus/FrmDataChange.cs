using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Varabus.Models;
using Varabus.Repositories;

namespace Varabus
{
    public partial class FrmDataChange : Form
    {
        private Station station;
        private bool InsertOrUpdate;
        public FrmDataChange(int id)
        {
            InitializeComponent();
            station = StationRepository.GetStation(id);
            InsertOrUpdate = false;
            if (id != 0)
            {
                InsertOrUpdate = true;
                txtId.Text = station.Id.ToString();
                txtStation.Text = station.Name;
                txtDescription.Text = station.Description;
                numLine.Text = station.Line.ToString();
                txtSchedule.Text = station.Schedule;
            }
        }

        private void FrmDataChange_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStation_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string name = txtStation.Text;
            string description = txtDescription.Text;
            int line = int.Parse(numLine.Text);
            string schedule = txtSchedule.Text;

            var station = new Station
            {
                Id = id,
                Name = name,
                Description = description,
                Line = line,
                Schedule = schedule
            };
            if (InsertOrUpdate == true)
            {
                StationRepository.UpdateEvaluation(station);
            }
            else
            {
                StationRepository.InsertEvaluation(station);
            }
        }
    }
}
