﻿using module3.DTOs;
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
        // get schedule specific
        public List<FlightDetailDTO> getFlight(int idAirportFrom,int idAirportTo,string date)
        {
            con.Open();
            List<FlightDetailDTO> list = new List<FlightDetailDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where Routes.DepartureAirportID = @from and Routes.ArrivalAirportID = @to and Schedules.Date = @date";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("from", idAirportFrom);
            cmd.Parameters.AddWithValue("to", idAirportTo);

            cmd.Parameters.AddWithValue("date", date);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailDTO flightDetail = new FlightDetailDTO(from, to, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(),dr["FlightNumber"].ToString(),dr["EconomyPrice"].ToString(),0);
                flightDetail.ID = dr["ID"].ToString();
                list.Add(flightDetail);
              
            }

            con.Close();
            return list;
        }

        // get all schedule
        public List<FlightDetailDTO> getAllFlight()
        {
            con.Open();
            List<FlightDetailDTO> list = new List<FlightDetailDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID ";
            SqlCommand cmd = new SqlCommand(sql, con);
           
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailDTO flightDetail = new FlightDetailDTO(from, to, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID = dr["ID"].ToString();
                list.Add(flightDetail);

            }

            con.Close();
            return list;
        }
        
        // get schedule after and before three days
        public List<FlightDetailDTO> getFlightThreeDays(int idAirportFrom, int idAirportTo, string date)
        {
            con.Open();
            List<FlightDetailDTO> list = new List<FlightDetailDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where Routes.DepartureAirportID = @from and Routes.ArrivalAirportID = @to  and Date <= DATEADD(day, 3, @date) AND   Date >= DATEADD(day, -3, @date)";
            SqlCommand cmd = new SqlCommand(sql, con);
            
            
                cmd.Parameters.AddWithValue("from", idAirportFrom);
                cmd.Parameters.AddWithValue("to", idAirportTo);
            
            cmd.Parameters.AddWithValue("date", date);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailDTO flightDetail = new FlightDetailDTO(from, to, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID = dr["ID"].ToString();
                list.Add(flightDetail);

            }

            con.Close();
            return list;
        }
       
        // get flight from A
        public List<FlightDetailDTO> getFlightFrom(int idAirportFrom, string date)
        {
            con.Open();
            List<FlightDetailDTO> list = new List<FlightDetailDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where Routes.DepartureAirportID = @from  and Schedules.Date = @date";
            SqlCommand cmd = new SqlCommand(sql, con);
            
               
          
                cmd.Parameters.AddWithValue("from", idAirportFrom);
               
            

            cmd.Parameters.AddWithValue("date", date);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailDTO flightDetail = new FlightDetailDTO(from, to, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID = dr["ID"].ToString();
                list.Add(flightDetail);

            }

            con.Close();
            return list;
        }
        // get flight to B
        public List<FlightDetailDTO> getFlightTo(int idAirportTo, string date)
        {
            con.Open();
            List<FlightDetailDTO> list = new List<FlightDetailDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where  Routes.ArrivalAirportID = @to and Schedules.Date > @date";
            SqlCommand cmd = new SqlCommand(sql, con);



            cmd.Parameters.AddWithValue("to", idAirportTo);



            cmd.Parameters.AddWithValue("date", date);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailDTO flightDetail = new FlightDetailDTO(from, to, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID = dr["ID"].ToString();
                list.Add(flightDetail);

            }

            con.Close();
            return list;
        }
        public List<FlightDetailDTO> getFlightFromThreeday(int idAirportFrom, string date)
        {
            con.Open();
            List<FlightDetailDTO> list = new List<FlightDetailDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where Routes.DepartureAirportID = @from  and Schedules.Date <= DATEADD(day, 3, @date) AND   Schedules.Date >= DATEADD(day, -3, @date)";
            SqlCommand cmd = new SqlCommand(sql, con);



            cmd.Parameters.AddWithValue("from", idAirportFrom);



            cmd.Parameters.AddWithValue("date", date);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailDTO flightDetail = new FlightDetailDTO(from, to, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID = dr["ID"].ToString();
                list.Add(flightDetail);

            }

            con.Close();
            return list;
        }
        // get flight to B
        public List<FlightDetailDTO> getFlightToThreeday(int idAirportTo, string date)
        {
            con.Open();
            List<FlightDetailDTO> list = new List<FlightDetailDTO>();
            string sql = "select * from Schedules inner join Routes on Schedules.RouteID = Routes.ID where  Routes.ArrivalAirportID = @to and Schedules.Date > @date";
            SqlCommand cmd = new SqlCommand(sql, con);



            cmd.Parameters.AddWithValue("to", idAirportTo);



            cmd.Parameters.AddWithValue("date", date);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string from = airportsDAL.getNameFromCode(Convert.ToInt32(dr["DepartureAirportID"]));
                string to = airportsDAL.getNameFromCode(Convert.ToInt32(dr["ArrivalAirportID"]));
                FlightDetailDTO flightDetail = new FlightDetailDTO(from, to, dr["Date"].ToString().Split(null)[0], dr["Time"].ToString(), dr["FlightNumber"].ToString(), dr["EconomyPrice"].ToString(), 0);
                flightDetail.ID = dr["ID"].ToString();
                list.Add(flightDetail);

            }

            con.Close();
            return list;
        }
       
        // function get số ghế theo loại cabin đã đặt trong chuyến bay x
        public int getNumberCabintypeSeatbookInschedule(int idSchedule,int idCabintype)
        {
            int numberSeat = 0;
            con.Open();
            string sql = "select count(*) as numberseat from Tickets where ScheduleID = @idschedule and CabinTypeID = @idcabin";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("idschedule", idSchedule);
            cmd.Parameters.AddWithValue("idcabin", idCabintype);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                numberSeat = Convert.ToInt32(dr["numberseat"]);
                break;
            }
            con.Close();
            return numberSeat;
        }
    }
}
