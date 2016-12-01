// Megan Balcom
// CIS 200-10
// Program 2 
// June 11, 2015
// This form allows users to create a new address which will be added to a list of addresses, and can be 
// selected as either an origin or destination address. 

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
    public partial class AddressForm : Form
    {
        //Precondition
        //Postcondition
        public AddressForm()
        {
            InitializeComponent();
        }
        //Precondition: user clicked "add address" btn
        //Postcondition
        private void button1_Click(object sender, EventArgs e) //Add Address Button
        {
            if (this.ValidateChildren())
                this.DialogResult = System.Windows.Forms.DialogResult.OK; //if all the fields are validated, the dialog
                                                                         //result is "OK"
        }
        public string NameAddressForm
        {
            //Precondition: None
            //Postcondition: The string in text box is retrieved 
            get { return nameTxtBox.Text; }

            //Precondition: None
            //Postcondition: The string in the text box is set to a specified value
            set { nameTxtBox.Text = value; }
        }
        //Precondition: 
        //Postcondition:
        private void nameTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTxtBox.Text)) //If the text box is null or white space...
            {
                e.Cancel = true;                           
                errorProvider1.SetError(nameTxtBox, "Textbox cannot be empty."); //Show error and prevent user from continuing
            }
        }
        //
        //
        public string AddressLine1
        {
            //precondition
            //postcondition
            get { return addressLine1TxtBx.Text; }
            //Precondition
            //postcondition
            set { addressLine1TxtBx.Text = value; }
        }
        //Pre: None
        //Post: The input is either validated or needs altered by the user
        private void addressLineTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressLine1TxtBx.Text))// if the textbox is null or white space...
            {
                e.Cancel = true;
                errorProvider1.SetError(addressLine1TxtBx, "Textbox cannot be empty."); //prevent user from continuing
            }
        }
        public string AddressLine2
        {
            //Precondition: None
            //Postcondition: The address line has been returned
            get { return address2TxtBx.Text; }
            //Precondition: None
            //Postcondition: The address line is set to a specific value
            set { address2TxtBx.Text = value; }
        }
        //Delete in designer.cs
        private void address2TxtBox_Validating(object sender, CancelEventArgs e)
        {
            //Address line 2 doesn't need validating
        }
        public string City
        {
            //Precondition: None
            //Postcondition: The city has been returned
            get { return cityTxtBx.Text; }
            //Precondition: None
            //Postcondition: The city name is set to a specific value
            set { cityTxtBx.Text = value; }
        }
        //Pre: None
        //Post: The input is either validated or needs altered by user 
        private void cityTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cityTxtBx.Text)) //if the textbox is null or empty...
            {
                e.Cancel = true;
                errorProvider1.SetError(cityTxtBx, "Textbox cannot be empty."); //prevent user from continuing
            }
        }
        public string State
        {
            //Precondition: None
            //Postcondition: A selected state item has been returned
            get { return (string)stateComboBx.SelectedItem; }
        }

        public int Zip
        {
            //precondition: None
            //postcondition: A zipcode value has been returned
            get { return int.Parse(zipTxtBx.Text); }
            //precondition: None
            //postcondition: The zipcode has been set to a specific value 
            set { zipTxtBx.Text = value.ToString(); }
        }
        //Pre: None
        //Post: The input is either validated or needs altered 
        private void zipTxtBx_Validating(object sender, CancelEventArgs e)
        {
            int enteredZip = int.Parse(zipTxtBx.Text); //holds entered zipcode

            if (!int.TryParse(zipTxtBx.Text, out enteredZip)) //Check to see if the input can be parsed
            {
                errorProvider2.SetError(zipTxtBx, "Enter a numeric value."); //if it can't, prevent user from continuing
                e.Cancel = true;
            }
            else
            {
                const int MIN_ZIP = 00000; //minimum allowed zip code value
                const int MAX_ZIP = 99999; //maximum allowed zip code value
                if (enteredZip <= MIN_ZIP || enteredZip >= MAX_ZIP)
                {
                    errorProvider3.SetError(zipTxtBx, "Enter a zipcode that is not less than 00000 and 99999"); //prevent user from continuing
                    e.Cancel = true;
                }
            }
        }
       
        private void nameTxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(nameTxtBox, "");
        }
        
        private void addressLineTxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(addressLine1TxtBx, "");
        }
       
        private void address2TxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(address2TxtBx, "");
        }
        
        private void cityTxtBx_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cityTxtBx, "");
        }
        
        private void zipTxtBx_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(addressLine1TxtBx, "");
        }
        //Precondition: None
        //Postcondition: A cancel dialog result is fired 
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //if the left mous button is clicked
                this.DialogResult = DialogResult.Cancel; //cancel result occurs 
        }
    }

}
