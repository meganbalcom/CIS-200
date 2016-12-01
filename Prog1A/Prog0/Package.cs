//Megan Balcom
//CIS 200-10
//Program 1A
//May 31, 2015

//This class demonstrates a potential business model for a Package (which is abstract).
//Each package has an origin and destination address, a length, a width,
//a height, and a weight. 

//Package is a child class of Parcel and serves as a base class for Ground Packages
//and Air Packages. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class Package : Parcel
    {
        private double lengthOfPackage; //Package's length
        private double widthOfPackage; //Package's width
        private double heightOfPackage; //Package's height
        private double weightOfPackage; //Package's weight 

        //Constructor 
        //Precondition: A valid originAddress and destinationAddress have been created,
        //              packageLength > 0,
        //              packageWidth > 0,
        //              packageHeight > 0, 
        //              packageWeight > 0,
        //Postcondition: the package is created with the defined values for origin address, destination address,
        //length, width, height and weight.
        public Package(Address originAddress, Address destAddress, double packageLength, double packageWidth,
            double packageHeight, double packageWeight)
            : base(originAddress, destAddress)
        {
            //Using properties to make sure validation happens 
            Length = packageLength;
            Width = packageWidth;
            Height = packageHeight;
            Weight = packageWeight;
        }

        public double Length
        {
            //Precondition: None
            //Post condition: The package's length has been returned
            get
            {
                return lengthOfPackage;
            }
            //Precondition: value > 0 
            //Postcondition: The package's length has been set
            //to value 
            set
            {
                if (value > 0)
                    lengthOfPackage = value;
                else
                    throw new ArgumentOutOfRangeException("Length", value,
                        "must be a value greater than 0.");
            }
        }

        public double Width
        {
            //Precondition: None 
            //Post condition: The package's width has been returned
            get
            {
                return widthOfPackage;
            }
            //Precondition: value > 0 
            //Postcondition: The package's width has been set to
            //value
            set
            {
                if (value > 0)
                    widthOfPackage = value;
                else
                    throw new ArgumentOutOfRangeException("Width", value,
                        "must be a value greater than 0.");
            }
        }

        public double Height
        {
            //Precondition: None 
            //Post condition: The package's height has been returned
            get
            {
                return heightOfPackage;
            }
            //Precondition: value > 0 
            //Postcondition: The package's height has been set to 
            //value 
            set
            {
                if (value > 0)
                    heightOfPackage = value;
                else
                    throw new ArgumentOutOfRangeException("Height", value,
                        "must be a value greater than 0.");
            }
        }

        public double Weight
        {
            //Precondition: None 
            //Post condition: The package's weight has been returned 
            get
            {
                return weightOfPackage;
            }
            //Precondition: value > 0 
            //Postcondition: The package's weight has been set to 
            //value 
            set
            {
                if (value > 0)
                    weightOfPackage = value;
                else
                    throw new ArgumentOutOfRangeException("Weight", value,
                        "must be a value greater than 0.");
            }
        }

        //Precondition: None
        //Postcondition: A String with the package's data has been returned 
        public override string ToString()
        {
            return String.Format("Package{1}{0} Package dimensions: {1}Length:{2} \nWidth{3} \nHeight:{4} \nWeight:{5}", 
                base.ToString(), Environment.NewLine, Length, Width, Height, Weight);
        }


    }
}
