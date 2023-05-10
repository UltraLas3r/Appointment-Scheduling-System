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
            this.lbl_Type = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_CustomerID = new System.Windows.Forms.Label();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_CustomerData = new System.Windows.Forms.DataGridView();
            this.lbl_UserMeeting = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerData)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(330, 711);
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
            this.btn_ModifyAppointment.Location = new System.Drawing.Point(19, 711);
            this.btn_ModifyAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ModifyAppointment.Name = "btn_ModifyAppointment";
            this.btn_ModifyAppointment.Size = new System.Drawing.Size(252, 94);
            this.btn_ModifyAppointment.TabIndex = 15;
            this.btn_ModifyAppointment.Text = "Modify Appointment";
            this.btn_ModifyAppointment.UseVisualStyleBackColor = true;
            this.btn_ModifyAppointment.Click += new System.EventHandler(this.btn_SaveAppointment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 24F);
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 50);
            this.label1.TabIndex = 32;
            this.label1.Text = "Modify Appointment";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Type.Location = new System.Drawing.Point(33, 561);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(278, 25);
            this.lbl_Type.TabIndex = 33;
            this.lbl_Type.Text = "Type of Appointment";
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(19, 146);
            this.txt_Title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(352, 26);
            this.txt_Title.TabIndex = 35;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Title.Location = new System.Drawing.Point(21, 105);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(250, 25);
            this.lbl_Title.TabIndex = 34;
            this.lbl_Title.Text = "Appointment Title";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 603);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(422, 28);
            this.comboBox1.TabIndex = 42;
            // 
            // lbl_CustomerID
            // 
            this.lbl_CustomerID.AutoSize = true;
            this.lbl_CustomerID.Location = new System.Drawing.Point(27, 460);
            this.lbl_CustomerID.Name = "lbl_CustomerID";
            this.lbl_CustomerID.Size = new System.Drawing.Size(121, 20);
            this.lbl_CustomerID.TabIndex = 47;
            this.lbl_CustomerID.Text = "CUSTOMER ID";
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Location = new System.Drawing.Point(185, 460);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.ReadOnly = true;
            this.txt_CustomerName.Size = new System.Drawing.Size(191, 26);
            this.txt_CustomerName.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Your appointment is with...";
            // 
            // dgv_CustomerData
            // 
            this.dgv_CustomerData.AllowUserToAddRows = false;
            this.dgv_CustomerData.AllowUserToDeleteRows = false;
            this.dgv_CustomerData.AllowUserToResizeRows = false;
            this.dgv_CustomerData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(222)))), ((int)(((byte)(192)))));
            this.dgv_CustomerData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_CustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustomerData.Location = new System.Drawing.Point(19, 264);
            this.dgv_CustomerData.Name = "dgv_CustomerData";
            this.dgv_CustomerData.ReadOnly = true;
            this.dgv_CustomerData.RowHeadersWidth = 62;
            this.dgv_CustomerData.RowTemplate.Height = 28;
            this.dgv_CustomerData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CustomerData.Size = new System.Drawing.Size(556, 144);
            this.dgv_CustomerData.TabIndex = 44;
            // 
            // lbl_UserMeeting
            // 
            this.lbl_UserMeeting.AutoSize = true;
            this.lbl_UserMeeting.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_UserMeeting.Location = new System.Drawing.Point(26, 236);
            this.lbl_UserMeeting.Name = "lbl_UserMeeting";
            this.lbl_UserMeeting.Size = new System.Drawing.Size(404, 25);
            this.lbl_UserMeeting.TabIndex = 43;
            this.lbl_UserMeeting.Text = "Who is the appointment with?";
            // 
            // ModifyAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(655, 854);
            this.Controls.Add(this.lbl_CustomerID);
            this.Controls.Add(this.txt_CustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_CustomerData);
            this.Controls.Add(this.lbl_UserMeeting);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_ModifyAppointment);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModifyAppointment";
            this.Text = "ModifyAppointment";
            this.Load += new System.EventHandler(this.ModifyAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_ModifyAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_CustomerID;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_CustomerData;
        private System.Windows.Forms.Label lbl_UserMeeting;
    }
}