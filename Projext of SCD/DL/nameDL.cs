using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projext_of_SCD.DTO;
using System.Data.SqlClient;
namespace Projext_of_SCD.DL
{
    internal class nameDL
    {
        private DbConnection dcon = new DbConnection();

       // NameDTO nDTO = new NameDTO();
        public NameDTO GetInfoFromDB(NameDTO nDTO)
        {
            try
            {

                dcon.Con.Open();
                string query = "select Name, Email from MyUser where Email='" + nDTO.email + "' ";
                SqlCommand com = new SqlCommand(query, dcon.Con);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    nDTO.email = dr["Email"].ToString();
                    nDTO.name = dr["Name"].ToString();
                }
                else
                {
                    nDTO.email = null;
                    nDTO.name = null;
                }

                

                return nDTO;
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
