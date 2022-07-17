using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projext_of_SCD.DL;
using Projext_of_SCD.DTO;
using System.Data.SqlClient;

namespace Projext_of_SCD.BL
{
    internal class UpcommingTripsBL
    {
        UpcommingTripsDL utdl = new UpcommingTripsDL();
        public SqlDataAdapter GetUserUpcommingTrip(UpcommingTripsDTO x)
        {
            return utdl.GetBookedTripfromDB(x);

        }
    }
}
