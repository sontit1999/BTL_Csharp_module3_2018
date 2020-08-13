using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3.DTOs
{
    class FlightDetailDTO
    {
        public int ID { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int flightNumber { get; set; }
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
            this.flightNumber = Convert.ToInt32(fn);
            this.cabinPrice = carbin;
            this.numberOfStop = numstop;
        }
    }
}
