namespace Prog2
{
    partial class LetterForm
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
            this.originAddressComboBx = new System.Windows.Forms.ComboBox();
            this.destAddressComboBox = new System.Windows.Forms.ComboBox();
            this.letterOriginAdLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fixedCostLbl = new System.Windows.Forms.Label();
            this.fixedCostTxtBox = new System.Windows.Forms.TextBox();
            this.addLetterBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // originAddressComboBx
            // 
            this.originAddressComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originAddressComboBx.FormattingEnabled = true;
            this.originAddressComboBx.Location = new System.Drawing.Point(140, 43);
            this.originAddressComboBx.Name = "originAddressComboBx";
            this.originAddressComboBx.Size = new System.Drawing.Size(121, 21);
            this.originAddressComboBx.TabIndex = 0;
            this.originAddressComboBx.Validating += new System.ComponentModel.CancelEventHandler(this.originAddressComboBx_Validating);
            this.originAddressComboBx.Validated += new System.EventHandler(this.originAddressComboBx_Validated);
            // 
            // destAddressComboBox
            // 
            this.destAddressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destAddressComboBox.FormattingEnabled = true;
            this.destAddressComboBox.Location = new System.Drawing.Point(140, 102);
            this.destAddressComboBox.Name = "destAddressComboBox";
            this.destAddressComboBox.Size = new System.Drawing.Size(121, 21);
            this.destAddressComboBox.TabIndex = 1;
            // 
            // letterOriginAdLbl
            // 
            this.letterOriginAdLbl.AutoSize = true;
            this.letterOriginAdLbl.Location = new System.Drawing.Point(59, 46);
            this.letterOriginAdLbl.Name = "letterOriginAdLbl";
            this.letterOriginAdLbl.Size = new System.Drawing.Size(78, 13);
            this.letterOriginAdLbl.TabIndex = 2;
            this.letterOriginAdLbl.Text = "Origin Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destination Address:";
            // 
            // fixedCostLbl
            // 
            this.fixedCostLbl.AutoSize = true;
            this.fixedCostLbl.Location = new System.Drawing.Point(79, 163);
            this.fixedCostLbl.Name = "fixedCostLbl";
            this.fixedCostLbl.Size = new System.Drawing.Size(58, 13);
            this.fixedCostLbl.TabIndex = 4;
            this.fixedCostLbl.Text = "Fixed cost:";
            // 
            // fixedCostTxtBox
            // 
            this.fixedCostTxtBox.Location = new System.Drawing.Point(140, 160);
            this.fixedCostTxtBox.Name = "fixedCostTxtBox";
            this.fixedCostTxtBox.Size = new System.Drawing.Size(121, 20);
            this.fixedCostTxtBox.TabIndex = 5;
            this.fixedCostTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.fixedCostTxtBx_Validating);
            this.fixedCostTxtBox.Validated += new System.EventHandler(this.fixedCostTxtBox_Validated);
            // 
            // addLetterBtn
            // 
            this.addLetterBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addLetterBtn.Location = new System.Drawing.Point(36, 212);
            this.addLetterBtn.Name = "addLetterBtn";
            this.addLetterBtn.Size = new System.Drawing.Size(79, 37);
            this.addLetterBtn.TabIndex = 6;
            this.addLetterBtn.Text = "Add Letter";
            this.addLetterBtn.UseVisualStyleBackColor = true;
            this.addLetterBtn.Click += new System.EventHandler(this.addLetterBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(185, 212);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 37);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider3.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addLetterBtn);
            this.Controls.Add(this.fixedCostTxtBox);
            this.Controls.Add(this.fixedCostLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.letterOriginAdLbl);
            this.Controls.Add(this.destAddressComboBox);
            this.Controls.Add(this.originAddressComboBx);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox originAddressComboBx;
        private System.Windows.Forms.ComboBox destAddressComboBox;
        private System.Windows.Forms.Label letterOriginAdLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fixedCostLbl;
        private System.Windows.Forms.TextBox fixedCostTxtBox;
        private System.Windows.Forms.Button addLetterBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}