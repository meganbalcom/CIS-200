// Megan Balcom
// CIS 200-10
// Program 3 
// June 22, 2015
// This class controls the EditAnAddressForm code and requires the user to select at
// least one address in order to edit it. The combo box on the form will display
// the names which correspond to their addresses. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class EditAnAddressForm : Form
    {
        private List<Address> addressList;  // List of addresses used to fill combo boxes 
        public const int MIN_ADDRESSES = 1; // Minimum number of addresses needed
        
        // Precondition:  List addresses is populated with the available
        //                addresses to choose from
        // Postcondition: The form's GUI is prepared for display.
        public EditAnAddressForm(List<Address> addresses)
        {
            InitializeComponent();
            addressList = addresses;
        }
        public int EditAddressIndex
        {
            // Precondition:  User has selected from the editAdComboBx
            // Postcondition: The index of the selected address returned
            get
            {
                return editAdComboBx.SelectedIndex;
            }

            // Precondition:  -1 <= value < addressList.Count
            // Postcondition: The specified index is selected in originAddCbo
            set
            {
                if ((value >= -1) && (value < addressList.Count))
                    editAdComboBx.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException("EditAddressIndex", value,
                        "Index must be valid");
            }
        }
        // Precondition: addressList.Count >= MIN_ADDRESSES
        // Postcondition:The list of addresses is used to populate the
        //                address combo box
        private void EditAnAddressForm_Load(object sender, EventArgs e)
        {
            if (addressList.Count < MIN_ADDRESSES) // Violated precondition!
            {
                MessageBox.Show("Need " + MIN_ADDRESSES + " address to edit an address!",
                    "Addresses Error");
                this.DialogResult = DialogResult.Abort; // Dismiss immediately
            }
            foreach (Address a in addressList)
                editAdComboBx.Items.Add(a.Name);
        }
    }
}
