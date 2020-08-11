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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
            /*
            string connectString = @"Data Source=DESKTOP-CMEJ8G1\SQLEXPRESS;Initial Catalog=btl;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectString);
            if (con != null)
            {
                MessageBox.Show("Thành công!");
            }
            else
            {
                MessageBox.Show("fail!");
            }
            string sqlQuerry = "select * from CabinTypes";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuerry, con);
            SqlDataReader dr =  cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dataGridView1.DataSource = dt;
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookingConfirmForm booking = new BookingConfirmForm();
            booking.Show();
        }
    }
}
