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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.txt_Time = new System.Windows.Forms.TextBox();
            this.cb_Choices = new System.Windows.Forms.ComboBox();
            this.cb_Location = new System.Windows.Forms.ComboBox();
            this.lbl_UserMeeting = new System.Windows.Forms.Label();
            this.dgv_CustomerData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.lbl_customerID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerData)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SaveAppointment
            // 
            this.btn_SaveAppointment.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_SaveAppointment.Location = new System.Drawing.Point(21, 698);
            this.btn_SaveAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SaveAppointment.Name = "btn_SaveAppointment";
            this.btn_SaveAppointment.Size = new System.Drawing.Size(252, 94);
            this.btn_SaveAppointment.TabIndex = 0;
            this.btn_SaveAppointment.Text = "Create New Appointment";
            this.btn_SaveAppointment.UseVisualStyleBackColor = true;
            this.btn_SaveAppointment.Click += new System.EventHandler(this.SaveNewAppointment);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(291, 698);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(252, 94);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Time.Location = new System.Drawing.Point(16, 622);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(278, 25);
            this.lbl_Time.TabIndex = 2;
            this.lbl_Time.Text = "Time of Appointment";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Type.Location = new System.Drawing.Point(16, 422);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(278, 25);
            this.lbl_Type.TabIndex = 3;
            this.lbl_Type.Text = "Type of Appointment";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Date.Location = new System.Drawing.Point(16, 563);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(404, 25);
            this.lbl_Date.TabIndex = 4;
            this.lbl_Date.Text = "Date (use mm/dd/yyyy format)";
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Location.Location = new System.Drawing.Point(16, 491);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(138, 25);
            this.lbl_Location.TabIndex = 5;
            this.lbl_Location.Text = "Location ";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Title.Location = new System.Drawing.Point(29, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(543, 75);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "What would you like \r\nto call this appointment?";
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(35, 67);
            this.txt_Title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(352, 26);
            this.txt_Title.TabIndex = 7;
            // 
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(21, 592);
            this.txt_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(524, 26);
            this.txt_Date.TabIndex = 9;
            // 
            // txt_Time
            // 
            this.txt_Time.Location = new System.Drawing.Point(21, 651);
            this.txt_Time.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(524, 26);
            this.txt_Time.TabIndex = 11;
            // 
            // cb_Choices
            // 
            this.cb_Choices.AllowDrop = true;
            this.cb_Choices.FormattingEnabled = true;
            this.cb_Choices.Location = new System.Drawing.Point(16, 460);
            this.cb_Choices.Name = "cb_Choices";
            this.cb_Choices.Size = new System.Drawing.Size(422, 28);
            this.cb_Choices.TabIndex = 34;
            // 
            // cb_Location
            // 
            this.cb_Location.AllowDrop = true;
            this.cb_Location.FormattingEnabled = true;
            this.cb_Location.Location = new System.Drawing.Point(21, 532);
            this.cb_Location.Name = "cb_Location";
            this.cb_Location.Size = new System.Drawing.Size(422, 28);
            this.cb_Location.TabIndex = 35;
            // 
            // lbl_UserMeeting
            // 
            this.lbl_UserMeeting.AutoSize = true;
            this.lbl_UserMeeting.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_UserMeeting.Location = new System.Drawing.Point(16, 135);
            this.lbl_UserMeeting.Name = "lbl_UserMeeting";
            this.lbl_UserMeeting.Size = new System.Drawing.Size(404, 25);
            this.lbl_UserMeeting.TabIndex = 36;
            this.lbl_UserMeeting.Text = "Who is the appointment with?";
            // 
            // dgv_CustomerData
            // 
            this.dgv_CustomerData.AllowUserToAddRows = false;
            this.dgv_CustomerData.AllowUserToDeleteRows = false;
            this.dgv_CustomerData.AllowUserToResizeRows = false;
            this.dgv_CustomerData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_CustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustomerData.Location = new System.Drawing.Point(21, 178);
            this.dgv_CustomerData.Name = "dgv_CustomerData";
            this.dgv_CustomerData.ReadOnly = true;
            this.dgv_CustomerData.RowHeadersWidth = 62;
            this.dgv_CustomerData.RowTemplate.Height = 28;
            this.dgv_CustomerData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CustomerData.Size = new System.Drawing.Size(556, 144);
            this.dgv_CustomerData.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Your appointment is with...";
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Location = new System.Drawing.Point(224, 345);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.ReadOnly = true;
            this.txt_CustomerName.Size = new System.Drawing.Size(191, 26);
            this.txt_CustomerName.TabIndex = 39;
            // 
            // lbl_customerID
            // 
            this.lbl_customerID.AutoSize = true;
            this.lbl_customerID.Location = new System.Drawing.Point(38, 351);
            this.lbl_customerID.Name = "lbl_customerID";
            this.lbl_customerID.Size = new System.Drawing.Size(121, 20);
            this.lbl_customerID.TabIndex = 40;
            this.lbl_customerID.Text = "CUSTOMER ID";
            // 
            // AddNewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(618, 811);
            this.Controls.Add(this.lbl_customerID);
            this.Controls.Add(this.txt_CustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_CustomerData);
            this.Controls.Add(this.lbl_UserMeeting);
            this.Controls.Add(this.cb_Location);
            this.Controls.Add(this.cb_Choices);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Location);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_SaveAppointment);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddNewAppointment";
            this.Text = "Create New Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerData)).EndInit();
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
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.TextBox txt_Time;
        private System.Windows.Forms.ComboBox cb_Choices;
        private System.Windows.Forms.ComboBox cb_Location;
        private System.Windows.Forms.Label lbl_UserMeeting;
        private System.Windows.Forms.DataGridView dgv_CustomerData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.Label lbl_customerID;
    }
}