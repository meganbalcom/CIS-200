//Megan Balcom
//CIS 200-10
//Program 1A
//May 31, 2015

//This class is a derived class of AirPackage and models the logic
//for creating a TwoDayAirPackage.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
   public class TwoDayAirPackage : AirPackage
    {
       
       public enum Delivery {Early, Saver}; //Delivery type options for TwoDayAirPackages

       //Constructor 
       //Precondition: A valid originAddress and destinationAddress have been created,
       //              packageLength > 0,
       //              packageWidth > 0,
       //              packageHeight > 0, 
       //              packageWeight > 0,
       //              deliveryType == Delivery.Saver || deliveryType == Delivery.Early 
       //Postcondition: the package is created with the defined values for origin address, destination address,
       //length, width, height, weight and delivery type. 
        public TwoDayAirPackage(Address originAddress, Address destAddress, double packageLength, double packageWidth,
            double packageHeight, double packageWeight, Delivery deliveryType)
            : base(originAddress, destAddress, packageLength, packageWidth, packageHeight, packageWeight)
        {
            DeliveryType = deliveryType; //Using property to make sure validation happens
        }
        
        public Delivery DeliveryType
        {
            //Precondition: None
            //Postcondition: The delivery type has been returned 
            get;
            //Precondition: None
            //Postcondition: The delivery type is assigned to the TwoDayAirPackage
            set;
        }
        //Precondition: None 
        //Postcondition: The two day air package's cost has been returned
        public override decimal CalcCost()
        {
            const decimal SAVER_DISCOUNT = 0.90M; //10% discount for enum type Saver
            const decimal DIMENSION_CHARGE = 0.25M; //Dimension charge in cost equation
            const decimal WEIGHT_CHARGE = 0.25M; //Weight charge in cost equation
            decimal twoDayBaseCost = DIMENSION_CHARGE * (decimal)(Length + Width + Height) 
                + WEIGHT_CHARGE * (decimal)(Weight); //Base cost formula in cost equation 

            if (DeliveryType == Delivery.Saver)
                return twoDayBaseCost * SAVER_DISCOUNT;
            else
                return twoDayBaseCost;
        }
        //Precondition: None
        //Postcondition: A String with the two day air package's data has been returned
        public override string ToString()
        {
            return String.Format("{0}{1}Delivery Type:{3}{1}Two Day Air Package Cost:{2:C}{1}", 
                base.ToString(), Environment.NewLine, CalcCost(), DeliveryType);
        }

         
        
    }
}
