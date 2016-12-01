// Megan Balcom
// CIS 200-10
// Program 4
// June 25, 2015
// This class implements the IComparer interface, which allows for additional
// comparison mechanisms to parcels. This class sorts parcels in descending
// order based on their destination address zipcode. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class ParcelsDescByZip : IComparer<Parcel>
    {
        // Precondition: None
        // Postcondition: When p1 < p2, method returns negative #
        //                When p1 == p2, method returns 0
        //                When p1 > p2, method returns positive #
        public int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null)
            {
                return 0;
            }
            else if (p2 == null)
            {
                return -1;
            }

            // Compare the zipcodes of the two parcels' destination addresses
            if(p2.DestinationAddress.Zip > p1.DestinationAddress.Zip)
            {
                return 1;
            }
            else if (p2.DestinationAddress.Zip < p1.DestinationAddress.Zip)
            {
                return -1;
            }
            else
            {
                return 0;
            }


        }
    }
}
