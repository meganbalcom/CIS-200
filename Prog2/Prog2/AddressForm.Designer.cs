namespace Prog2
{
    partial class AddressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.addressLine1TxtBx = new System.Windows.Forms.TextBox();
            this.address2TxtBx = new System.Windows.Forms.TextBox();
            this.cityTxtBx = new System.Windows.Forms.TextBox();
            this.zipTxtBx = new System.Windows.Forms.TextBox();
            this.stateComboBx = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLine1Lbl = new System.Windows.Forms.Label();
            this.AddressLn2Lbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.stateLbl = new System.Windows.Forms.Label();
            this.zipLbl = new System.Windows.Forms.Label();
            this.addAddressBtn = new System.Windows.Forms.Button();
            this.addressCancelBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(150, 27);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 0;
            this.nameTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTxtBox_Validating);
            this.nameTxtBox.Validated += new System.EventHandler(this.nameTxtBox_Validated);
            // 
            // addressLine1TxtBx
            // 
            this.addressLine1TxtBx.Location = new System.Drawing.Point(152, 64);
            this.addressLine1TxtBx.Name = "addressLine1TxtBx";
            this.addressLine1TxtBx.Size = new System.Drawing.Size(100, 20);
            this.addressLine1TxtBx.TabIndex = 1;
            this.addressLine1TxtBx.Validating += new System.ComponentModel.CancelEventHandler(this.addressLineTxtBox_Validating);
            this.addressLine1TxtBx.Validated += new System.EventHandler(this.addressLineTxtBox_Validated);
            // 
            // address2TxtBx
            // 
            this.address2TxtBx.Location = new System.Drawing.Point(152, 103);
            this.address2TxtBx.Name = "address2TxtBx";
            this.address2TxtBx.Size = new System.Drawing.Size(100, 20);
            this.address2TxtBx.TabIndex = 2;
            // 
            // cityTxtBx
            // 
            this.cityTxtBx.Location = new System.Drawing.Point(152, 145);
            this.cityTxtBx.Name = "cityTxtBx";
            this.cityTxtBx.Size = new System.Drawing.Size(100, 20);
            this.cityTxtBx.TabIndex = 3;
            this.cityTxtBx.Validating += new System.ComponentModel.CancelEventHandler(this.cityTxtBx_Validating);
            this.cityTxtBx.Validated += new System.EventHandler(this.cityTxtBx_Validated);
            // 
            // zipTxtBx
            // 
            this.zipTxtBx.Location = new System.Drawing.Point(152, 226);
            this.zipTxtBx.Name = "zipTxtBx";
            this.zipTxtBx.Size = new System.Drawing.Size(100, 20);
            this.zipTxtBx.TabIndex = 4;
            this.zipTxtBx.Validating += new System.ComponentModel.CancelEventHandler(this.zipTxtBx_Validating);
            // 
            // stateComboBx
            // 
            this.stateComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBx.FormattingEnabled = true;
            this.stateComboBx.Items.AddRange(new object[] {
            "Kentucky",
            "Ohio",
            "Virginia",
            "Michigan",
            "New York"});
            this.stateComboBx.Location = new System.Drawing.Point(152, 184);
            this.stateComboBx.Name = "stateComboBx";
            this.stateComboBx.Size = new System.Drawing.Size(121, 21);
            this.stateComboBx.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(96, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name:";
            // 
            // addressLine1Lbl
            // 
            this.addressLine1Lbl.AutoSize = true;
            this.addressLine1Lbl.Location = new System.Drawing.Point(54, 67);
            this.addressLine1Lbl.Name = "addressLine1Lbl";
            this.addressLine1Lbl.Size = new System.Drawing.Size(80, 13);
            this.addressLine1Lbl.TabIndex = 7;
            this.addressLine1Lbl.Text = "Address Line 1:";
            // 
            // AddressLn2Lbl
            // 
            this.AddressLn2Lbl.AutoSize = true;
            this.AddressLn2Lbl.Location = new System.Drawing.Point(54, 106);
            this.AddressLn2Lbl.Name = "AddressLn2Lbl";
            this.AddressLn2Lbl.Size = new System.Drawing.Size(80, 13);
            this.AddressLn2Lbl.TabIndex = 8;
            this.AddressLn2Lbl.Text = "Address Line 2:";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(107, 145);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(27, 13);
            this.cityLbl.TabIndex = 9;
            this.cityLbl.Text = "City:";
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Location = new System.Drawing.Point(99, 184);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(35, 13);
            this.stateLbl.TabIndex = 10;
            this.stateLbl.Text = "State:";
            // 
            // zipLbl
            // 
            this.zipLbl.AutoSize = true;
            this.zipLbl.Location = new System.Drawing.Point(109, 226);
            this.zipLbl.Name = "zipLbl";
            this.zipLbl.Size = new System.Drawing.Size(25, 13);
            this.zipLbl.TabIndex = 11;
            this.zipLbl.Text = "Zip:";
            // 
            // addAddressBtn
            // 
            this.addAddressBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addAddressBtn.Location = new System.Drawing.Point(90, 266);
            this.addAddressBtn.Name = "addAddressBtn";
            this.addAddressBtn.Size = new System.Drawing.Size(93, 37);
            this.addAddressBtn.TabIndex = 12;
            this.addAddressBtn.Text = "Add Address";
            this.addAddressBtn.UseVisualStyleBackColor = true;
            this.addAddressBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addressCancelBtn
            // 
            this.addressCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addressCancelBtn.Location = new System.Drawing.Point(226, 266);
            this.addressCancelBtn.Name = "addressCancelBtn";
            this.addressCancelBtn.Size = new System.Drawing.Size(94, 37);
            this.addressCancelBtn.TabIndex = 14;
            this.addressCancelBtn.Text = "Cancel";
            this.addressCancelBtn.UseVisualStyleBackColor = true;
            this.addressCancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 339);
            this.Controls.Add(this.addressCancelBtn);
            this.Controls.Add(this.addAddressBtn);
            this.Controls.Add(this.zipLbl);
            this.Controls.Add(this.stateLbl);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.AddressLn2Lbl);
            this.Controls.Add(this.addressLine1Lbl);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.stateComboBx);
            this.Controls.Add(this.zipTxtBx);
            this.Controls.Add(this.cityTxtBx);
            this.Controls.Add(this.address2TxtBx);
            this.Controls.Add(this.addressLine1TxtBx);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox addressLine1TxtBx;
        private System.Windows.Forms.TextBox address2TxtBx;
        private System.Windows.Forms.TextBox cityTxtBx;
        private System.Windows.Forms.TextBox zipTxtBx;
        private System.Windows.Forms.ComboBox stateComboBx;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLine1Lbl;
        private System.Windows.Forms.Label AddressLn2Lbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.Label zipLbl;
        private System.Windows.Forms.Button addAddressBtn;
        private System.Windows.Forms.Button addressCancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}