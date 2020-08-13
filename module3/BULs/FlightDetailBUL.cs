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
            
            return flightDetailDAL.getFlight(idAirportFrom, idAirportTo, date,isReturn);
        }
        public List<FlightDetailDTO> getFlightThreeDays(int idAirportFrom, int idAirportTo, string date, bool isReturn)
        {    
            return flightDetailDAL.getFlightThreeDays(idAirportFrom, idAirportTo, date,isReturn);
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
    }
}
