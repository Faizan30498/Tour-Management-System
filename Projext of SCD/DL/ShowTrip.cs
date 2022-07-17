using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projext_of_SCD.DTO;
using System.Data.SqlClient;

namespace Projext_of_SCD.DL
{
    internal class ShowTrip
    {
        private DbConnection dcon = new DbConnection();

        TripDTO trip = new TripDTO();
        

        
        public SqlDataAdapter ShowTripsFromDB()
        {
            try
            {
                dcon.Con.Open();
                string query = "SELECT * FROM  TripForUser ";
                //SqlCommand com = new SqlCommand(query, dcon.Con);
                // SqlDataAdapter
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
