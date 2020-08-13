using module3.DALs;
using module3.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3.BULs
{
    class AirportsBUL
    {
        AirportsDAL airportsDAL = new AirportsDAL();
        public List<AirportsDTO> getAirport()
        {        
            return airportsDAL.getAirport();
        }
    }
}
