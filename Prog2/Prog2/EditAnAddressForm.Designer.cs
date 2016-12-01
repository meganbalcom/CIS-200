namespace Prog2
{
    partial class EditAnAddressForm
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
            this.editAdLbl = new System.Windows.Forms.Label();
            this.editAdComboBx = new System.Windows.Forms.ComboBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editAdLbl
            // 
            this.editAdLbl.AutoSize = true;
            this.editAdLbl.Location = new System.Drawing.Point(53, 57);
            this.editAdLbl.Name = "editAdLbl";
            this.editAdLbl.Size = new System.Drawing.Size(200, 13);
            this.editAdLbl.TabIndex = 0;
            this.editAdLbl.Text = "Select the address you would like to edit:";
            // 
            // editAdComboBx
            // 
            this.editAdComboBx.FormattingEnabled = true;
            this.editAdComboBx.Location = new System.Drawing.Point(87, 87);
            this.editAdComboBx.Name = "editAdComboBx";
            this.editAdComboBx.Size = new System.Drawing.Size(121, 21);
            this.editAdComboBx.TabIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(44, 180);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(178, 180);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // EditAnAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.editAdComboBx);
            this.Controls.Add(this.editAdLbl);
            this.Name = "EditAnAddressForm";
            this.Text = "EditAnAddressForm";
            this.Load += new System.EventHandler(this.EditAnAddressForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editAdLbl;
        private System.Windows.Forms.ComboBox editAdComboBx;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}