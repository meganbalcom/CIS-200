//Megan Balcom
//CIS 200-10
//Program 1A
//May 31, 2015

//This class is derived from Package and models the logic for 
//creating a Ground Package. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class GroundPackage : Package
    {
        //Constructor 
        //Precondition: A valid originAddress and destinationAddress have been created,
        //              packageLength > 0,
        //              packageWidth > 0,
        //              packageHeight > 0, 
        //              packageWeight > 0,
        //Postcondition: the package is created with the defined values for origin address, destination address,
        //length, width, height and weight.
        public GroundPackage(Address originAddress, Address destAddress, double packageLength, double packageWidth,
            double packageHeight, double packageWeight)
            : base(originAddress, destAddress, packageLength, packageWidth, packageHeight, packageWeight)
        {
            //Zone Distance is read only
        }
        public int ZoneDistance
        {
            //Precondition: None
            //Postcondition: The ground package's zone distance is returned.
            //Zone distance is the positive difference between the first digit
            //of the origin zip code and the first digit of the destination 
            //zip code. 
            get
            {
                const int DIVISION_FACTOR = 10000; // Denominator to extract 1st digit
                int calculatedZoneDist;           // Calculated zone distance

                calculatedZoneDist = Math.Abs(( OriginAddress.Zip / DIVISION_FACTOR)
                    - ( DestinationAddress.Zip / DIVISION_FACTOR));

                return calculatedZoneDist;
            }
        }
        //Precondition: None 
        //Postcondition: The ground package's cost has been returned 
        public override decimal CalcCost()
        {
          const decimal GROUND_PACKAGE_RATE = 0.20M; //Ground package rate used
                                                    //in cost equation
          const decimal ZONE_DIST_RATE = 0.05M; //Zone distance rate used in 
                                               //cost equation 
          decimal groundPackageCost = GROUND_PACKAGE_RATE * (decimal)(Length + Width + Height)
                + ZONE_DIST_RATE * (decimal)((ZoneDistance + 1) + Weight); //Forumula used in 
                                                                            //cost equation of ground packages
          return groundPackageCost;
        }
        //Precondition: None
        //Postcondition: A String with the ground package's data has been returned
        public override string ToString()
        {
            return String.Format("Ground Package:{1}{0}Zone Distance:{2}Ground Package Cost:{3:C}", base.ToString(),
                Environment.NewLine, ZoneDistance, CalcCost());
        }


   }
}

