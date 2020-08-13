using module3.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using module3.Server;

namespace module3.DALs
{
    class AirportsDAL
    {
        SqlConnection con;
        public AirportsDAL()
        {
           con = UtilsConnect.getConnection();
        }
        public List<AirportsDTO> getAirport()
        {
            con.Open();
            List<AirportsDTO> list = new List<AirportsDTO>();

            string sql = "select * from Airports";
            SqlCommand cmd = new SqlCommand(sql,con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                AirportsDTO airports = new AirportsDTO(Convert.ToInt32(dr["ID"]), Convert.ToInt32(dr["CountryID"]), dr["IATACode"].ToString(), dr["Name"].ToString());
                list.Add(airports);
            }
            con.Close();
            return list;
        }
        public string getNameFromCode(int code)
        {
            string name = "";
            con.Open();
           

            string sql = "select * from Airports where ID = @code";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("code", code);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                name =  dr["IATACode"].ToString();    
            }
            con.Close();
            return name ;
        }
    }
}
