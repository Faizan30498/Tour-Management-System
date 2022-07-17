using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projext_of_SCD.DTO;
using System.Data.SqlClient;

namespace Projext_of_SCD.DL
{
    internal class Sign_upDL
    {
        private DbConnection dcon = new DbConnection();
        UserDTO uDTO = new UserDTO();
        int x;
        public int AddUserInDB(sign_upDTO sup)
        {
            try
            {
                dcon.Con.Open();
                string query = "insert into MyUser values('" + sup.email + "','" + sup.pin + "','User','" + sup.name + "');";
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
