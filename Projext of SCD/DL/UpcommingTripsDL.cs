using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projext_of_SCD.DTO;
using System.Data.SqlClient;

namespace Projext_of_SCD.DL
{
    internal class UpcommingTripsDL
    {
        private DbConnection dbcon = new DbConnection();

        public SqlDataAdapter GetBookedTripfromDB(UpcommingTripsDTO utdto)
        {
            try
            {
                dbcon.Con.Open();
                string query = "select UpcommingTrips from UserBookedTrips where Email='"+utdto.email+"' ";
                // SqlCommand com = new SqlCommand(query, dbcon.Con);
                SqlDataAdapter comm = new SqlDataAdapter(query, dbcon.Con);
               
                return comm;
            }
            catch (SqlException ex)
            {
                return null;

            }
            finally
            {
                dbcon.Con.Close();

            }
        }
    }
}
