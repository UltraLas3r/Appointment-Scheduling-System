namespace mschreiber_Software2_c969Project
{
    partial class ModifyAppointment
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_ModifyAppointment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_CustomerID = new System.Windows.Forms.ComboBox();
            this.DT_ScheduleAppointment = new System.Windows.Forms.DateTimePicker();
            this.lbl_UserMeeting = new System.Windows.Forms.Label();
            this.cb_Location = new System.Windows.Forms.ComboBox();
            this.cb_Choices = new System.Windows.Forms.ComboBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(318, 596);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(252, 94);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_ModifyAppointment
            // 
            this.btn_ModifyAppointment.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_ModifyAppointment.Location = new System.Drawing.Point(12, 596);
            this.btn_ModifyAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ModifyAppointment.Name = "btn_ModifyAppointment";
            this.btn_ModifyAppointment.Size = new System.Drawing.Size(252, 94);
            this.btn_ModifyAppointment.TabIndex = 15;
            this.btn_ModifyAppointment.Text = "Update Appointment";
            this.btn_ModifyAppointment.UseVisualStyleBackColor = true;
            this.btn_ModifyAppointment.Click += new System.EventHandler(this.btn_ModifyAppointment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 24F);
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 50);
            this.label1.TabIndex = 32;
            this.label1.Text = "Update Appointment";
            // 
            // cb_CustomerID
            // 
            this.cb_CustomerID.FormattingEnabled = true;
            this.cb_CustomerID.Location = new System.Drawing.Point(19, 235);
            this.cb_CustomerID.Name = "cb_CustomerID";
            this.cb_CustomerID.Size = new System.Drawing.Size(266, 28);
            this.cb_CustomerID.TabIndex = 52;
            // 
            // DT_ScheduleAppointment
            // 
            this.DT_ScheduleAppointment.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.DT_ScheduleAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT_ScheduleAppointment.Location = new System.Drawing.Point(12, 528);
            this.DT_ScheduleAppointment.Name = "DT_ScheduleAppointment";
            this.DT_ScheduleAppointment.Size = new System.Drawing.Size(332, 26);
            this.DT_ScheduleAppointment.TabIndex = 51;
            // 
            // lbl_UserMeeting
            // 
            this.lbl_UserMeeting.AutoSize = true;
            this.lbl_UserMeeting.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_UserMeeting.Location = new System.Drawing.Point(21, 190);
            this.lbl_UserMeeting.Name = "lbl_UserMeeting";
            this.lbl_UserMeeting.Size = new System.Drawing.Size(404, 25);
            this.lbl_UserMeeting.TabIndex = 50;
            this.lbl_UserMeeting.Text = "Who is the appointment with?";
            // 
            // cb_Location
            // 
            this.cb_Location.AllowDrop = true;
            this.cb_Location.FormattingEnabled = true;
            this.cb_Location.Location = new System.Drawing.Point(14, 433);
            this.cb_Location.Name = "cb_Location";
            this.cb_Location.Size = new System.Drawing.Size(422, 28);
            this.cb_Location.TabIndex = 49;
            // 
            // cb_Choices
            // 
            this.cb_Choices.AllowDrop = true;
            this.cb_Choices.FormattingEnabled = true;
            this.cb_Choices.Location = new System.Drawing.Point(15, 360);
            this.cb_Choices.Name = "cb_Choices";
            this.cb_Choices.Size = new System.Drawing.Size(422, 28);
            this.cb_Choices.TabIndex = 48;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(19, 146);
            this.txt_Title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(352, 26);
            this.txt_Title.TabIndex = 47;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Title.Location = new System.Drawing.Point(21, 105);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(250, 25);
            this.lbl_Title.TabIndex = 46;
            this.lbl_Title.Text = "Appointment Title";
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Location.Location = new System.Drawing.Point(14, 405);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(138, 25);
            this.lbl_Location.TabIndex = 45;
            this.lbl_Location.Text = "Location ";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Type.Location = new System.Drawing.Point(10, 315);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(278, 25);
            this.lbl_Type.TabIndex = 44;
            this.lbl_Type.Text = "Type of Appointment";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Time.Location = new System.Drawing.Point(9, 487);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(404, 25);
            this.lbl_Time.TabIndex = 43;
            this.lbl_Time.Text = "Date and Time of Appointment";
            // 
            // ModifyAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(588, 720);
            this.Controls.Add(this.cb_CustomerID);
            this.Controls.Add(this.DT_ScheduleAppointment);
            this.Controls.Add(this.lbl_UserMeeting);
            this.Controls.Add(this.cb_Location);
            this.Controls.Add(this.cb_Choices);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Location);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_ModifyAppointment);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModifyAppointment";
            this.Text = "Update Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_ModifyAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_CustomerID;
        private System.Windows.Forms.DateTimePicker DT_ScheduleAppointment;
        private System.Windows.Forms.Label lbl_UserMeeting;
        private System.Windows.Forms.ComboBox cb_Location;
        private System.Windows.Forms.ComboBox cb_Choices;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Time;
    }
}