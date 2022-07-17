using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projext_of_SCD.DTO;
using Projext_of_SCD.DL;

namespace Projext_of_SCD.BL
{
    internal class HotelBL
    {
        HotelDL sDL =new HotelDL() ;
        public int AddHoteldata(HotelDTO sup)
        {
            return sDL.AddHotelInDB(sup);
        }
    }
}
