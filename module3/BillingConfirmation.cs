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
    public partial class BillingConfirmation : Form
    {
        BookingConfirmForm bookingConfirm;
        public BillingConfirmation()
        {
            InitializeComponent();

        }
        public BillingConfirmation(string totalMonney)
        {
            InitializeComponent();
            lbTotalmoney.Text = "$" + totalMonney ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã đặt vé thành công!");
            bookingConfirm.Close();
            Close();
        }
        public void setBookingForm(BookingConfirmForm booking)
        {
            bookingConfirm = booking;
        }
    }
}
