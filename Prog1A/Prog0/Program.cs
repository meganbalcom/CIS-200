// Program 0
// CIS 200-10
// Summer 2015
// Due: 5/21/2015
// By: Andrew L. Wright

// File: Program.cs
// Simple test program for initial Parcel classes

//Updated by Megan Balcom beginning at line 56 to provide test data
//for the packages (ground packages and two types of air packages - 
//next day air packages and two day air packages). 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45", 
                "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", "", 
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321", 
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter l1 = new Letter(a1, a3, 1.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.25M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.75M); // Test Letter 3

            List<Parcel> parcels = new List<Parcel>(); // Test list of parcels

            // Add test data to list
            parcels.Add(l1);
            parcels.Add(l2);
            parcels.Add(l3);

            // Display data
            Console.WriteLine("Program 0 - List of Parcels\n\n");

            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("--------------------");
            }

            //New Ground packagages
            GroundPackage gp1 = new GroundPackage(a1, a3, 10, 20, 30, 40);
            GroundPackage gp2 = new GroundPackage(a2, a4, 3, 6, 9, 12);

            //New next day air packages
            NextDayAirPackage ndap1 = new NextDayAirPackage(a2, a3, 2, 4, 6, 8, 1.5M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a4, a1, 5, 10, 15, 20, 2.0M);

            //New two day air packages
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a3, a2, 1, 3, 5, 7, TwoDayAirPackage.Delivery.Early);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a1, a4, 50, 40, 30, 20, TwoDayAirPackage.Delivery.Saver);

            //Test list of packages
            List<Package> packages = new List<Package>();
            packages.Add(gp1);
            packages.Add(gp2);
            packages.Add(ndap1);
            packages.Add(ndap2);
            packages.Add(tdap1);
            packages.Add(tdap2);

            //Display data
            Console.WriteLine("Program 1A - List of Packages \n\n");

            foreach (Package pckg in packages)
            {
                Console.WriteLine(pckg);
                Console.WriteLine("--------------------");
            }
        }
    }
}
