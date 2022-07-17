using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projext_of_SCD.DTO;
using System.Data.SqlClient;

namespace Projext_of_SCD.DL
{
    internal class CheckTripMateDL
    {
        private DbConnection dcon = new DbConnection();
       
        int x = 0;
        public int CheckMateInDB(LoginDTO y)
        {
            try
            {
                dcon.Con.Open();
                string query = "SELECT UpcommingTrips from UserBookedTrips where UpcommingTrips='" + y.useremail+"' ";
                SqlCommand com = new SqlCommand(query, dcon.Con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    x++;
                }



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
