using module3.DALs;
using module3.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3.BULs
{
    class TicketBUL
    {
        TicketDAL ticketDAL = new TicketDAL();
        public void addTicket(TicketDTO ticket)
        {
            ticketDAL.addTicket(ticket);
        }
        public bool checkBookingExist(string booking)
        {
            return ticketDAL.checkBookingExist(booking);
        }
    }
}
