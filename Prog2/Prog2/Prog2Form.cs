// Program 3
// CIS 200
// Summer 2015
// Due: 6/22/2015
// By: Megan Balcom
// with significant assistance from Andrew L. Wright

// File: Prog3Form.cs
// This class creates the main GUI for Program 3. It provides a
// menu strip items that allow a user to edit addresses, insert parcels,
// open addresses from files, save addresses to files and display reports about
// addresses and parcels. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; // Allows reading and writing to files and data streams
using System.Runtime.Serialization.Formatters.Binary; // Allows binary formatter to work
using System.Runtime.Serialization; // Allows serialization to occur 

namespace Prog2
{
    public partial class Prog2Form : Form
    {
        private List<Address> addressList; // The list of addresses
        private List<Parcel> parcelList;   // The list of parcels

        private StreamReader fileReader; // reads data from a text file 
        private BinaryFormatter formatter = new BinaryFormatter(); // Object for serializing RecordSerializabes     
                                                                   // in binary format
        private FileStream output; // stream for writing to a file 
        private FileStream input; // stream for connection to file

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test addresses are
        //                added to the list of addresses
        public Prog2Form()
        {
            InitializeComponent();

            addressList = new List<Address>();
            parcelList = new List<Parcel>();

        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Program 3{0}By: Megan Balcom{0}" +
                "CIS 200{0}Summer 2015", Environment.NewLine), "About Program 3");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Insert, Address menu item activated
        // Postcondition: The Address dialog box is displayed. If data entered
        //                are OK, an Address is created and added to the list
        //                of addresses
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm(); // The address dialog box form
            DialogResult result = addressForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    Address newAddress = new Address(addressForm.AddressName, addressForm.Address1,
                        addressForm.Address2, addressForm.City, addressForm.State,
                        int.Parse(addressForm.ZipText)); // Use form's properties to create address
                    addressList.Add(newAddress);
                }
                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Address Validation!", "Validation Error");
                }
            }

            addressForm.Dispose(); // Best practice for dialog boxes
        }

        // Precondition:  Report, List Addresses menu item activated
        // Postcondition: The list of addresses is displayed in the addressResultsTxt
        //                text box
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        

            result.Append("Addresses:");
            result.Append(Environment.NewLine); 
            result.Append(Environment.NewLine);

            foreach (Address a in addressList)
            {
                result.Append(a.ToString());
                result.Append(Environment.NewLine);
                result.Append(Environment.NewLine);
            }

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        // Precondition:  Insert, Letter menu item activated
        // Postcondition: The Letter dialog box is displayed. If data entered
        //                are OK, a Letter is created and added to the list
        //                of parcels
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm; // The letter dialog box form
            DialogResult result;   // The result of showing form as dialog

            if (addressList.Count < LetterForm.MIN_ADDRESSES) // Make sure we have enough addresses
            {
                MessageBox.Show("Need " + LetterForm.MIN_ADDRESSES + " addresses to create letter!",
                    "Addresses Error");
                return;
            }

            letterForm = new LetterForm(addressList); // Send list of addresses
            result = letterForm.ShowDialog();

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    // For this to work, LetterForm's combo boxes need to be in same
                    // order as addressList
                    Letter newLetter = new Letter(addressList[letterForm.OriginAddressIndex],
                        addressList[letterForm.DestinationAddressIndex],
                        decimal.Parse(letterForm.FixedCostText)); // Letter to be inserted
                    parcelList.Add(newLetter);
                }
                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Letter Validation!", "Validation Error");
                }
            }

            letterForm.Dispose(); // Best practice for dialog boxes
        }

        // Precondition:  Report, List Parcels menu item activated
        // Postcondition: The list of parcels is displayed in the parcelResultsTxt
        //                text box
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            decimal totalCost = 0;                      // Running total of parcel shipping costs

            result.Append("Parcels:");
            result.Append(Environment.NewLine); 
            result.Append(Environment.NewLine);

            foreach (Parcel p in parcelList)
            {
                result.Append(p.ToString());
                result.Append(Environment.NewLine);
                result.Append(Environment.NewLine);
                totalCost += p.CalcCost();
            }

            result.Append("------------------------------");
            result.Append(Environment.NewLine);
            result.Append(String.Format("Total Cost: {0:C}", totalCost));

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }
        // Precondition: "Open Addresses" menu strip item is activated
        // Postcondition: The file explorer opens and allows the user to select the
        //                file they want to input data from. 
    
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //  Create and show the dialog box that enables the user to open file
            DialogResult result; // Result of OpenFileDialog
            string fileName; // Name of variable data is stored in 

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; // Get specified name
            }

            // Ensure that the user clicked "OK"
            if ( result == DialogResult.OK)
            {
                if (fileName == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        // Create FileStream to obtain read access to fil
                        FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);

                        // Set file from where data is read
                        fileReader = new StreamReader(input);
                        addressList = (List<Address>)formatter.Deserialize(input); //get the next List<Address>
                                                                                  // available in the file
                    }
                    catch (IOException) // Handle exception when file can't be read
                    {
                        MessageBox.Show("Error reading from file", "File Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
         
       }
        // Precondition: "Save Address" menu item is activated
        // Postcondition: The file explorer opens and allows the user to save the
        //                file they where to export the data to. 
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Create and show dialog box that enables user to save file 
            DialogResult result; // Result of SaveFileDialog
            string fileName; // Name of file to save data to
       
            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false; // allows the user to create a file

                // Retrieve the result of the dialog box
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            // Ensures that the user clicked OK
            if (result == DialogResult.OK)
            {
                // Display the error if user specified invalid file
                if (fileName == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // Save file via FileStream if user specified valid file
                    try
                    {
                        output = new FileStream(fileName, FileMode.Create, FileAccess.Write); // Create file with write access

                        formatter = new BinaryFormatter(); // Binary formatter  
                        formatter.Serialize(output, addressList); // Write address to FileStream (serialize object)

                    }
                    

                    // Notify the user if an error occurs during serialization
                    catch (SerializationException)
                    {
                        MessageBox.Show("Error Writing to File", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    catch (FormatException) // Notify the user if there's an error about the 
                    // parameter format
                    {
                        MessageBox.Show("Non-valid format", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Notify the user if IO exception occurs during saving 
                    catch (IOException)
                    {
                        MessageBox.Show("IO Error", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally 
                    {
                        if (output != null)
                        output.Close();
                    }
                    
                }
            }
        }
        // Precondition: "Edit Address" menu item is activated
        // Postcondition: The EditAnAddressForm appears and allows the user to select the
        //                address they want to edit. Then, the AddressForm is populated
        //                with the respective data and can be edited. 
  
        private void addressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditAnAddressForm editAddress = new EditAnAddressForm(addressList); // Address that will be edited
            DialogResult result1 = editAddress.ShowDialog(); // Result of OpenFileDialog
            
           
            if (result1 == DialogResult.OK) 
            {
                int index = editAddress.EditAddressIndex; // holds the position selected
                Address a = addressList[index]; //the address the user chooses
                AddressForm addressForm = new AddressForm(); // create a new addressForm object
                
                // Assign the field values according to the address selected            
                addressForm.AddressName = a.Name;
                addressForm.Address1 = a.Address1;
                addressForm.Address2 = a.Address2;
                addressForm.City = a.City;
                addressForm.stateCbo.SelectedItem = a.State;
                addressForm.ZipText = a.Zip.ToString();

            DialogResult result2 = addressForm.ShowDialog(); // Result of selecting an address to edit
            if (result2 == DialogResult.OK)
            {
                // Populate the fields of the AddressForm with the data
                a.Name = addressForm.AddressName; 
                a.Address1 = addressForm.Address1;
                a.Address2 = addressForm.Address2;
                a.City = addressForm.City;
                a.State = addressForm.stateCbo.SelectedItem.ToString();
                a.Zip = int.Parse(addressForm.ZipText);
            }
          }
      }
   }
}
