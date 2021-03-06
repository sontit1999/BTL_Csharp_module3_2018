﻿using module3.BULs;
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
        public string totalMoney { get; set; }
        public int idCabintype { get; set; }
        FlightDetailDTO flightOutbound;
        FlightDetailDTO flightReturn;  
        FlightDetailBUL flightDetailBUL = new FlightDetailBUL();
        CabinTypesBUL CabinTypesBUL = new CabinTypesBUL();
        CountryBUL countryBUL = new CountryBUL();
        TicketBUL ticketBUL = new TicketBUL();
        List<PassengersDTO> listPassenger ;
        int numberPassengers;
        int indexPassengerRemove;
       
      
        public BookingConfirmForm()
        {
            InitializeComponent();
            listPassenger = new List<PassengersDTO>();
        }
        public BookingConfirmForm(FlightDetailDTO flyOutbound, FlightDetailDTO flyReturn,int numberPassenger,int IDcabin)
        {
            InitializeComponent();
            listPassenger = new List<PassengersDTO>();

            this.flightOutbound = flyOutbound;
            this.flightReturn = flyReturn;
            this.numberPassengers = numberPassenger;
            this.idCabintype = IDcabin;
            // set label

            // get name cabin 
            string nameCabin = CabinTypesBUL.getNameCabinTypeFromID(idCabintype);

            if (flyReturn == null)
            {
                // ẩn schedule return
                lbFromReturn.Hide();
                lbToReturn.Hide();
                lbCabintypeReturn.Hide();
                lbDateReturn.Hide();
                lbFlightReturn.Hide();
                label12.Hide();
                label13.Hide();
                label15.Hide();
                label17.Hide();
                label19.Hide();
                label21.Hide();
            }
            else
            {
                lbFromReturn.Text = flightReturn.From;
                lbToReturn.Text = flightReturn.To;
                lbCabintypeReturn.Text = nameCabin ;
                lbDateReturn.Text = flightReturn.Date;
                lbFlightReturn.Text = flightReturn.flightNumber;
            }
           
           //set labe
            lbFromOutbound.Text = flightOutbound.From;
            lbToOutbound.Text = flightOutbound.To;
            lbDateOutbound.Text = flightOutbound.Date;
            lbCabintypeOutbound.Text = nameCabin;
            lbFlightnumberOutbound.Text = flightOutbound.flightNumber;


            // tính tổng tiền
            if (flightReturn != null)
            {
                double tongtien = (double.Parse(flightOutbound.cabinPrice) + double.Parse(flightReturn.cabinPrice)) * numberPassengers;
                totalMoney = tongtien.ToString();
            }
            else
            {
                double tongtien = (double.Parse(flightOutbound.cabinPrice)) * numberPassengers;
                totalMoney = tongtien.ToString();
            }

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BookingConfirmForm_Load(object sender, EventArgs e)
        {
            cbPassportCountry.DataSource = countryBUL.getCountry();
            cbPassportCountry.DisplayMember = "Name";
            cbPassportCountry.ValueMember = "ID";

            // custom datetime picker
            dateTimePickerBirthday.CustomFormat = "dd/MM/yyyy";

            // set default time
            dateTimePickerBirthday.Value = new DateTime(1999, 10, 06);
            
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
            if (listPassenger.Count >= numberPassengers)
            {
                MessageBox.Show("Đã thêm đủ passenger!");
            }
            else
            {
                if (txtFirstname.Text.Equals("") || txtLastname.Text.Equals("") || txtPassportNumber.Text.Equals("") || txtPhonenumber.Text.Equals(""))
                {
                    MessageBox.Show("Không được bỏ trống trường nào !!!");
                }
                else
                {
                  
                     int idpasscountry = countryBUL.getIDCountryFromName(cbPassportCountry.Text);
                     string name = countryBUL.getNameCountryFromID(idpasscountry);
                     PassengersDTO passengerDTO = new PassengersDTO(txtFirstname.Text, txtLastname.Text, dateTimePickerBirthday.Value.ToString("MM/dd/yyyy"), txtPassportNumber.Text, cbPassportCountry.Text, txtPhonenumber.Text,idpasscountry);
                    // MessageBox.Show("Id country add  = " + passengerDTO.IDCountry);
                     listPassenger.Add(passengerDTO);
                     MessageBox.Show("Đã thêm passenger");

                     clearField();
                     hienthiPassenger();
                    
                }
            }

        }

        private void clearField()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtPassportNumber.Text = "";
            txtPhonenumber.Text = "";
            
        }

        public void hienthiPassenger()
        {
            dgvPassenger.Rows.Clear();
            dgvPassenger.ColumnCount = 6;

            int i = 0;
            foreach(PassengersDTO item in listPassenger)
            {
                dgvPassenger.Rows.Add();
                dgvPassenger.Rows[i].Cells[0].Value = item.FirstName;
                dgvPassenger.Rows[i].Cells[1].Value = item.LastName;
                dgvPassenger.Rows[i].Cells[2].Value = item.Birthday;
                dgvPassenger.Rows[i].Cells[3].Value = item.PassportNumber;
                dgvPassenger.Rows[i].Cells[4].Value = item.PassporCountry;
                dgvPassenger.Rows[i].Cells[5].Value = item.Phone;
                i++;
            }


        }

        private void dgvPassenger_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            indexPassengerRemove = row;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (indexPassengerRemove >= 0 && listPassenger.Count >=1)
            {
                if (indexPassengerRemove < listPassenger.Count) {
                    DialogResult result = MessageBox.Show("Xóa passenger!!", "Bạn có chắc muốn xóa " + listPassenger[indexPassengerRemove].FirstName + " hay không?", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        listPassenger.RemoveAt(indexPassengerRemove);
                        hienthiPassenger();
                    }
                }
               
                
            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if(numberPassengers == listPassenger.Count)
            {
                BillingConfirmation billingConfirmation = new BillingConfirmation(totalMoney);
                billingConfirmation.setBookingForm(this);
                billingConfirmation.Show();
            }
            else
            {
                MessageBox.Show("Hãy thêm đủ " + numberPassengers + " passengers");

            }
            
           // datve();
        }

        private void txtPassportNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPassportNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPassportNumber.Text = txtPassportNumber.Text.Remove(txtPassportNumber.Text.Length - 1);
            }
        }

        private void txtPhonenumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhonenumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPhonenumber.Text = txtPhonenumber.Text.Remove(txtPhonenumber.Text.Length - 1);
            }
        }
        public void datve()
        {

            // duyệt từng pasenger xong đặt vé cho đi hoặc cả đi và về cho từng  passenger
            foreach (PassengersDTO item in listPassenger)
            {
              //   đặt vé cho từng passenger
                if (flightReturn != null)
                {
                    // đặt vé 2 chiều 

                    // đặt vé chiều đi
                    string idOutbound = flightOutbound.ID;
                    char[] separator = { '-' };
                    string[] listID = idOutbound.Split(separator);
                    foreach (String i in listID)
                    {
                        TicketDTO ticket = new TicketDTO(Convert.ToInt32(i), idCabintype, item.FirstName, item.LastName, item.Phone, item.PassportNumber, item.IDCountry, getBookingRefrecence());
                        ticketBUL.addTicket(ticket);
                    }
                   
                    // đặt vé chiều về
                    string idReturn = flightReturn.ID;
                    char[] separators = { '-' };
                    string[] listIDReturn = idReturn.Split(separator);
                    foreach (String i in listIDReturn)
                    {
                        TicketDTO ticket = new TicketDTO(Convert.ToInt32(i), idCabintype, item.FirstName, item.LastName, item.Phone, item.PassportNumber, item.IDCountry, getBookingRefrecence());
                        ticketBUL.addTicket(ticket);
                    }
                   
                }
                else
                {
                    // đặt vé chiều đi
                    string id = flightOutbound.ID;
                    char[] separator = { '-' };
                    string[] listID = id.Split(separator);
                    foreach (String i in listID)
                    {
                        TicketDTO ticket = new TicketDTO(Convert.ToInt32(i), idCabintype, item.FirstName, item.LastName, item.Phone, item.PassportNumber, item.IDCountry, getBookingRefrecence());
                        ticketBUL.addTicket(ticket);
                    }
                   
                }
            }

          //  MessageBox.Show("Đặt vé thành công");
        }
        public string getBookingRefrecence()
        {
            Random rnd = new Random();
            string basestring = "QWERTYUIOPASDFGHJKLZXCVBNM";

            string booking = null;
            do
            {
                for (int i = 0; i < 6; i++)
                {
                    int indexRandom = rnd.Next(0, basestring.Length);
                    booking = booking + basestring[indexRandom];
                }
            } while (ticketBUL.checkBookingExist(booking));
            
            return booking;
        }

        private void cbPassportCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtLastname.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Please enter only character.");
                txtLastname.Text = txtLastname.Text.Remove(txtLastname.Text.Length - 1);
            }
            
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFirstname.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Please enter only character.");
                txtFirstname.Text = txtFirstname.Text.Remove(txtFirstname.Text.Length - 1);
            }
        }
    }
}
