using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projext_of_SCD.DTO;
using System.Data.SqlClient;

namespace Projext_of_SCD.DL
{
    internal class LoginDL
    {
        private DbConnection dcon = new DbConnection();
        UserDTO uDTO =new UserDTO();
        public UserDTO VerifyUserFromDB(LoginDTO lg)
        {
            try
            {
                // String User = "User";
                dcon.Con.Open();
                string query = "SELECT Role FROM MyUser where Email=@email AND Pin=@pin     ";
                SqlCommand com = new SqlCommand(query, dcon.Con);
                com.Parameters.AddWithValue("@email", lg.useremail);
                com.Parameters.AddWithValue("@pin", lg.pin);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    uDTO.role = dr["Role"].ToString();
                }
                else
                {
                    uDTO.role = null;
                }

               

                return uDTO;
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
