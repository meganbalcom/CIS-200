//Megan Balcom
//CIS 200-10
//Program 0
//May 21, 2015
//Test data class for the console application 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 4 Address objects
            Address address1 = new Address("Amy Johnson", "100 Brown Ave", "Apt 23", "Louisville", "KY", 40297);
            Address address2 = new Address("Bill Fisher", "200 Violet Blvd", "Apt 2", "Hillview", "KY", 40129);
            Address address3 = new Address("Laura Baker", "300 Honeycomb St", "Condo 9", "Fairdale", "KY", 40118);
            Address address4 = new Address("Jim Thompson", "400 Teal Ct", "Apt 13B", "Mt Washington", "KY", 40047);

            //Create 3 Letter objects
            Letter letter1 = new Letter(address1, address2, 3.5M);
            Letter letter2 = new Letter(address3, address4, 2.0M);
            Letter letter3 = new Letter(address4, address1, 1.5M);

            //Add letter objects to a list of parcel objects
            List<Parcel> items = new List<Parcel>();
            items.Add(letter1);
            items.Add(letter2);
            items.Add(letter3);

            //Display each item in the list 
            Console.WriteLine("Results:");
            foreach (var item in items)
                Console.WriteLine("{0}", item);


                
        }
    }
}
