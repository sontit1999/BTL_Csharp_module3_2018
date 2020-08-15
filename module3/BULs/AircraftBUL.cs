using module3.DALs;
using module3.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3.BULs
{
    class AircraftBUL
    {
        AircraftDAL aircraftDAL = new AircraftDAL();
        public AircraftDTO getAircraftFromIDSchedule(int idSchedule)
        {
            
            return aircraftDAL.getAircraftFromIDSchedule(idSchedule);
        }
    }
}
