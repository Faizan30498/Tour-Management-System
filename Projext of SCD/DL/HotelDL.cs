using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projext_of_SCD.DTO;
using System.Data.SqlClient;

namespace Projext_of_SCD.DL
{
    internal class HotelDL
    {
        private DbConnection dcon = new DbConnection();
        int x;
        public int AddHotelInDB(HotelDTO sup)
        {
            try
            {
                dcon.Con.Open();
                string query = "insert into Hotel values('" + sup.hotelName + "','" + sup.Price + "','" + sup.location + "');";
                SqlCommand com = new SqlCommand(query, dcon.Con);
                x = com.ExecuteNonQuery();
                dcon.Con.Close();
                
            }
            catch (SqlException ex)
            {
                

            }
            finally
            {
                dcon.Con.Close();

            }
            return x;
        }
    }
}
