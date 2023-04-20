namespace mschreiber_Software2_c969Project
{
    partial class CreateNewAppointment
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
            this.btn_SaveAppointment = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_CustFirstName = new System.Windows.Forms.Label();
            this.txt_CustFirstName = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_CustLastName = new System.Windows.Forms.TextBox();
            this.lbl_CustLastName = new System.Windows.Forms.Label();
            this.lbl_PhoneNumberValidation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SaveAppointment
            // 
            this.btn_SaveAppointment.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_SaveAppointment.Location = new System.Drawing.Point(18, 354);
            this.btn_SaveAppointment.Name = "btn_SaveAppointment";
            this.btn_SaveAppointment.Size = new System.Drawing.Size(224, 75);
            this.btn_SaveAppointment.TabIndex = 0;
            this.btn_SaveAppointment.Text = "Save New Appointment";
            this.btn_SaveAppointment.UseVisualStyleBackColor = true;
            this.btn_SaveAppointment.Click += new System.EventHandler(this.SaveNewAppointment);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(272, 354);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(224, 75);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(14, 274);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(154, 23);
            this.lbl_PhoneNumber.TabIndex = 2;
            this.lbl_PhoneNumber.Text = "Phone Number";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Address.Location = new System.Drawing.Point(14, 121);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(94, 23);
            this.lbl_Address.TabIndex = 3;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_City.Location = new System.Drawing.Point(14, 174);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(58, 23);
            this.lbl_City.TabIndex = 4;
            this.lbl_City.Text = "City";
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Country.Location = new System.Drawing.Point(14, 228);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(94, 23);
            this.lbl_Country.TabIndex = 5;
            this.lbl_Country.Text = "Country";
            // 
            // lbl_CustFirstName
            // 
            this.lbl_CustFirstName.AutoSize = true;
            this.lbl_CustFirstName.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_CustFirstName.Location = new System.Drawing.Point(12, 32);
            this.lbl_CustFirstName.Name = "lbl_CustFirstName";
            this.lbl_CustFirstName.Size = new System.Drawing.Size(130, 23);
            this.lbl_CustFirstName.TabIndex = 6;
            this.lbl_CustFirstName.Text = "First Name";
            // 
            // txt_CustFirstName
            // 
            this.txt_CustFirstName.Location = new System.Drawing.Point(183, 35);
            this.txt_CustFirstName.Name = "txt_CustFirstName";
            this.txt_CustFirstName.Size = new System.Drawing.Size(313, 22);
            this.txt_CustFirstName.TabIndex = 7;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(183, 124);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(313, 22);
            this.txt_Address.TabIndex = 8;
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(183, 177);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(313, 22);
            this.txt_City.TabIndex = 9;
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(183, 231);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(313, 22);
            this.txt_Country.TabIndex = 10;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(183, 277);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(313, 22);
            this.txt_PhoneNumber.TabIndex = 11;
            // 
            // txt_CustLastName
            // 
            this.txt_CustLastName.Location = new System.Drawing.Point(183, 67);
            this.txt_CustLastName.Name = "txt_CustLastName";
            this.txt_CustLastName.Size = new System.Drawing.Size(313, 22);
            this.txt_CustLastName.TabIndex = 12;
            // 
            // lbl_CustLastName
            // 
            this.lbl_CustLastName.AutoSize = true;
            this.lbl_CustLastName.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_CustLastName.Location = new System.Drawing.Point(12, 64);
            this.lbl_CustLastName.Name = "lbl_CustLastName";
            this.lbl_CustLastName.Size = new System.Drawing.Size(118, 23);
            this.lbl_CustLastName.TabIndex = 13;
            this.lbl_CustLastName.Text = "Last Name";
            // 
            // lbl_PhoneNumberValidation
            // 
            this.lbl_PhoneNumberValidation.AutoSize = true;
            this.lbl_PhoneNumberValidation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_PhoneNumberValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_PhoneNumberValidation.Location = new System.Drawing.Point(125, 302);
            this.lbl_PhoneNumberValidation.Name = "lbl_PhoneNumberValidation";
            this.lbl_PhoneNumberValidation.Size = new System.Drawing.Size(334, 34);
            this.lbl_PhoneNumberValidation.TabIndex = 14;
            this.lbl_PhoneNumberValidation.Text = "Phone number format shoul must be numbers only. \r\nFor example, 555 555 5555";
            this.lbl_PhoneNumberValidation.Click += new System.EventHandler(this.lbl_PhoneNumberValidation_Click);
            // 
            // CreateNewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(511, 443);
            this.Controls.Add(this.lbl_PhoneNumberValidation);
            this.Controls.Add(this.lbl_CustLastName);
            this.Controls.Add(this.txt_CustLastName);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_CustFirstName);
            this.Controls.Add(this.lbl_CustFirstName);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_PhoneNumber);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_SaveAppointment);
            this.Name = "CreateNewAppointment";
            this.Text = "Create New Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveAppointment;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_CustFirstName;
        private System.Windows.Forms.TextBox txt_CustFirstName;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txt_CustLastName;
        private System.Windows.Forms.Label lbl_CustLastName;
        private System.Windows.Forms.Label lbl_PhoneNumberValidation;
    }
}