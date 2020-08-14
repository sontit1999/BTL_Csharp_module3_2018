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
        double tiendi = 0;
        double tienve = 0;
        string idScheduleOutBound;
        string idScheduleReturn;
        string flighnumberOutbound;
        string dateOutbound;
        string flighnumberReturn;
        string dateReturn;
        bool isHiddenReturn = true;
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
                isHiddenReturn = true;
                idScheduleReturn = null;
               
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
             MessageBox.Show("booking : " + idScheduleOutBound + " - " + idScheduleReturn);
             MessageBox.Show("Tiền đi :" + tiendi + " , Tiên về = "+ tienve);
            
            if (isHiddenReturn)
            {   
                if (idScheduleOutBound == null)
                {
                    MessageBox.Show("Phải chọn vé thì mới đặt dc ^^ !!");
                }
                else
                {
                    MessageBox.Show(" ID cbintype"+ Convert.ToInt32(cbCabintype.SelectedValue));
                    BookingConfirmForm booking = new BookingConfirmForm(idScheduleOutBound, idScheduleReturn, Convert.ToInt32(cbCabintype.SelectedValue),cbFrom.Text, cbTo.Text,flighnumberOutbound,dateOutbound,flighnumberReturn,dateReturn);
                    booking.totalMoney = (tienve + tiendi).ToString();
                    booking.Show();
                }
            }
            else
            {
                if (idScheduleOutBound == null || idScheduleReturn == null)
                {
                    MessageBox.Show("Phải chọn vé đi và về thì mới đặt dc ^^ !!");
                }
                else
                {
                    BookingConfirmForm booking = new BookingConfirmForm(idScheduleOutBound, idScheduleReturn, Convert.ToInt32(cbCabintype.SelectedValue), cbFrom.Text, cbTo.Text, flighnumberOutbound,dateOutbound, flighnumberReturn, dateReturn);
                    booking.totalMoney = (tienve + tiendi).ToString();
                    booking.Show();
                }
            }
                
             
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            timkiem();
        }
        bool checkDayValidate()
        {
            if (txtOutbound.Text.CompareTo(txtReturn.Text) < 0)
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
                // check ngay ve có sau ngày đi hay ko
                if (checkDayValidate())
                {
                    if (checkBoxOutbound.Checked)
                    {
                        dgvOutbound.DataSource = flightDetailBUL.getFlightThreeDays(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), txtOutbound.Text.ToString(), false);
                    }
                    else
                    {
                        dgvOutbound.DataSource = flightDetailBUL.getFlight(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), txtOutbound.Text.ToString(), false);
                    }
                    if (checkboxReturn.Checked)
                    {
                        dgvReturn.DataSource = flightDetailBUL.getFlightThreeDays(Convert.ToInt32(cbTo.SelectedValue), Convert.ToInt32(cbFrom.SelectedValue), txtReturn.Text.ToString(), false);

                    }
                    else
                    {
                        dgvReturn.DataSource = flightDetailBUL.getFlight(Convert.ToInt32(cbTo.SelectedValue), Convert.ToInt32(cbFrom.SelectedValue), txtReturn.Text.ToString(), false);
                    }
                }
                else
                {
                    MessageBox.Show("Ngày về phải sau ngày đi!!!");
                }
                
                // dgvOutbound.DataSource = flightDetailBUL.getFlight(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), txtOutbound.Text.ToString(),false);
                //  dgvReturn.DataSource = flightDetailBUL.getFlight( Convert.ToInt32(cbTo.SelectedValue), Convert.ToInt32(cbFrom.SelectedValue),txtReturn.Text.ToString(),false);
            }
            else
            {
                if (checkBoxOutbound.Checked)
                {
                    dgvOutbound.DataSource = flightDetailBUL.getFlightThreeDays(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), txtOutbound.Text.ToString(), false);
                }
                else
                {
                    dgvOutbound.DataSource = flightDetailBUL.getFlight(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), txtOutbound.Text.ToString(), false);
                }

                //  dgvOutbound.DataSource = flightDetailBUL.getFlight(Convert.ToInt32(cbFrom.SelectedValue), Convert.ToInt32(cbTo.SelectedValue), txtOutbound.Text.ToString(), false);
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
                dgvReturn.DataSource = flightDetailBUL.getFlightThreeDays(Convert.ToInt32(cbTo.SelectedValue), Convert.ToInt32(cbFrom.SelectedValue), txtReturn.Text.ToString(), false);
                
            }
            else
            {
                dgvReturn.DataSource = flightDetailBUL.getFlight(Convert.ToInt32(cbTo.SelectedValue), Convert.ToInt32(cbFrom.SelectedValue), txtReturn.Text.ToString(), false);            
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
            string id = dgvOutbound.Rows[row].Cells[0].Value.ToString();
            idScheduleOutBound = id;
            flighnumberOutbound = dgvOutbound.Rows[row].Cells[5].Value.ToString();
            dateOutbound = dgvOutbound.Rows[row].Cells[3].Value.ToString();
            tiendi = double.Parse(dgvOutbound.Rows[row].Cells[6].Value.ToString());
            // int numperson = flightDetailBUL.getPassengerFromSchedule(id);
            //  txtNumberPassenger.Text = numperson + "";
        }

        private void dgvReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            string id = dgvReturn.Rows[row].Cells[0].Value.ToString();
            idScheduleReturn = id;
            flighnumberReturn = dgvReturn.Rows[row].Cells[5].Value.ToString();
            dateReturn = dgvReturn.Rows[row].Cells[3].Value.ToString();
            tienve= double.Parse(dgvReturn.Rows[row].Cells[6].Value.ToString());
            // int numperson = flightDetailBUL.getPassengerFromSchedule(id);
            //  txtNumberPassenger.Text = numperson + "";
        }

        private void cbCabintype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCabintype_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
