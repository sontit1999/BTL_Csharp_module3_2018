using module3.DTOs;
using module3.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3.DALs
{
    class CountryDAL
    {
        SqlConnection con;
        public CountryDAL()
        {
            con = UtilsConnect.getConnection();
        }
        public List<CountryDTO> getCountry()
        {
            con.Open();
            List<CountryDTO> list = new List<CountryDTO>();

            string sql = "select * from Countries";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CountryDTO country = new CountryDTO(Convert.ToInt32(dr["ID"]), dr["Name"].ToString());
                list.Add(country);
            }
            con.Close();
            return list;
        }
        public string getNameCountryFromID(int idCountry)
        {
            string name = "";
            con.Open();
            List<CountryDTO> list = new List<CountryDTO>();

            string sql = "select * from Countries where ID = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idCountry);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                name = dr["Name"].ToString();
                break;
            }
            con.Close();
            return name;
        }
        public int getIDCountryFromName(string name)
        {
            int IDcountry = 0;
            con.Open();
            string sql = "select ID from Countries where Name = @name";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("name", name);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IDcountry = Convert.ToInt32(dr["ID"]);
                break;
            }
            con.Close();
            return IDcountry;
        }
    }
}
