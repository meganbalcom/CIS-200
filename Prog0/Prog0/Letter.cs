//Megan Balcom
//CIS 200-10
//Program 0
//May 21, 2015
//This class creates a letter object, which is a parcel. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class Letter : Parcel  //Letter "is a" Parcel
    {
        private decimal _fixedCost; //Variable to hold non-negative fixed cost 

        //Constructor
        //Precondition: A parcel object was successfully created
        //Postcondition: A letter object is created
     public Letter(Address originAddress, Address destinationAddress, decimal fixedCost) 
         : base (originAddress, destinationAddress)
        {
            FixedCost = fixedCost; //Property to validate data
        }

        //Fixed cost Property
        public decimal FixedCost
        {
            //Precondition: None
            //Postcondition: The parcel's fixed cost is returned 
            get
            {
                return _fixedCost;
            }
            //Precondition: Fixed cost is >= 0
            //Postcondition: The inputted fixed cost amount is set to the value
            private set
            {
                if (value >= 0 )
                _fixedCost = value;
            }
        }

           //CalcCost method
           //Precondition: None
           //Postcondition: The parcel's fixed cost is returned
        public override decimal CalcCost()
        {
            return FixedCost;
        }

        //ToString method
        //Precondition: None
        //Postcondition: A string is returned that displays the parcel's data
        public override string ToString()
        {
            return string.Format("Origin Address: \n{0} \nDestination Address: {1} \nFixed Cost: {2:C}\n", OriginAddress, DestinationAddress, CalcCost() );
        }
  }
}
