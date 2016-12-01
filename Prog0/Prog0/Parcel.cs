//Megan Balcom
//CIS 200-10
//Program 0
//May 21, 2015
//This class creates a parcel object by referencing the data from the
//address class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class Parcel
    {
        public Address OriginAddress { get; set; } //Auto-implemented get & set
        public Address DestinationAddress { get; set; } //Auto-impleted get & set

        //Constructor
        //Precondition: An address object was successfully created
        //Postcondition: Origin and Destination address objects are created
        public Parcel(Address originAddress, Address destinationAddress)
        {
            //Use properties to validate data
            OriginAddress = originAddress; 
            DestinationAddress = destinationAddress; 
        }

        //Abstract CalcCost method that returns cost of parcel as a decimal 
        //Precondition: None
        //Postcondition: A derived class determines how to calculate cost
        public abstract decimal CalcCost();

        //ToString method
        //Precondition: None
        //Postcondition: A string is returned with the parcel's data
        public override string ToString()
        {
            return string.Format("Origin Address: {0} \nDestination Address: {1}\n Cost: {2:C}", 
                OriginAddress, DestinationAddress, CalcCost() ); 
        }
    }
}
