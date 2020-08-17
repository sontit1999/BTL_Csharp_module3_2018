using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3.DTOs
{
    class TicketDTO
    {
        public int SCheduleID { get; set; }
        public int CabintypeID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string phone { get; set; }
        public string PassportNumber { get; set; }
        public int PassportCountryID { get; set; }
        public string BookingReference { get; set; }
        public TicketDTO()
        {

        }
        public TicketDTO(int IDChedule,int IDcabintype,string fname,string lname,string phoneNumber,string passnumber,int IDPassportCOuntry,string bookReference)
        {
            this.SCheduleID = IDChedule;
            this.CabintypeID = IDcabintype;
            this.Firstname = fname;
            this.Lastname = lname;
            this.phone = phoneNumber;
            this.PassportNumber = passnumber;
            this.PassportCountryID = IDPassportCOuntry;
            this.BookingReference = bookReference;
        }
    }
}
