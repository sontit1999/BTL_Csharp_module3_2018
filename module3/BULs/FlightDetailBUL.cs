using module3.DALs;
using module3.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3.BULs
{
    class FlightDetailBUL
    {
        FlightDetailDAL flightDetailDAL = new FlightDetailDAL();
        public List<FlightDetailDTO> getFlight(int idAirportFrom, int idAirportTo, string date, bool isReturn)
        {
            List<FlightDetailDTO> listtong = flightDetailDAL.getFlight(idAirportFrom, idAirportTo, date, isReturn);
            List<FlightDetailDTO> listnoi =   getTuyenNoi(idAirportFrom, idAirportTo, date);
            foreach(FlightDetailDTO i in listnoi)
            {
                listtong.Add(i);
            }
            return listtong;
            //return listtong;
        }
        public List<FlightDetailDTO> getFlightThreeDays(int idAirportFrom, int idAirportTo, string date, bool isReturn)
        {
            List<FlightDetailDTO> listtong = flightDetailDAL.getFlightThreeDays(idAirportFrom, idAirportTo, date, isReturn);
            List<FlightDetailDTO> listnoi = getTuyenNoiTHreeDay(idAirportFrom, idAirportTo, date);
            foreach (FlightDetailDTO i in listnoi)
            {
                listtong.Add(i);
            }
            return listtong;
           // return flightDetailDAL.getFlightThreeDays(idAirportFrom, idAirportTo, date,isReturn);
        }
        public int getPassengerFromSchedule(int idSchedule)
        {
            
            return flightDetailDAL.getPassengerFromSchedule(idSchedule);
        }
        public FlightDetailDTO getFilghDetailFromIDschedule(int idschedule)
        {         
            return flightDetailDAL.getFilghDetailFromIDschedule(idschedule);
        }
        public List<FlightDetailDTO> getFlightReturn(int idAirportFrom, int idAirportTo, string dateOutbound, string dateReturn, bool isReturn)
        {
            
            return flightDetailDAL.getFlightReturn(idAirportFrom,idAirportTo,dateOutbound,dateReturn,true);
        }
        public List<FlightDetailDTO> getTuyenNoi(int idFrom,int idTo, string date) 
        {
            List<FlightDetailDTO> listTong = new List<FlightDetailDTO>();
            
            // list from A
            List<FlightDetailDTO> listFrom = flightDetailDAL.getFlightFrom(idFrom,date);

            // list to B
            List<FlightDetailDTO> listTo = flightDetailDAL.getFlightTo(idTo, date);

            foreach(FlightDetailDTO i in listFrom)
            {
                foreach(FlightDetailDTO j in listTo)
                {
                    if (i.To.Equals(j.From) && string.Compare(i.Date,j.Date)<0 ) {
                        string price = (double.Parse(i.cabinPrice) + double.Parse(j.cabinPrice)).ToString();
                        FlightDetailDTO newFligt = new FlightDetailDTO(i.From,j.To,i.Date,i.Time,i.flightNumber+"-"+j.flightNumber,price,1);
                        newFligt.ID = i.ID + "-" + j.ID;
                        listTong.Add(newFligt);
                    }
                }
            }
            return listTong;
        }
        public List<FlightDetailDTO> getTuyenNoiTHreeDay(int idFrom, int idTo, string date)
        {
            List<FlightDetailDTO> listTong = new List<FlightDetailDTO>();

            // list from A
            List<FlightDetailDTO> listFrom = flightDetailDAL.getFlightFromThreeday(idFrom, date);

            // list to B
            List<FlightDetailDTO> listTo = flightDetailDAL.getFlightToThreeday(idTo, date);

            foreach (FlightDetailDTO i in listFrom)
            {
                foreach (FlightDetailDTO j in listTo)
                {
                    if (i.To.Equals(j.From) && string.Compare(i.Date, j.Date) < 0)
                    {
                        string price = (double.Parse(i.cabinPrice) + double.Parse(j.cabinPrice)).ToString();
                        FlightDetailDTO newFligt = new FlightDetailDTO(i.From, j.To, i.Date, i.Time, i.flightNumber + "-" + j.flightNumber, price, 1);
                        newFligt.ID = i.ID + "-" + j.ID;
                        listTong.Add(newFligt);
                    }
                }
            }
            return listTong;
        }
        public double getPriceFromIDschedule(int idschedule)
        {
            return flightDetailDAL.getPriceFromIDschedule(idschedule);

        }
    }
}
