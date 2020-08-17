using module3.DALs;
using module3.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3.BULs
{
    class CountryBUL
    {
        CountryDAL countryDAL = new CountryDAL();
        public List<CountryDTO> getCountry()
        {
          
            return countryDAL.getCountry() ;
        }
        public string getNameCountryFromID(int idCountry)
        {
           
            return countryDAL.getNameCountryFromID(idCountry);
        }
        public int getIDCountryFromName(string name)
        {
           
            return countryDAL.getIDCountryFromName(name);
        }
    }
}
