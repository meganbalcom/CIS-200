//Megan Balcom
//CIS 200-10
//Program 0
//May 21, 2015
//This class creates an address object that has 6 parameters (name, adress line 1, address line 2, 
//address City, address State, address zipcode). In order for an addres object to be created all 6 of 
//these critera must exist, however zipcode is the only property that requires validation in this example.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class Address
    {
        public const uint MIN_ZIP = 00000; //Smallest zipcode possible
        public const uint MAX_ZIP = 99999; //Largest zipcode possible

        private string _name;         //Name in address
        private string _addressLine1; //First line of address
        private string _addressLine2; //Second line of address
        private string _city;         //City in address
        private string _state;        //State in address
        private uint _zipcode;        //Zipcode in address

        //Constructor
        //Precondition: Zipcode has to be >= 00000 && <= 99999, other than that there are none
        //Postcondition: An address object is created
        public Address(string addressName, string firstAddressLine, string secondAddressLine,
            string addressCity, string addressState, uint theZip)
        {
            //Defined properties will be used to validate corresponding input
            Name = addressName; 
            Address1 = firstAddressLine;
            Address2 = secondAddressLine;
            City = addressCity;
            State = addressState;
            Zip = theZip;
        }
        //Name Property
        public string Name
        {
            //Precondition: None
            //Postcondition: The sender's name is returned
            get
            {
                return _name;
            }
            //Precondition: A string is entered
            //Postcondition: The sender name is set to the value
            private set
            {
                _name = value;
            }
        }
        //Address Line 1 Property
        public string Address1
        {
            //Precondition: None
            //Postcondition: The first address line is returned
            get
            {
                return _addressLine1;
            }
            //Precondition: A string is entered
            //Postcondition: The address line is set to the value
            private set
            {
                _addressLine1 = value;
            }
        }
        //Address Line 2 Property
        public string Address2
        {
            //Precondition: None
            //Postcondition: The second address line is returned
            get
            {
                return _addressLine2;
            }
            //Precondition: A string is entered
            //Postcondition: The address line is set to the value
            private set
            {
                _addressLine2 = value;
            }
        }
        //City Property
        public string City
        {
            //Precondition: None
            //Postcondition: The city name is returned
            get
            {
                return _city;
            }
            //Precondition: A string is entered
            //Postcondition: The name of the city is set to the value
            private set
            {
                _city = value;
            }
        }
        //State Property
        public string State
        {
            //Precondition: None
            //Postcondition: The name of the state is returned
            get
            {
                return _state;
            }
            //Precondition: A string is entered
            //Postcondition: The state name is set to the value
            private set
            {
                _state = value;
            }
        }
        //Zipcode Property
        public uint Zip
        {
            //Precondition: None
            //Postcondition: The zipcode has been returned
            get
            {
                return _zipcode;
            }
            //Precondition:Zipcode is >= 00000 and is <= 99999
            //Postcondition: The zipcode has been set to the specific value
            private set
            {
                if ((value >= MIN_ZIP) && (value <= MAX_ZIP))
                    _zipcode = value;
            }
        }
        //Precondition: None
        //Postcondition: A string with the address object's data is returned and displayed
        public override string ToString()
        {
            return string.Format("{0} \n{1} \n{2}, {3}, {4} {5:D5}", Name, Address1, Address2,
                City, State, Zip);
        }


    }
}
