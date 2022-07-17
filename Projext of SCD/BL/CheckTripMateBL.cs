using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projext_of_SCD.DTO;
using Projext_of_SCD.DL;

namespace Projext_of_SCD.BL
{
    internal class CheckTripMateBL
    {
        CheckTripMateDL CKDL = new CheckTripMateDL();
        public int CheckTripMate(LoginDTO x)
        {
            return CKDL.CheckMateInDB(x);
        }
    }
}
