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
        public string totalMoney { get; set; }
        FlightDetailDTO flightOutbound;
        FlightDetailDTO flightReturn;
        string idScheduleOutbound;
        string idSchedulesReturn;
        FlightDetailBUL flightDetailBUL = new FlightDetailBUL();
        CabinTypesBUL CabinTypesBUL = new CabinTypesBUL();
        CountryBUL countryBUL = new CountryBUL();
        List<PassengersDTO> listPassenger ;
        int idCabintype =-1;
        int indexPassengerRemove = -1;
        public BookingConfirmForm()
        {
            InitializeComponent();
            listPassenger = new List<PassengersDTO>();
        }
        
        public BookingConfirmForm(string idScheduleOutbound,string idSchedulesReturn,int idCabin,string from,string to,string flightnumberOutbound,string dateOutbound, string flightnumberReturn, string dateReturn)
        {
            


            InitializeComponent();

            this.idScheduleOutbound = idScheduleOutbound;
            this.idSchedulesReturn = idSchedulesReturn;

            // set label

            lbFromOutbound.Text = from;
            lbToOutbound.Text = to;
            lbFlightnumberOutbound.Text = flightnumberOutbound;
            lbDateOutbound.Text = dateOutbound;


            MessageBox.Show("idcabind recive : " + idCabin);
            idCabintype = idCabin;
            string nameCbintype = CabinTypesBUL.getNameCabinTypeFromID(idCabintype);
            lbCabintypeOutbound.Text = nameCbintype;
            lbCabintypeReturn.Text = nameCbintype;
          //  lbCabintypeReturn.Text = nameCbintype;
           
            listPassenger = new List<PassengersDTO>();
            MessageBox.Show("id schecdule outbound: " + idScheduleOutbound);
            
            if (idSchedulesReturn != null)
            {
               // flightReturn = flightDetailBUL.getFilghDetailFromIDschedule(Convert.ToInt32(idSchedulesReturn));
                lbFromReturn.Text = to;
                lbToReturn.Text = from;
                lbDateReturn.Text = dateReturn;
                lbFlightReturn.Text = flightnumberReturn;
            }
            else
            {
                MessageBox.Show("ko có vé khứ hồi");
                // ẩn view
                lbDateReturn.Hide();
                lbFlightReturn.Hide();
                lbFromReturn.Hide();
                lbToReturn.Hide();
                lbCabintypeReturn.Hide();
                label12.Hide();
                label13.Hide();
                label15.Hide();
                label17.Hide();
                label19.Hide();
                label21.Hide();
            }
           
            // flightOutbound = flightDetailBUL.getFilghDetailFromIDschedule(Convert.ToInt32(idScheduleOutbound));
           
           
            /*
           
            //MessageBox.Show("Giá tiền outbound :" + flightOutbound.getRealPrice(idCabintype));
            lbCabintypeOutbound.Text = nameCbintype;
            lbFromOutbound.Text = flightOutbound.From;
            lbToOutbound.Text = flightOutbound.To;
            lbDateOutbound.Text = flightOutbound.Date;
            lbFlightnumberOutbound.Text = flightOutbound.flightNumber.ToString();
             */


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
               
                int idpasscountry = Convert.ToInt32(cbPassportCountry.SelectedValue);
                string name = countryBUL.getNameCountryFromID(idpasscountry);
                PassengersDTO passengerDTO = new PassengersDTO(txtFirstname.Text, txtLastname.Text, txtBirthday.Text, txtPassportNumber.Text,cbPassportCountry.Text, txtPhonenumber.Text);
                passengerDTO.IDCountry = idpasscountry;
                listPassenger.Add(passengerDTO);            
                MessageBox.Show("Đã thêm passenger");
                hienthiPassenger();
            }

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
            indexPassengerRemove = e.RowIndex;
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (indexPassengerRemove >= 0)
            {
                listPassenger.RemoveAt(indexPassengerRemove);
                hienthiPassenger();
            }
            else
            {
                MessageBox.Show("Chọn passenger muốn xóa");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đặt vé có schdule id " + idScheduleOutbound + " và " + idSchedulesReturn);
            char[] speparator = { '-' };
            string[] listIDOutBound = idScheduleOutbound.Split(speparator);
            foreach(string i in listIDOutBound)
            {
                MessageBox.Show("ID: " + i);
            }
            
          
            MessageBox.Show("Tổng tiền  = " +totalMoney);
            BillingConfirmation billingConfirmation = new BillingConfirmation(totalMoney);
            billingConfirmation.setBookingForm(this);
            billingConfirmation.Show();
        }
    }
}
