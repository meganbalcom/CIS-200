// Program 1B
// CIS 200-10
// Summer 2015
// Due: 6/3/2015
// By: Andrew L. Wright

// Updated by Megan Balcom to include 4 LINQ queries that sort various types of parcels
// in different ways. 

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45",
                "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", "",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            //Addresses 5-8 updated by Megan Balcom
            Address a5 = new Address("Erik Davis", "2700 Potomac Mills Circle",
                "", "Woodbridge", "VA", 22192); //Test Address 5
            Address a6 = new Address("Luke Skywalker", "100 Death Star Rd", 
                "Apt 2", "Galaxy", "CA", 90001); //Test Address 6
            Address a7 = new Address("Sarah Balcom", "6610 Shelburn Dr", 
                "", "Crestwood", "KY", 40014); //Test Address 7
            Address a8 = new Address("Katherine Freid", "956 Treasure Ct", 
                "", "Fort Mill", "SC", 29708); //Test Address 8

            Letter letter1 = new Letter(a1, a2, 3.95M);                           // Letter test object
            Letter letter2 = new Letter(a5, a8, 2.45M);                           // added by Megan
            Letter letter3 = new Letter(a6, a7, 6.5M);                            // added by Megan 
 
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a6, a5, 16, 5, 12, 4.7);         // added by Megan
            GroundPackage gp3 = new GroundPackage(a8, a7, 4, 6, 8, 10);            // added by Megan 

            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a5, a7, 10, 3.2, 14,   // added by Megan 
                6, 6.75M);
            NextDayAirPackage ndap3 = new NextDayAirPackage(a3, a8, 2, 2.5, 5,     // added by Megan 
                6, 3.5M);

            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a7, a8, 5, 10, 15,        // added by Megan
                20, TwoDayAirPackage.Delivery.Early);                                   
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a5, a6, 8, 5, 9,          // added by Megan  
                4.5, TwoDayAirPackage.Delivery.Saver);


            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list 
            parcels.Add(letter2);
            parcels.Add(letter3);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(ndap3);
            parcels.Add(tdap1);
            parcels.Add(tdap2);
            parcels.Add(tdap3);

            // LINQ query that selects parcels by their zip code
            var sortDestZip = // Holds the results of this query
                from p in parcels
                orderby p.DestinationAddress.Zip descending
                select p;
            // Outputs the query result to the console
            Console.WriteLine("Sort parcels by Destination Zip:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause ();

            // LINQ query that sorts parcels by their cost
            var sortByCost = // Holds the results of this query
                from p in parcels
                orderby p.CalcCost()
                select p;
            // Outputs the query result to the console
            Console.WriteLine("Sort parcels by Cost:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            // LINQ query that that selects parcels by their type 
            // and  then orders them by descending cost
            var sortParcelType = //Holds the results of this query
                from p in parcels
                orderby p.GetType().ToString(), p.CalcCost() descending
                select p;

            // Outputs the query result to the console
            Console.WriteLine("Sort parcels by Parcel Type and Descending Cost:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            // LINQ query that selects Air Packages and
            // orders they by descending weight
            var apHeavyByWeight = // Holds the results of this query 
                from p in parcels
                let ap = p as AirPackage
                where ap != null && ap.IsHeavy()
                orderby ap.Weight descending
                select ap;

            // Outputs the query result to the console
            Console.WriteLine("Sort Air Packages by Descending Weight:");
            Console.WriteLine("====================");
            foreach (var ap in parcels)
            {
                Console.WriteLine(ap);
                Console.WriteLine("====================");
            }
            Pause();

        }
        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
        
}

