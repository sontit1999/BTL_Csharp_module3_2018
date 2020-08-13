using module3.BULs;
using module3.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace module3
{
    public partial class BookingConfirmForm : Form
    {
        FlightDetailDTO flightOutbound;
        FlightDetailDTO flightReturn;
        FlightDetailBUL flightDetailBUL = new FlightDetailBUL();
        List<PassengersDTO> listPassenger = new List<PassengersDTO>();
        public BookingConfirmForm()
        {
            InitializeComponent();
           
        }
        public BookingConfirmForm(int idScheduleOutbound,int idSchedulesReturn)
        {
            InitializeComponent();
            MessageBox.Show("Booking form recive : " + idScheduleOutbound + "->" + idSchedulesReturn);
            flightOutbound = flightDetailBUL.getFilghDetailFromIDschedule(idScheduleOutbound);
            flightReturn = flightDetailBUL.getFilghDetailFromIDschedule(idSchedulesReturn);

            lbFromOutbound.Text = flightOutbound.From;
            lbToOutbound.Text = flightOutbound.To;
            lbDateOutbound.Text = flightOutbound.Date;
            lbFlightnumberOutbound.Text = flightOutbound.flightNumber.ToString();

            lbFromReturn.Text = flightReturn.From;
            lbToReturn.Text = flightReturn.To;
            lbDateReturn.Text = flightReturn.Date;
            lbFlightReturn.Text = flightReturn.flightNumber.ToString();

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BookingConfirmForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddpassenger_Click(object sender, EventArgs e)
        {
            if(txtFirstname.Text.Equals("") || txtLastname.Text.Equals("") || txtBirthday.Text.Equals("") || txtPassportNumber.Text.Equals("") || txtPhonenumber.Text.Equals(""))
            {
                MessageBox.Show("Không được bỏ trống trường nào !!!");
            }
            else
            {
                string passcountry = "124";
                PassengersDTO passengerDTO = new PassengersDTO(txtFirstname.Text, txtLastname.Text, txtBirthday.Text, txtPassportNumber.Text,passcountry, txtPhonenumber.Text);
                listPassenger.Add(passengerDTO);
                hienthiPassenger();
            }

        }
        public void hienthiPassenger()
        {
            dgvPassenger.DataSource = listPassenger;
        }
    }
}
