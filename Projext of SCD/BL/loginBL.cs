using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projext_of_SCD.DTO;
using Projext_of_SCD.DL;

namespace Projext_of_SCD.BL
{
    internal class loginBL
    {
        LoginDL uDL = new LoginDL();
        UserDTO udt0;
        public int VerifyUser(LoginDTO lg)
        {
            udt0 = uDL.VerifyUserFromDB(lg);
            if(udt0.role== "ADMIN")
            {
                return 1;
            }
            else if(udt0.role == "User")
            {
                return 2;
            }
            else
            {
                return 3;
            }
            
        }
    }
}
