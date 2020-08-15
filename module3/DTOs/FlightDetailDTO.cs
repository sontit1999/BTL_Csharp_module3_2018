using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3.DTOs
{
    public class FlightDetailDTO
    {
        public string ID { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string flightNumber { get; set; }
        public string  cabinPrice { get; set; }
        public int numberOfStop { get; set; }
        public FlightDetailDTO()
        {

        }
        public FlightDetailDTO(string fr,string to , string date,string time,string fn,string carbin,int numstop)
        {
            this.From = fr;
            this.To = to;
            this.Date = date;
            this.Time = time;
            this.flightNumber = fn;
            this.cabinPrice = carbin;
            this.numberOfStop = numstop;
        }
        public double getRealPrice(int idCabin)
        {
            double price = 0;
            if(idCabin == 1)
            {
                price = Convert.ToDouble(cabinPrice);
            }
            if (idCabin == 2)
            {
                price = Convert.ToDouble(cabinPrice) * 1.35;
            }
            if (idCabin == 3)
            {
                price = Convert.ToDouble(cabinPrice)*1.35*1.3;
            }
            return price;
        }
    }
}
