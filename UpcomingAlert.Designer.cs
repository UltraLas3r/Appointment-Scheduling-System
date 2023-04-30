namespace mschreiber_Software2_c969Project
{
    partial class UpcomingAlert
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
            this.dgv_warning = new System.Windows.Forms.DataGridView();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Warning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_warning)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_warning
            // 
            this.dgv_warning.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_warning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_warning.Location = new System.Drawing.Point(40, 145);
            this.dgv_warning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_warning.Name = "dgv_warning";
            this.dgv_warning.RowHeadersWidth = 51;
            this.dgv_warning.Size = new System.Drawing.Size(824, 300);
            this.dgv_warning.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_Close.Location = new System.Drawing.Point(372, 486);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(165, 61);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close Menu";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Header.Location = new System.Drawing.Point(36, 112);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(628, 25);
            this.lbl_Header.TabIndex = 4;
            this.lbl_Header.Text = "Upcoming Appointments in the next 15 minutes";
            this.lbl_Header.Click += new System.EventHandler(this.lbl_Header_Click);
            // 
            // lbl_Warning
            // 
            this.lbl_Warning.AutoSize = true;
            this.lbl_Warning.Font = new System.Drawing.Font("OCR A Extended", 18F);
            this.lbl_Warning.Location = new System.Drawing.Point(14, 26);
            this.lbl_Warning.Name = "lbl_Warning";
            this.lbl_Warning.Size = new System.Drawing.Size(963, 37);
            this.lbl_Warning.TabIndex = 5;
            this.lbl_Warning.Text = "< Warning! Upcoming Appointments Detected >";
            // 
            // UpcomingAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.lbl_Warning);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dgv_warning);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpcomingAlert";
            this.Text = "Upcoming Appointment Reminder";
           
            ((System.ComponentModel.ISupportInitialize)(this.dgv_warning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_warning;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Warning;
    }
}