using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projext_of_SCD.DTO;
using System.Data.SqlClient;

namespace Projext_of_SCD.DL
{
    internal class UserBookTripDL
    {
        private DbConnection dbcon = new DbConnection();
        int x;
        public int AddBookedTripinDB(UserBookTripDTO ubtdto)
        {
            try
            {
                dbcon.Con.Open();
                string query = "insert into UserBookedTrips values('" + ubtdto.email + "','" + ubtdto.desination + "');";
                SqlCommand com = new SqlCommand(query, dbcon.Con);

                 x = com.ExecuteNonQuery();
                
                
            }
            catch (SqlException ex)
            {
               

            }
            finally
            {
                dbcon.Con.Close();

            }
            return x;
        }

    }
}
