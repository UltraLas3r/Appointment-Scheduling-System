namespace mschreiber_Software2_c969Project
{
    partial class MainHomePage
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dgv_AppointmentGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddNewAppointment = new System.Windows.Forms.Button();
            this.btn_ViewAppointments = new System.Windows.Forms.Button();
            this.btn_ModifyAppointment = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_DeleteAppointment = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.btn_UpdateCustomer = new System.Windows.Forms.Button();
            this.lbl_UserLocationAndTime = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AppointmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.radioButton1.Location = new System.Drawing.Point(969, 81);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(199, 27);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "View This week";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.ViewThisWeekRadioButton);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.radioButton2.Location = new System.Drawing.Point(969, 114);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(211, 27);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "View This Month";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.ViewThisMonthRadioButton);
            // 
            // dgv_AppointmentGrid
            // 
            this.dgv_AppointmentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AppointmentGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_AppointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AppointmentGrid.Location = new System.Drawing.Point(12, 224);
            this.dgv_AppointmentGrid.Name = "dgv_AppointmentGrid";
            this.dgv_AppointmentGrid.ReadOnly = true;
            this.dgv_AppointmentGrid.RowHeadersWidth = 51;
            this.dgv_AppointmentGrid.RowTemplate.Height = 24;
            this.dgv_AppointmentGrid.Size = new System.Drawing.Size(1195, 444);
            this.dgv_AppointmentGrid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 24F);
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Upcoming Appointments";
            // 
            // btn_AddNewAppointment
            // 
            this.btn_AddNewAppointment.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_AddNewAppointment.Location = new System.Drawing.Point(28, 116);
            this.btn_AddNewAppointment.Name = "btn_AddNewAppointment";
            this.btn_AddNewAppointment.Size = new System.Drawing.Size(190, 89);
            this.btn_AddNewAppointment.TabIndex = 6;
            this.btn_AddNewAppointment.Text = "Add New Appointment";
            this.btn_AddNewAppointment.UseVisualStyleBackColor = true;
            this.btn_AddNewAppointment.Click += new System.EventHandler(this.CreateNewAppointment_Click);
            // 
            // btn_ViewAppointments
            // 
            this.btn_ViewAppointments.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_ViewAppointments.Location = new System.Drawing.Point(969, 150);
            this.btn_ViewAppointments.Name = "btn_ViewAppointments";
            this.btn_ViewAppointments.Size = new System.Drawing.Size(238, 62);
            this.btn_ViewAppointments.TabIndex = 7;
            this.btn_ViewAppointments.Text = "View Appointments";
            this.btn_ViewAppointments.UseVisualStyleBackColor = true;
            this.btn_ViewAppointments.Click += new System.EventHandler(this.ViewAppointmentsButton_Click);
            // 
            // btn_ModifyAppointment
            // 
            this.btn_ModifyAppointment.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_ModifyAppointment.Location = new System.Drawing.Point(237, 116);
            this.btn_ModifyAppointment.Name = "btn_ModifyAppointment";
            this.btn_ModifyAppointment.Size = new System.Drawing.Size(190, 89);
            this.btn_ModifyAppointment.TabIndex = 8;
            this.btn_ModifyAppointment.Text = "Modify Appointment";
            this.btn_ModifyAppointment.UseVisualStyleBackColor = true;
            this.btn_ModifyAppointment.Click += new System.EventHandler(this.btn_ModifyAppointment_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_Exit.Location = new System.Drawing.Point(1030, 708);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(177, 52);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.MainHomePageExit);
            // 
            // btn_DeleteAppointment
            // 
            this.btn_DeleteAppointment.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_DeleteAppointment.Location = new System.Drawing.Point(448, 117);
            this.btn_DeleteAppointment.Name = "btn_DeleteAppointment";
            this.btn_DeleteAppointment.Size = new System.Drawing.Size(190, 88);
            this.btn_DeleteAppointment.TabIndex = 10;
            this.btn_DeleteAppointment.Text = "Delete Appointment";
            this.btn_DeleteAppointment.UseVisualStyleBackColor = true;
            this.btn_DeleteAppointment.Click += new System.EventHandler(this.DeleteAppointment_Click);
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_AddCustomer.Location = new System.Drawing.Point(12, 674);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(139, 89);
            this.btn_AddCustomer.TabIndex = 11;
            this.btn_AddCustomer.Text = "Add Customer";
            this.btn_AddCustomer.UseVisualStyleBackColor = true;
            this.btn_AddCustomer.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // btn_UpdateCustomer
            // 
            this.btn_UpdateCustomer.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_UpdateCustomer.Location = new System.Drawing.Point(157, 674);
            this.btn_UpdateCustomer.Name = "btn_UpdateCustomer";
            this.btn_UpdateCustomer.Size = new System.Drawing.Size(139, 89);
            this.btn_UpdateCustomer.TabIndex = 12;
            this.btn_UpdateCustomer.Text = "Update Customer";
            this.btn_UpdateCustomer.UseVisualStyleBackColor = true;
            this.btn_UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
            // 
            // lbl_UserLocationAndTime
            // 
            this.lbl_UserLocationAndTime.AutoSize = true;
            this.lbl_UserLocationAndTime.Location = new System.Drawing.Point(966, 9);
            this.lbl_UserLocationAndTime.Name = "lbl_UserLocationAndTime";
            this.lbl_UserLocationAndTime.Size = new System.Drawing.Size(185, 16);
            this.lbl_UserLocationAndTime.TabIndex = 13;
            this.lbl_UserLocationAndTime.Text = "User Location, Date and Time";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(650, 5);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            // 
            // MainHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1220, 772);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lbl_UserLocationAndTime);
            this.Controls.Add(this.btn_UpdateCustomer);
            this.Controls.Add(this.btn_AddCustomer);
            this.Controls.Add(this.btn_DeleteAppointment);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ModifyAppointment);
            this.Controls.Add(this.btn_ViewAppointments);
            this.Controls.Add(this.btn_AddNewAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_AppointmentGrid);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "MainHomePage";
            this.Text = "Appointment Tracker Home";
            this.Load += new System.EventHandler(this.MainHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AppointmentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dgv_AppointmentGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddNewAppointment;
        private System.Windows.Forms.Button btn_ViewAppointments;
        private System.Windows.Forms.Button btn_ModifyAppointment;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_DeleteAppointment;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.Button btn_UpdateCustomer;
        private System.Windows.Forms.Label lbl_UserLocationAndTime;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}