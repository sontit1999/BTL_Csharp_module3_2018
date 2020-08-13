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
    class FlightDetailDAL
    {
        SqlConnection con;
        AirportsDAL airportsDAL = new AirportsDAL();

        public FlightDetailDAL()
        {
             con = UtilsConnect.getConnection();
        }
        public List<FlightDetailDTO> getFlight(int idAirportFrom,int idAirportTo,string date,bool isReturn)
        {
            con.Open();
            List<FlightDetailDTO> list = new List<FlightDetailDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where Routes.DepartureAirportID = @from and Routes.ArrivalAirportID = @to and Schedules.Date >= @date";
            SqlCommand cmd = new SqlCommand(sql, con);
            if (isReturn)
            {
                cmd.Parameters.AddWithValue("from", idAirportTo );
                cmd.Parameters.AddWithValue("to", idAirportFrom);
            }
            else
            {
                cmd.Parameters.AddWithValue("from", idAirportFrom );
                cmd.Parameters.AddWithValue("to", idAirportTo);
            }
           
            cmd.Parameters.AddWithValue("date", date);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailDTO flightDetail = new FlightDetailDTO(from, to, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(),dr["FlightNumber"].ToString(),dr["EconomyPrice"].ToString(),0);
                flightDetail.ID = Convert.ToInt32(dr["ID"]);
                list.Add(flightDetail);
              
            }

            con.Close();
            return list;
        }

        public List<FlightDetailDTO> getFlightReturn(int idAirportFrom, int idAirportTo, string dateOutbound,string dateReturn, bool isReturn)
        {
            con.Open();
            List<FlightDetailDTO> list = new List<FlightDetailDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where Routes.DepartureAirportID = @from and Routes.ArrivalAirportID = @to and Schedules.Date >= @dateOutbound and Schedules.Date >= @dateReturn ";
            SqlCommand cmd = new SqlCommand(sql, con);
            if (isReturn)
            {
                cmd.Parameters.AddWithValue("from", idAirportTo);
                cmd.Parameters.AddWithValue("to", idAirportFrom);
            }
            else
            {
                cmd.Parameters.AddWithValue("from", idAirportFrom);
                cmd.Parameters.AddWithValue("to", idAirportTo);
            }

            cmd.Parameters.AddWithValue("dateOutbound", dateOutbound);
            cmd.Parameters.AddWithValue("dateReturn", dateReturn);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailDTO flightDetail = new FlightDetailDTO(from, to, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID = Convert.ToInt32(dr["ID"]);
                list.Add(flightDetail);

            }

            con.Close();
            return list;
        }

        public List<FlightDetailDTO> getFlightThreeDays(int idAirportFrom, int idAirportTo, string date, bool isReturn)
        {
            con.Open();
            List<FlightDetailDTO> list = new List<FlightDetailDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where Routes.DepartureAirportID = @from and Routes.ArrivalAirportID = @to  and Date <= DATEADD(day, 3, @date) AND   Date >= DATEADD(day, -3, @date)";
            SqlCommand cmd = new SqlCommand(sql, con);
            if (isReturn)
            {
                cmd.Parameters.AddWithValue("from", idAirportTo);
                cmd.Parameters.AddWithValue("to", idAirportFrom);
            }
            else
            {
                cmd.Parameters.AddWithValue("from", idAirportFrom);
                cmd.Parameters.AddWithValue("to", idAirportTo);
            }
            cmd.Parameters.AddWithValue("date", date);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailDTO flightDetail = new FlightDetailDTO(from, to, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID = Convert.ToInt32(dr["ID"]);
                list.Add(flightDetail);

            }

            con.Close();
            return list;
        }
        public int getPassengerFromSchedule(int idSchedule)
        {
            int numberPassenger = 0;
            con.Open();
            string sql = "select count(*) as 'songuoi' from Tickets where ScheduleID = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idSchedule);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                numberPassenger = Convert.ToInt32(dr["songuoi"]);
                break;
            }
            con.Close();
            return numberPassenger;
        }
        public FlightDetailDTO getFilghDetailFromIDschedule(int idschedule)
        {
            FlightDetailDTO flightDetail = null;
            con.Open();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where Schedules.ID = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idschedule);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                flightDetail = new FlightDetailDTO(from, to, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID = Convert.ToInt32(dr["ID"]);
              
                break;
            }
            con.Close();
            return flightDetail;
        }
    }
}
