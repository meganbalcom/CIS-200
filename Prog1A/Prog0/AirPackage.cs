//Megan Balcom
//CIS 200-10
//Program 1A
//May 31, 2015

//This class is abstract and derived from Package. It models
//the logic for determining if an AirPackage is heavy and/or large.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class AirPackage : Package
    {

        private const int HEAVY_WEIGHT = 75; //Minimum weight in pounds for a package considered heavy
        private const int LARGE_SIZE = 100; //Minimum summation of dimensions for a package considered large

        //Constructor 
        //Precondition: A valid originAddress and destinationAddress have been created,
        //              packageLength > 0,
        //              packageWidth > 0,
        //              packageHeight > 0, 
        //              packageWeight > 0,
        //Postcondition: the package is created with the defined values for origin address, destination address,
        //length, width, height and weight.
        public AirPackage(Address originAddress, Address destAddress, double packageLength, double packageWidth,
            double packageHeight, double packageWeight)
            : base(originAddress, destAddress, packageLength, packageWidth, packageHeight, packageWeight)
        {
            
        }
        //Precondition: None
        //Postcondition: The air package's weight is determined
        //to be heavy or not.
        public bool IsHeavy() 
        {
            if (Weight >= HEAVY_WEIGHT) 
                return true;
            else
                return false;
        }
        //Precondition: None 
        //Postcondition: The air package's size is determined 
        //to be large or not.
        public bool IsLarge() 
        {
            if (Length + Width + Height >= LARGE_SIZE)
                return true;
            else
                return false;
        }
        //Precondition: None 
        //Postcondition: A String with the air package's data has been returned
        public override String ToString()
        {
            return String.Format("{1}{0}Heavy:{2}{1}Large:{3}{1}", base.ToString(), Environment.NewLine, IsHeavy(), IsLarge());
        }
    }
}
