using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projext_of_SCD.DTO;
using Projext_of_SCD.DL;
namespace Projext_of_SCD.BL
{
    internal class sign_upBL
    {
        Sign_upDL sDL =new Sign_upDL();
        public int Adddata(sign_upDTO sup)
        {
            return sDL.AddUserInDB(sup);
        }
    }
}
