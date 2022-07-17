using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projext_of_SCD.DTO;
using System.Data.SqlClient;

namespace Projext_of_SCD.DL
{
    internal class DeleteTripByAdmin
    {
        private DbConnection dcon = new DbConnection();
 
        int x;
        public int  DeleteTripFromDB(UserBookTripDTO sup)
        {
            try
            {
                dcon.Con.Open();
                string query = "delete  from TripForUser where Destination='"+sup.desination+"'; ";
                SqlCommand com = new SqlCommand(query, dcon.Con);
                x = com.ExecuteNonQuery();


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
