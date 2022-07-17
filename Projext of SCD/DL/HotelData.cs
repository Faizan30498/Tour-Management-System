using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projext_of_SCD.DTO;
using System.Data.SqlClient;

namespace Projext_of_SCD.DL
{
    internal class HotelData
    {
        private DbConnection dcon = new DbConnection();

        public SqlDataAdapter ShowHotelFromDB(HotelDTO x)
        {
            try
            {
                dcon.Con.Open();
                string query = "SELECT * FROM  Hotel where Location='" + x.location + "' ";
                //SqlCommand com = new SqlCommand(query, dcon.Con);
                SqlDataAdapter comm = new SqlDataAdapter(query, dcon.Con);
                return comm;
            }
            catch (SqlException ex)
            {
                return null;

            }
            finally
            {
                dcon.Con.Close();

            }


        }
    }
}
