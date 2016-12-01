// Megan Balcom
// CIS 200-10
// Program 2
// June 11, 2015
// This class holds the lists of addresses and parcels that the two other forms will be sending their data
// to to create new objects and display reports of them, which will appear on this form.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
   
    public partial class prog_2_main_form : Form
    {
       
         public prog_2_main_form()
        {
            InitializeComponent();
        
         // Test Data - made by Dr. Wright
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

            address.Add(a1); //Populate list with addresses
            address.Add(a2);
            address.Add(a3);
            address.Add(a4);
            address.Add(a5);
            address.Add(a6);
            address.Add(a7);
            address.Add(a8);

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);

            parcels.Add(letter1); //populate list with parcels
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);

            
        }
        //Precondition: User clicked "about" menu item
        //Postcondition: Displays a message box with basic information
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Megan Balcom\nCIS 200-10\nProgram 2\nJune 11, 2015");
        }
        //Precondition: User clicked "exit" menu item
        //Postcondition: Closes the entire application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        //Precondition: user clicked on "insert address" menu item
        //Postcondition: a new address is added to the list
        //This click event is adding any valid address object created in the address form 
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AddressForm createdAddress = new AddressForm(); //Creating an AddressForm object so it can be accessed in this class
            DialogResult result = createdAddress.ShowDialog(); //Defines the DialogResult

            if (result == DialogResult.OK) //Referencing the Add Address Button on Address Form 
            //If the dialog result is "ok" create a new address object 
            {
                Address newAddress = new Address(createdAddress.NameAddressForm, createdAddress.AddressLine1,
                    createdAddress.AddressLine2, createdAddress.City, createdAddress.State, createdAddress.Zip);

                    address.Add(newAddress); 
            }
        }
        //Precondition: user clicked "insert letter" menu item 
        //Postcondition: a new letter is added to the list
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm createdLetter = new LetterForm (address); //parameterized constructor 
            DialogResult result = createdLetter.ShowDialog(); //defines the dialog result
            int originIndex = createdLetter.originComboSelectedItem; //variable for what index position was selected in origin combo box
            int destinationIndex = createdLetter.destComboSelectedItem; //variable for what index position was selected in dest combo box

            if (result == DialogResult.OK) //if "Ok" is the dialog result
            {
                Address originAddress = address[originIndex]; 
                Address destinationAddress = address[destinationIndex];
                Letter newLetter = new Letter(originAddress, destinationAddress, createdLetter.FixedCost ); 
                //Creates a new letter object using the index positions of the two addresses and uses the fixed cost
                //entered in the letter form 
               
                parcels.Add(newLetter); //adds a new letter object
            }
        }
        
         List<Address> address = new List<Address>(); //the list that addresses are added to 
         List<Parcel> parcels = new List<Parcel>(); //the list letters are added to (letter is a parcel)

        //Report that displays address list
        //Precondition: User clicked on "list addresses" menu item
        //Postcondition: A report of addresses is displayed
         private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
         {
             displayReportsTxtBox.Clear(); //Clear the text box

             foreach (var ad in address) //Steps through the array of addresses to display them
             {
                 displayReportsTxtBox.AppendText(String.Format("{1}{0}{1}", ad, Environment.NewLine));
             }

         }
        //Precondition: User clicked on "list parcels" menu item
        //Postcondition: A report of parcels is displayed
         private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
         {
             decimal totalCost = 0; //will hold value for total cost
            

             displayReportsTxtBox.Clear(); //clear the text box

             foreach (var p in parcels) //Steps through the array of parcels to display them
             {
                 displayReportsTxtBox.AppendText(String.Format("{1}{0}{1}", p, Environment.NewLine));
                 totalCost += p.CalcCost();
             }
             displayReportsTxtBox.AppendText(String.Format("{0:C}", totalCost)); //displays total cost by itself 
         
         }       
    }
}
       

