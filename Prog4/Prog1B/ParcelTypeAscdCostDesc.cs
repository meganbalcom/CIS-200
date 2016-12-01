// Megan Balcom
// CIS 200-10
// Program 4
// June 25, 2015
// This class implements the IComparer interface, which allows for additional
// comparison mechanisms to parcels. This class sorts parcels first by their 
// type in ascending order, then by their cost in descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class ParcelTypeAscdCostDesc : IComparer<Parcel>
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
            // When the parcel type is the same 
            if (String.Compare(p1.GetType().ToString(), p2.GetType().ToString()) == 0)
            {
                // Then, determine which has the smaller cost
                int calcCompare = (int)p2.CalcCost() - (int)p1.CalcCost(); // Cost difference?

                if (calcCompare < 0)
                {
                    return calcCompare;
                }
                else if (calcCompare > 0) 
                {
                    return calcCompare;
                }
                else
                {
                    return 0;
                }

            }
            else if (String.Compare(p1.GetType().ToString(), p2.GetType().ToString()) < 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }



        }
    }
}
