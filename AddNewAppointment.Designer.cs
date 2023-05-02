namespace mschreiber_Software2_c969Project
{
    partial class AddNewAppointment
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
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.lbl_CustFirstName = new System.Windows.Forms.Label();
            this.txt_CustFirstName = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.txt_Time = new System.Windows.Forms.TextBox();
            this.txt_CustLastName = new System.Windows.Forms.TextBox();
            this.lbl_CustLastName = new System.Windows.Forms.Label();
            this.lbl_NewAppointmentHeader = new System.Windows.Forms.Label();
            this.lbl_appointmentDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SaveAppointment
            // 
            this.btn_SaveAppointment.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_SaveAppointment.Location = new System.Drawing.Point(19, 558);
            this.btn_SaveAppointment.Name = "btn_SaveAppointment";
            this.btn_SaveAppointment.Size = new System.Drawing.Size(224, 75);
            this.btn_SaveAppointment.TabIndex = 0;
            this.btn_SaveAppointment.Text = "Create New Appointment";
            this.btn_SaveAppointment.UseVisualStyleBackColor = true;
            this.btn_SaveAppointment.Click += new System.EventHandler(this.SaveNewAppointment);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(259, 558);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(224, 75);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Time.Location = new System.Drawing.Point(27, 461);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(238, 23);
            this.lbl_Time.TabIndex = 2;
            this.lbl_Time.Text = "Time of Appointment";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Type.Location = new System.Drawing.Point(27, 246);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(238, 23);
            this.lbl_Type.TabIndex = 3;
            this.lbl_Type.Text = "Type of Appointment";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Date.Location = new System.Drawing.Point(27, 394);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(346, 23);
            this.lbl_Date.TabIndex = 4;
            this.lbl_Date.Text = "Date (use mm/dd/yyyy format)";
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Location.Location = new System.Drawing.Point(27, 319);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(298, 23);
            this.lbl_Location.TabIndex = 5;
            this.lbl_Location.Text = "Location (ex. Lunchroom)";
            // 
            // lbl_CustFirstName
            // 
            this.lbl_CustFirstName.AutoSize = true;
            this.lbl_CustFirstName.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_CustFirstName.Location = new System.Drawing.Point(27, 60);
            this.lbl_CustFirstName.Name = "lbl_CustFirstName";
            this.lbl_CustFirstName.Size = new System.Drawing.Size(130, 23);
            this.lbl_CustFirstName.TabIndex = 6;
            this.lbl_CustFirstName.Text = "First Name";
            // 
            // txt_CustFirstName
            // 
            this.txt_CustFirstName.Location = new System.Drawing.Point(31, 86);
            this.txt_CustFirstName.Name = "txt_CustFirstName";
            this.txt_CustFirstName.Size = new System.Drawing.Size(313, 22);
            this.txt_CustFirstName.TabIndex = 7;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(31, 285);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(313, 22);
            this.txt_Address.TabIndex = 8;
            // 
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(31, 420);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(466, 22);
            this.txt_Date.TabIndex = 9;
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(31, 359);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(466, 22);
            this.txt_Country.TabIndex = 10;
            // 
            // txt_Time
            // 
            this.txt_Time.Location = new System.Drawing.Point(31, 487);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(466, 22);
            this.txt_Time.TabIndex = 11;
            // 
            // txt_CustLastName
            // 
            this.txt_CustLastName.Location = new System.Drawing.Point(31, 151);
            this.txt_CustLastName.Name = "txt_CustLastName";
            this.txt_CustLastName.Size = new System.Drawing.Size(313, 22);
            this.txt_CustLastName.TabIndex = 12;
            // 
            // lbl_CustLastName
            // 
            this.lbl_CustLastName.AutoSize = true;
            this.lbl_CustLastName.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_CustLastName.Location = new System.Drawing.Point(27, 125);
            this.lbl_CustLastName.Name = "lbl_CustLastName";
            this.lbl_CustLastName.Size = new System.Drawing.Size(118, 23);
            this.lbl_CustLastName.TabIndex = 13;
            this.lbl_CustLastName.Text = "Last Name";
            // 
            // lbl_NewAppointmentHeader
            // 
            this.lbl_NewAppointmentHeader.AutoSize = true;
            this.lbl_NewAppointmentHeader.Font = new System.Drawing.Font("OCR A Extended", 24F);
            this.lbl_NewAppointmentHeader.Location = new System.Drawing.Point(12, 9);
            this.lbl_NewAppointmentHeader.Name = "lbl_NewAppointmentHeader";
            this.lbl_NewAppointmentHeader.Size = new System.Drawing.Size(623, 51);
            this.lbl_NewAppointmentHeader.TabIndex = 32;
            this.lbl_NewAppointmentHeader.Text = "Customer Information";
            // 
            // lbl_appointmentDetails
            // 
            this.lbl_appointmentDetails.AutoSize = true;
            this.lbl_appointmentDetails.Font = new System.Drawing.Font("OCR A Extended", 24F);
            this.lbl_appointmentDetails.Location = new System.Drawing.Point(24, 196);
            this.lbl_appointmentDetails.Name = "lbl_appointmentDetails";
            this.lbl_appointmentDetails.Size = new System.Drawing.Size(474, 41);
            this.lbl_appointmentDetails.TabIndex = 33;
            this.lbl_appointmentDetails.Text = "Appointment Details";
            // 
            // AddNewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(515, 649);
            this.Controls.Add(this.lbl_appointmentDetails);
            this.Controls.Add(this.lbl_NewAppointmentHeader);
            this.Controls.Add(this.lbl_CustLastName);
            this.Controls.Add(this.txt_CustLastName);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_CustFirstName);
            this.Controls.Add(this.lbl_CustFirstName);
            this.Controls.Add(this.lbl_Location);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_SaveAppointment);
            this.Name = "AddNewAppointment";
            this.Text = "Create New Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveAppointment;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Label lbl_CustFirstName;
        private System.Windows.Forms.TextBox txt_CustFirstName;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.TextBox txt_Time;
        private System.Windows.Forms.TextBox txt_CustLastName;
        private System.Windows.Forms.Label lbl_CustLastName;
        private System.Windows.Forms.Label lbl_NewAppointmentHeader;
        private System.Windows.Forms.Label lbl_appointmentDetails;
    }
}