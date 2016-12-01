//Megan Balcom
//CIS 200-10
//Program 1A
//May 31, 2015

//This class is derived from AirPackage and models the logic
//for creating a NextDayAirPackage.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class NextDayAirPackage : AirPackage
    {
        private decimal expressFeeOfPackage; //Express fee of package
        
        //Constructor 
        //Precondition: A valid originAddress and destinationAddress have been created,
        //              packageLength > 0,
        //              packageWidth > 0,
        //              packageHeight > 0, 
        //              packageWeight > 0,
        //              expressFee >= 0. 
        //Postcondition: the package is created with the defined values for origin address, destination address,
        //length, width, height, weight and express fee.
        public NextDayAirPackage(Address originAddress, Address destAddress, double packageLength, double packageWidth,
            double packageHeight, double packageWeight, decimal expressFee)
            : base(originAddress, destAddress, packageLength, packageWidth, packageHeight, packageWeight)
        {
            //ExpressFee is read only
        }
        public decimal ExpressFee
        {
            //Precondition: None 
            //Postcondition: The value of express fee has been returned
            get
            {
                return expressFeeOfPackage;
            }
            //Precondition: value >= 0  
            //Postcondition: The express fee amount has been set to 
            //value 
            private set
            {
                if (value >= 0)
                    expressFeeOfPackage = value;
                else
                    throw new ArgumentOutOfRangeException("ExpressFee", value,
                        "must be a value greater than or equal to 0.");
            }

        }
        //Precondition: None 
        //Postcondition: The next day air package's cost has been returned 
        public override decimal CalcCost()
        {
            const decimal DIMENSION_FEE = 0.40M; //Dimension fee in cost equation
            const decimal WEIGHT_FEE = 0.30M; //Weight fee in cost equation
            const decimal WEIGHT_CHARGE = 0.25M; //Charge for heavy weight in cost equation
            const decimal SIZE_CHARGE = 0.25M; //Charge for large size in cost equation

            decimal baseCost = DIMENSION_FEE * (decimal)(Length + Width + Height) + WEIGHT_FEE *
                (decimal)(Weight) + ExpressFee; //Formula for base cost in cost equation

            decimal largeSizeCharge = SIZE_CHARGE * (decimal)(Length + Width + Height); //Formula for additional large package
                                                                                        //charge in cost equation

            decimal heavyWeightCharge = WEIGHT_CHARGE * (decimal)(Weight); //Formula for additional heavy package charge
                                                                           //in cost equation

            if (IsHeavy() == true && IsLarge() == true) 
            { 
                return baseCost + heavyWeightCharge + largeSizeCharge;
            }
            else if (IsHeavy() == true)
            {
                return baseCost + heavyWeightCharge;
            }
            else if (IsLarge() == true)
            {
                return baseCost + largeSizeCharge;
            }
            else
            {
                return baseCost;
            }
        }
        //Precondition: None
        //Postcondition: A String with the next day air package's data has been returned
        public override String ToString()
        {
            return String.Format("{0}{1}Next Day Air Package Cost:{2:C}{1}", base.ToString(), Environment.NewLine, CalcCost());
        }

    }
}
