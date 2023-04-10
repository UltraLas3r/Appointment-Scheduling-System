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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CreateAppointment = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_ModifyAppointment = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_DeleteAppointment = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.radioButton1.Location = new System.Drawing.Point(1127, 127);
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
            this.radioButton2.Location = new System.Drawing.Point(1127, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(211, 27);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "View This Month";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.ViewThisMonthRadioButton);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 666);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Upcoming Appointments";
            // 
            // btn_CreateAppointment
            // 
            this.btn_CreateAppointment.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_CreateAppointment.Location = new System.Drawing.Point(1175, 310);
            this.btn_CreateAppointment.Name = "btn_CreateAppointment";
            this.btn_CreateAppointment.Size = new System.Drawing.Size(139, 89);
            this.btn_CreateAppointment.TabIndex = 6;
            this.btn_CreateAppointment.Text = "Create New Appointment";
            this.btn_CreateAppointment.UseVisualStyleBackColor = true;
            this.btn_CreateAppointment.Click += new System.EventHandler(this.CreateNewAppointment_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.button2.Location = new System.Drawing.Point(1127, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 62);
            this.button2.TabIndex = 7;
            this.button2.Text = "View Appointments";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ViewAppointmentsButton_Click);
            // 
            // btn_ModifyAppointment
            // 
            this.btn_ModifyAppointment.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_ModifyAppointment.Location = new System.Drawing.Point(1175, 423);
            this.btn_ModifyAppointment.Name = "btn_ModifyAppointment";
            this.btn_ModifyAppointment.Size = new System.Drawing.Size(139, 89);
            this.btn_ModifyAppointment.TabIndex = 8;
            this.btn_ModifyAppointment.Text = "Modify Appointment";
            this.btn_ModifyAppointment.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_Exit.Location = new System.Drawing.Point(1203, 831);
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
            this.btn_DeleteAppointment.Location = new System.Drawing.Point(1175, 534);
            this.btn_DeleteAppointment.Name = "btn_DeleteAppointment";
            this.btn_DeleteAppointment.Size = new System.Drawing.Size(139, 89);
            this.btn_DeleteAppointment.TabIndex = 10;
            this.btn_DeleteAppointment.Text = "Delete Appointment";
            this.btn_DeleteAppointment.UseVisualStyleBackColor = true;
            this.btn_DeleteAppointment.Click += new System.EventHandler(this.DeleteAppointment_Click);
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_AddCustomer.Location = new System.Drawing.Point(55, 767);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(139, 89);
            this.btn_AddCustomer.TabIndex = 11;
            this.btn_AddCustomer.Text = "Add Customer";
            this.btn_AddCustomer.UseVisualStyleBackColor = true;
            this.btn_AddCustomer.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.button3.Location = new System.Drawing.Point(218, 767);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 89);
            this.button3.TabIndex = 12;
            this.button3.Text = "Update Customer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
            // 
            // MainHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 895);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_AddCustomer);
            this.Controls.Add(this.btn_DeleteAppointment);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ModifyAppointment);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_CreateAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "MainHomePage";
            this.Text = "Appointment Tracker Home";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CreateAppointment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_ModifyAppointment;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_DeleteAppointment;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.Button button3;
    }
}