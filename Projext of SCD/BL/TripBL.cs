using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projext_of_SCD.DTO;
using Projext_of_SCD.DL;

namespace Projext_of_SCD.BL
{
    internal class TripBL
    {
        TripDL sDL = new TripDL();
        public int AddTripData(TripDTO sup)
        {
            return sDL.AddTripInDB(sup);
        }
    }
}
