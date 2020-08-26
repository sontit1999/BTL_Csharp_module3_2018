using module3.DALs;
using module3.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace module3.BULs
{
    class FlightDetailBUL
    {
        FlightDetailDAL flightDetailDAL = new FlightDetailDAL();
        public List<FlightDetailDTO> getFlight(int idAirportFrom, int idAirportTo, string date)
        {
            List<FlightDetailDTO> listtong = flightDetailDAL.getFlight(idAirportFrom, idAirportTo, date);
            List<FlightDetailDTO> listnoi = getTuyenNoi(idAirportFrom, idAirportTo, date);
            listtong.AddRange(listnoi);
            return listtong;
        }
        public List<FlightDetailDTO> getFlightThreeDays(int idAirportFrom, int idAirportTo, string date)
        {
            List<FlightDetailDTO> listtong = flightDetailDAL.getFlightThreeDays(idAirportFrom, idAirportTo, date);
            List<FlightDetailDTO> listnoi = getTuyenNoiTHreeDay(idAirportFrom, idAirportTo, date);
            listtong.AddRange(listnoi);
            return listtong;
           
        }
        // get all schedule
        public List<FlightDetailDTO> getAllFlight()
        {
           
            return flightDetailDAL.getAllFlight();
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
      
        public void displayFlightToDGV(List<FlightDetailDTO> list,DataGridView dgv,int idCbinprice)
        {
            CaculatePriceFlightByCabintype(list, idCbinprice);
            dgv.Rows.Clear();
     
            dgv.ColumnCount = 7;

            int i = 0;
            dgv.Rows.Add();
            dgv.Rows[i].Cells[0].Value = "From";
            dgv.Rows[i].Cells[1].Value = "To";
            dgv.Rows[i].Cells[2].Value = "Date";
            dgv.Rows[i].Cells[3].Value = "Time";
            dgv.Rows[i].Cells[4].Value = "Flight number";
            dgv.Rows[i].Cells[5].Value = "Cabin Price";
            dgv.Rows[i].Cells[6].Value = "Number of stop";
            i++;
            foreach (FlightDetailDTO item in list)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = item.From;
                dgv.Rows[i].Cells[1].Value = item.To;
                dgv.Rows[i].Cells[2].Value = item.Date;
                dgv.Rows[i].Cells[3].Value = item.Time;
                dgv.Rows[i].Cells[4].Value = item.flightNumber;
                dgv.Rows[i].Cells[5].Value = item.cabinPrice;
                dgv.Rows[i].Cells[6].Value = item.numberOfStop;
                i++;
            }
        }
        public void CaculatePriceFlightByCabintype(List<FlightDetailDTO> list , int idCabintype)
        {
            if(idCabintype == 1)
            {
                // gía không đổi
                

            }else if (idCabintype == 2)
            {
                // đắt hơn 35% economy
                foreach (FlightDetailDTO item in list)
                {
                    double giabandau = double.Parse(item.cabinPrice);
                    giabandau = giabandau * 1.35;
                    item.cabinPrice = giabandau.ToString();
                }
            }
            else if(idCabintype == 3)
            {
                // đắt hơn 30 % bussiness
                foreach (FlightDetailDTO item in list)
                {
                    double giabandau = double.Parse(item.cabinPrice);
                    giabandau = giabandau * 1.35*1.3;
                    item.cabinPrice = giabandau.ToString();
                }
            }
        }
        // function get số ghế theo loại cabin đã đặt trong chuyến bay x
        public int getNumberCabintypeSeatbookInschedule(int idSchedule, int idCabintype)
        {   
            return flightDetailDAL.getNumberCabintypeSeatbookInschedule(idSchedule,idCabintype);
        }
    }
}
