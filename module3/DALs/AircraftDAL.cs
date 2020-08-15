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
    class AircraftDAL
    {
        SqlConnection con;
        public AircraftDAL()
        {
            con = UtilsConnect.getConnection();
        }
        public AircraftDTO getAircraftFromIDSchedule(int idSchedule)
        {
            AircraftDTO aircraft = null;
            con.Open();
            string sql = "select * from Aircrafts where ID = (select AircraftID from Schedules where ID = @id )";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("id", idSchedule);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                aircraft = new AircraftDTO(Convert.ToInt32(dr["ID"]), Convert.ToInt32(dr["TotalSeats"]), Convert.ToInt32(dr["EconomySeats"]), Convert.ToInt32(dr["BusinessSeats"]));
                break;
            }
            con.Close();
            return aircraft;
        }
    }
}
