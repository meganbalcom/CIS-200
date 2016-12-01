// Megan Balcom
// CIS 200-10
// Program 2 
// June 11, 2015
// This class allows users to create new letter parcels and have them be added to the list in the main form
// which will display in a report of parcels 

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
    public partial class LetterForm : Form
    {
        private decimal _fixedCost; //variable holds the backing field for fixed cost property

        public LetterForm(List<Address> listOfAddress) //list being brought over from the constructor 
        {
            InitializeComponent();

            newListOfAddreses = listOfAddress; //the new list of addresses will be added into original list
        }
        
        private List<Address> newListOfAddreses { get; set; } //list that holds the addresses that exist in the letter form 
        
        //Pre: None
        //Post: Array adds each address item and displays it in the combo box by Name
        private void LetterForm_Load(object sender, EventArgs e)
        {
            foreach (var a in newListOfAddreses)
            {
                originAddressComboBx.Items.Add(a.Name); //Add the address to the combo box and display by name
                destAddressComboBox.Items.Add(a.Name); //Add the address to the combo box and display by name
            }
        }    
    
        public decimal FixedCost
        {
            //Pre:None
            //Post: A fixed cost value has been returned
            get { 
                return _fixedCost;
            }
            //Pre: Value has to be greater than 0
            //Post: The fixed cost is set to a specified value 
            set
            {
                if (value > 0)
                {
                    _fixedCost = decimal.Parse(fixedCostTxtBox.Text); 
                    _fixedCost = value;
                }
            }
        }
        //Precondition: None
        //Postcondition: value is either valid or needs altered
        private void fixedCostTxtBx_Validating(object sender, CancelEventArgs e)
        {
            decimal enteredCost = decimal.Parse(fixedCostTxtBox.Text); //holds entered zipcode

            if (string.IsNullOrWhiteSpace(fixedCostTxtBox.Text)) //if there's null or whitespace...
            {
                e.Cancel = true;
                errorProvider1.SetError(fixedCostTxtBox, "You must enter a value for this field."); //prevent user from continuing
            }
            else
            {
                if (!decimal.TryParse(fixedCostTxtBox.Text, out enteredCost)) //if the data can't be parsed...
                {
                    errorProvider2.SetError(fixedCostTxtBox, "Please enter a numeric value."); //prevent user from continuing
                    e.Cancel = true;
                }
            }
        }
        
        public int originComboSelectedItem 
        {
            //Precondition: None
            //Postcondition: an idex position has been returned
            get { return originAddressComboBx.SelectedIndex; }
            //Precondition: None
            //Postcondition: selected item has been set to a specified value
            set { originAddressComboBx.SelectedItem = value; }
        }
        public int destComboSelectedItem
        {
            //Precondition: none
            //Postcondition: an  index position has been returned 
            get { return destAddressComboBox.SelectedIndex; }
            //Precondition: none
            //Postcondition: selected item has been set to a specified value 
            set { destAddressComboBox.SelectedIndex = value; }
        }
        //Precondition: None
        //Postcondition: a value is either valid or needs altered
        private void originAddressComboBx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(originAddressComboBx.Text))
            {
                errorProvider1.SetError(originAddressComboBx, "Address cannot be the same."); //prevent user from continuing
                e.Cancel = true;
            }
            else if (originAddressComboBx.SelectedIndex == -1) //check to see if it's in the array 
            {
                e.Cancel = true;
            }
        }
        
        private void originAddressComboBx_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(originAddressComboBx, "");
        }
        
        private void fixedCostTxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(originAddressComboBx, "");
        }
        //Precondition: Add letter button was clicked 
        //Postcondition: children on form are validated
        private void addLetterBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        //Precondition: Mouse down was clicked
        //Postcondition: The cancel dialog even is fired 
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
                this.DialogResult = DialogResult.Cancel;    
        }
        
    }
}
