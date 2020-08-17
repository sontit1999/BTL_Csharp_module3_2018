using module3.DTOs;
using module3.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3.DALs
{
    class TicketDAL
    {
        SqlConnection con;
        public TicketDAL()
        {
            con = UtilsConnect.getConnection();
        }
        public void addTicket(TicketDTO ticket)
        {
            con.Open();
            string sql = "INSERT INTO Tickets(UserID,ScheduleID,CabinTypeID,Firstname,Lastname,Phone,PassportNumber,PassportCountryID,BookingReference,Confirmed) VALUES (1, @scheduleID, @CabinID, @fname, @lname, @phone, @passnumber, @IDcountry, @book, 1)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("scheduleID", ticket.SCheduleID);
            cmd.Parameters.AddWithValue("CabinID", ticket.CabintypeID);
            cmd.Parameters.AddWithValue("fname", ticket.Firstname);
            cmd.Parameters.AddWithValue("lname", ticket.Lastname);
            cmd.Parameters.AddWithValue("phone", ticket.phone);
            cmd.Parameters.AddWithValue("passnumber", ticket.PassportNumber);
            cmd.Parameters.AddWithValue("IDcountry", ticket.PassportCountryID);
            cmd.Parameters.AddWithValue("book", ticket.BookingReference);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public bool checkBookingExist(string booking)
        {
            string bookingReference = null;
            con.Open();
            string sql = "select BookingReference from Tickets where BookingReference = @book";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("book", booking);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bookingReference = dr["BookingReference"].ToString();
                break;

            }
            con.Close();
            if (bookingReference == null)
            {
                return false;
            }
            else
            {
                return true; 
            }
        }
    }
}
