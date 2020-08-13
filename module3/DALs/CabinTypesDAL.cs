using module3.DTOs;
using module3.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3.DALs
{
    class CabinTypesDAL
    {
        SqlConnection con;
        public CabinTypesDAL()
        {
            con = UtilsConnect.getConnection();
        }
        public List<CabinTypesDTO> getCabinType()
        {
            con.Open();
            List<CabinTypesDTO> list = new List<CabinTypesDTO>();

            string sql = "select * from CabinTypes";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CabinTypesDTO cabinTypes = new CabinTypesDTO(Convert.ToInt32(dr["ID"]), dr["Name"].ToString());
                list.Add(cabinTypes);
            }
            con.Close();
            return list;
        }
    }
}
