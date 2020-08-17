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
          
        bool isHiddenReturn = true;
        AirportsBUL airporstBUL = new AirportsBUL();
        CabinTypesBUL cabinTypesBUL = new CabinTypesBUL();
        FlightDetailBUL flightDetailBUL = new FlightDetailBUL();
        AircraftBUL aircraftBUL = new AircraftBUL();
        List<FlightDetailDTO> listUoutBound;
        List<FlightDetailDTO> listReturn;
        FlightDetailDTO flightOutbound;
        FlightDetailDTO flightReturn;
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
            cbTo.SelectedIndex = 2;

            cbCabintype.DataSource = cabinTypesBUL.getCabinType();
            cbCabintype.DisplayMember = "Name";
            cbCabintype.ValueMember = "ID";

            // ngày đi mặc  định


            // load default flight
            listUoutBound = flightDetailBUL.getAllFlight();
            flightDetailBUL.displayFlightToDGV(listUoutBound, dgvOutbound,1);
            //dgvOutbound.DataSource = flightDetailBUL.getAllFlight();

            // custom datetime picker
            dateTimePickerOutbond.CustomFormat = "dd/MM/yyyy";
            dateTimePickerReturn.CustomFormat = "dd/MM/yyyy";
            // set default time
            dateTimePickerOutbond.Value = new DateTime(2018, 10, 10);
            dateTimePickerReturn.Value = new DateTime(2018, 10, 15);
            

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
                isHiddenReturn = true;
                
               
            }
            else
            {
                // Hiển thị list khứ hồi            
                dgvReturn.Show();
                isHiddenReturn = false;
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
           
            
            if (txtNumberPassenger.Text.Equals("")){
                MessageBox.Show("Không dc bỏ trống number passenger !!!");
            }
            else
            {
                if (rbOneWay.Checked)
                {
                    // chỉ có vé đi
                    if (flightOutbound == null)
                    {
                        MessageBox.Show("Chưa chọn chuyến bay. VUi lòng chọn và thử lại!!");
                    }
                    else
                    {

                        if (checkChuyenBayDIConDuChohaykhong())
                        {
                            BookingConfirmForm booking = new BookingConfirmForm(flightOutbound, flightReturn, int.Parse(txtNumberPassenger.Text.ToString()), Convert.ToInt32(cbCabintype.SelectedValue));
                            booking.Show();
                        }
                                          
                    }
                }
                else
                {
                    // cả vé về
                    if (flightOutbound == null)
                    {
                        MessageBox.Show("Chưa chọn vé đi. VUi lòng chọn và thử lại!!");
                    }
                    else if(flightReturn == null)
                    {
                        MessageBox.Show("Chưa chọn vé khứ hồi. VUi lòng chọn và thử lại!!");
                    }
                    else 
                    {
                        bool checkdi = checkChuyenBayDIConDuChohaykhong();
                        bool checkve = checkChuyenBayVeConDuChohaykhong();
                      
                        if ( checkdi && checkve )
                        {
                            BookingConfirmForm booking = new BookingConfirmForm(flightOutbound, flightReturn, int.Parse(txtNumberPassenger.Text.ToString()), Convert.ToInt32(cbCabintype.SelectedValue));
                            booking.Show();
                        }
                       
                    }
                }
               
               
            }
            

        }

        private bool checkChuyenBayDIConDuChohaykhong()
        {   
            // check chuyến đi với số passenger tương ứng xem còn ghế không
            int numberSeat = flightDetailBUL.getNumberCabintypeSeatbookInschedule(Convert.ToInt32(flightOutbound.ID), Convert.ToInt32(cbCabintype.SelectedValue));
           
            AircraftDTO maybay = aircraftBUL.getAircraftFromIDSchedule(Convert.ToInt32(flightOutbound.ID));
            int sogheconlai = 0;
            if (Convert.ToInt32(cbCabintype.SelectedValue) == 1)
            {
                // nếu là economy
                sogheconlai = maybay.EconomySeat - numberSeat;
              
            }
            else if(Convert.ToInt32(cbCabintype.SelectedValue) == 2)
            {
                // nếu là bussiness
                sogheconlai = maybay.BusinessSeat - numberSeat;
              
            }
            else if(Convert.ToInt32(cbCabintype.SelectedValue) == 3)
            {
                // nếu là first class
                sogheconlai = maybay.FirstClassSeat - numberSeat;
               
            }


            if (Convert.ToInt32(txtNumberPassenger.Text) > sogheconlai)
            {   
                if(sogheconlai <= 0)
                {
                    MessageBox.Show("Chuyến bay đi này đã hết  ghế ! VUi lòng chọn chuyến khác!!!");
                }
                else
                {
                    MessageBox.Show("Chuyến bay đi  chỉ còn " + sogheconlai + " ghế !");
                }
               
                return false;
            }
            else
            {
                // chuyển sang xác nhận
                return true;
            }

        }
        private bool checkChuyenBayVeConDuChohaykhong()
        {
            // check chuyến về với số passenger tương ứng xem còn ghế không
            int numberSeat = flightDetailBUL.getNumberCabintypeSeatbookInschedule(Convert.ToInt32(flightReturn.ID), Convert.ToInt32(cbCabintype.SelectedValue));
          
            AircraftDTO maybay = aircraftBUL.getAircraftFromIDSchedule(Convert.ToInt32(flightReturn.ID));
            int sogheconlai = 0;
            if (Convert.ToInt32(cbCabintype.SelectedValue) == 1)
            {
                // nếu là economy
                sogheconlai = maybay.EconomySeat - numberSeat;
               
            }
            else if (Convert.ToInt32(cbCabintype.SelectedValue) == 2)
            {
                // nếu là bussiness
                sogheconlai = maybay.BusinessSeat - numberSeat;
               
            }
            else if (Convert.ToInt32(cbCabintype.SelectedValue) == 3)
            {
                // nếu là first class
                sogheconlai = maybay.FirstClassSeat - numberSeat;
                
            }


            if (Convert.ToInt32(txtNumberPassenger.Text) > sogheconlai)
            {
                if (sogheconlai <= 0)
                {
                    MessageBox.Show("Chuyến bay khứ hồi này đã hết  ghế !VUi lòng chọn chuyến khác!!!");
                }
                else
                {
                    MessageBox.Show("Chuyến bay về  chỉ còn " + sogheconlai + " ghế !");
                }
                return false;
            }
            else
            {
                // chuyển sang xác nhận
                return true;
            }

        }
        private void btnApply_Click(object sender, EventArgs e)
        {
             timkiem();
           
        }
        bool checkDayValidate()
        {
            if (dateTimePickerOutbond.Value.ToString("MM/dd/yyyy").CompareTo(dateTimePickerReturn.Value.ToString("MM/dd/yyyy")) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        private void timkiem()
        {
           
            if (rbReturn.Checked)
            {
                // hai chiều
                // check ngay ve có sau ngày đi hay ko
                if (checkDayValidate())
                {
                    if (checkBoxOutbound.Checked)
                    {
                        listUoutBound = flightDetailBUL.getFlightThreeDays(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), dateTimePickerOutbond.Value.ToString("MM/dd/yyyy"));
                        flightDetailBUL.displayFlightToDGV(listUoutBound, dgvOutbound,Convert.ToInt32(cbCabintype.SelectedValue));
                    }
                    else
                    {
                        listUoutBound = flightDetailBUL.getFlight(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), dateTimePickerOutbond.Value.ToString("MM/dd/yyyy"));
                        flightDetailBUL.displayFlightToDGV(listUoutBound, dgvOutbound, Convert.ToInt32(cbCabintype.SelectedValue));
                    }
                    if (checkboxReturn.Checked)
                    {
                        listReturn = flightDetailBUL.getFlightThreeDays(Convert.ToInt32(cbTo.SelectedValue), Convert.ToInt32(cbFrom.SelectedValue), dateTimePickerReturn.Value.ToString("MM/dd/yyyy"));
                        flightDetailBUL.displayFlightToDGV(listReturn, dgvReturn, Convert.ToInt32(cbCabintype.SelectedValue));
                    }
                    else
                    {
                        listReturn = flightDetailBUL.getFlight(Convert.ToInt32(cbTo.SelectedValue), Convert.ToInt32(cbFrom.SelectedValue), dateTimePickerReturn.Value.ToString("MM/dd/yyyy"));
                        flightDetailBUL.displayFlightToDGV(listReturn, dgvReturn, Convert.ToInt32(cbCabintype.SelectedValue));
                    }
                }
                else
                {
                    MessageBox.Show("Ngày về phải sau ngày đi!!!");
                }
               
            }
            else
            {
                // một chiều
                if (dateTimePickerOutbond.Value.ToString("MM/dd/yyyy").Equals(""))
                {
                    // load default flight
                    listUoutBound = flightDetailBUL.getAllFlight();
                    flightDetailBUL.displayFlightToDGV(listUoutBound, dgvOutbound, Convert.ToInt32(cbCabintype.SelectedValue));
                }
                else
                {
                    if (checkBoxOutbound.Checked)
                    {
                        listUoutBound = flightDetailBUL.getFlightThreeDays(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), dateTimePickerOutbond.Value.ToString("MM/dd/yyyy"));
                        flightDetailBUL.displayFlightToDGV(listUoutBound, dgvOutbound, Convert.ToInt32(cbCabintype.SelectedValue));
                    }
                    else
                    {
                        listUoutBound = flightDetailBUL.getFlight(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), dateTimePickerOutbond.Value.ToString("MM/dd/yyyy"));
                        flightDetailBUL.displayFlightToDGV(listUoutBound, dgvOutbound, Convert.ToInt32(cbCabintype.SelectedValue));
                    }
                }
                

                
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDisplayOutbound_CheckedChanged(object sender, EventArgs e)
        {
            timkiem();
        }

        private void checkboxReturn_CheckedChanged(object sender, EventArgs e)
        {
            timkiem();
           
        }

        private void rbReturn_CheckedChanged(object sender, EventArgs e)
        {
            timkiem();
        }

        private void dgvOutbound_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if(row >= 1)
            {
                flightOutbound = listUoutBound[row - 1];
                MessageBox.Show("id chedule = " + flightOutbound.ID + " from  " + flightOutbound.From + " to " + flightOutbound.To + ",date:  " + flightOutbound.Date + " , price :" + flightOutbound.cabinPrice + ",Flightnumber = " + flightOutbound.flightNumber);
            }

        }

        private void dgvReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 1)
            {
                flightReturn = listReturn[row - 1];
                MessageBox.Show("id chedule = " + flightReturn.ID + " from  " + flightReturn.From + " to " + flightReturn.To + ",date:  " + flightReturn.Date + " , price :" + flightReturn.cabinPrice + ",Flightnumber = " + flightReturn.flightNumber);
            }

        }

        private void cbCabintype_SelectedIndexChanged(object sender, EventArgs e)
        {
           // timkiem();
        }

        private void cbCabintype_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNumberPassenger_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNumberPassenger.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtNumberPassenger.Text = txtNumberPassenger.Text.Remove(txtNumberPassenger.Text.Length - 1);
            }
        }
    }
}
