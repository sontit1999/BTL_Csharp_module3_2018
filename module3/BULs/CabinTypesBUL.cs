using module3.DALs;
using module3.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3.BULs
{
    class CabinTypesBUL
    {
        CabinTypesDAL cabinTypesDAL = new CabinTypesDAL();
        public List<CabinTypesDTO> getCabinType()
        {
            return cabinTypesDAL.getCabinType();
        }
    }
}
