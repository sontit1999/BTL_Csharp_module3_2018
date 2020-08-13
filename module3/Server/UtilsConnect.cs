using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace module3.Server
{
    class UtilsConnect
    {
        static SqlConnection con;
        static string connectString = @"Data Source=DESKTOP-CMEJ8G1\SQLEXPRESS;Initial Catalog=btl;Integrated Security=True";
        public UtilsConnect()
        {
            con = new SqlConnection(connectString);
            if (con != null)
            {
                MessageBox.Show("Thành công!");
            }
            else
            {
                MessageBox.Show("fail!");
            }
        }
        public static void openConnect()
        {
            con.Open();
        }
        public static void closeConnect()
        {
            con.Close();
        }
        public static SqlConnection getConnection()
        {
            con = new SqlConnection(connectString);
            return con;
        }
    }
}
