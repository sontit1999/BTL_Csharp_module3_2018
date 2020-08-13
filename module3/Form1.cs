using module3.BULs;
using module3.DALs;
using module3.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace module3
{
    public partial class Form1 : Form
    {
        int idScheduleOutBound;
        int idScheduleReturn;
        AirportsBUL airporstBUL = new AirportsBUL();
        CabinTypesBUL cabinTypesBUL = new CabinTypesBUL();
        FlightDetailBUL flightDetailBUL = new FlightDetailBUL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            rbOneWay.Checked = true;

            cbFrom.DataSource = airporstBUL.getAirport();
            cbFrom.DisplayMember = "IATACode";
            cbFrom.ValueMember = "ID";

            cbTo.DataSource = airporstBUL.getAirport();
            cbTo.DisplayMember = "IATACode";
            cbTo.ValueMember = "ID";

            cbCabintype.DataSource = cabinTypesBUL.getCabinType();
            cbCabintype.DisplayMember = "Name";
            cbCabintype.ValueMember = "ID";
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOneWay.Checked)
            {
                // ẩn list khứ hồi
                dgvReturn.Hide();
              
            }
            else
            {
                // Hiển thị list khứ hồi            
                dgvReturn.Show();
               
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("booking : " + idScheduleOutBound + " - " + idScheduleReturn);
             BookingConfirmForm booking = new BookingConfirmForm(idScheduleOutBound, idScheduleReturn);
             booking.Show();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            timkiem();
        }

        private void timkiem()
        {
           
            if (rbReturn.Checked)
            {
                dgvOutbound.DataSource = flightDetailBUL.getFlight(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), txtOutbound.Text.ToString(),false);
                dgvReturn.DataSource = flightDetailBUL.getFlightReturn(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue),txtOutbound.Text.ToString(), txtReturn.Text.ToString(), true);
            }
            else
            {
                dgvOutbound.DataSource = flightDetailBUL.getFlight(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), txtOutbound.Text.ToString(), false);
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDisplayOutbound_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOutbound.Checked)
            {
                dgvOutbound.DataSource = flightDetailBUL.getFlightThreeDays(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), txtOutbound.Text.ToString(),false);
            }
            else
            {
                dgvOutbound.DataSource = flightDetailBUL.getFlight(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), txtOutbound.Text.ToString(), false);
            }
        }

        private void checkboxReturn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxReturn.Checked)
            {
                dgvReturn.DataSource = flightDetailBUL.getFlightThreeDays(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), txtReturn.Text.ToString(), true);
            }
            else
            {
                dgvReturn.DataSource = flightDetailBUL.getFlightReturn(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), txtOutbound.Text.ToString(), txtReturn.Text.ToString(), true);
            }
        
        }

        private void rbReturn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReturn.Checked)
            {
                dgvOutbound.DataSource = flightDetailBUL.getFlight(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), txtOutbound.Text.ToString(), false);
                dgvReturn.DataSource = flightDetailBUL.getFlightReturn(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), txtOutbound.Text.ToString(), txtReturn.Text.ToString(), true);
            }
            else
            {
                dgvOutbound.DataSource = flightDetailBUL.getFlight(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), txtOutbound.Text.ToString(), false);
            }
        }

        private void dgvOutbound_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int id = Convert.ToInt32(dgvOutbound.Rows[row].Cells[0].Value);
            idScheduleOutBound = id;
            int numperson = flightDetailBUL.getPassengerFromSchedule(id);
            txtNumberPassenger.Text = numperson + "";
        }

        private void dgvReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            int id = Convert.ToInt32(dgvReturn.Rows[row].Cells[0].Value);
            idScheduleReturn = id;
            int numperson = flightDetailBUL.getPassengerFromSchedule(id);
            txtNumberPassenger.Text = numperson + "";
        }
    }
}
