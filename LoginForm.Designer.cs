namespace mschreiber_Software2_c969Project
{
    partial class LoginForm
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
            this.lbl_LoginHeader = new System.Windows.Forms.Label();
            this.lbl_EnterYourCredentials = new System.Windows.Forms.Label();
            this.txt_LoginName = new System.Windows.Forms.TextBox();
            this.txt_LoginPass = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_CancelLogin = new System.Windows.Forms.Button();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_LoginHeader
            // 
            this.lbl_LoginHeader.AutoSize = true;
            this.lbl_LoginHeader.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginHeader.Location = new System.Drawing.Point(293, 30);
            this.lbl_LoginHeader.Name = "lbl_LoginHeader";
            this.lbl_LoginHeader.Size = new System.Drawing.Size(210, 41);
            this.lbl_LoginHeader.TabIndex = 0;
            this.lbl_LoginHeader.Text = "Welcome!";
            // 
            // lbl_EnterYourCredentials
            // 
            this.lbl_EnterYourCredentials.AutoSize = true;
            this.lbl_EnterYourCredentials.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_EnterYourCredentials.Location = new System.Drawing.Point(183, 129);
            this.lbl_EnterYourCredentials.Name = "lbl_EnterYourCredentials";
            this.lbl_EnterYourCredentials.Size = new System.Drawing.Size(430, 23);
            this.lbl_EnterYourCredentials.TabIndex = 1;
            this.lbl_EnterYourCredentials.Text = "Please Enter your Valid Credentials";
            // 
            // txt_LoginName
            // 
            this.txt_LoginName.Location = new System.Drawing.Point(143, 209);
            this.txt_LoginName.Name = "txt_LoginName";
            this.txt_LoginName.Size = new System.Drawing.Size(504, 22);
            this.txt_LoginName.TabIndex = 2;
            // 
            // txt_LoginPass
            // 
            this.txt_LoginPass.Location = new System.Drawing.Point(143, 266);
            this.txt_LoginPass.Name = "txt_LoginPass";
            this.txt_LoginPass.Size = new System.Drawing.Size(504, 22);
            this.txt_LoginPass.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_Login.Location = new System.Drawing.Point(197, 343);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(172, 48);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_CancelLogin
            // 
            this.btn_CancelLogin.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_CancelLogin.Location = new System.Drawing.Point(427, 343);
            this.btn_CancelLogin.Name = "btn_CancelLogin";
            this.btn_CancelLogin.Size = new System.Drawing.Size(172, 48);
            this.btn_CancelLogin.TabIndex = 5;
            this.btn_CancelLogin.Text = "Cancel";
            this.btn_CancelLogin.UseVisualStyleBackColor = true;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_UserName.Location = new System.Drawing.Point(4, 209);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(118, 23);
            this.lbl_UserName.TabIndex = 6;
            this.lbl_UserName.Text = "User Name";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Password.Location = new System.Drawing.Point(4, 263);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(106, 23);
            this.lbl_Password.TabIndex = 7;
            this.lbl_Password.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.btn_CancelLogin);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_LoginPass);
            this.Controls.Add(this.txt_LoginName);
            this.Controls.Add(this.lbl_EnterYourCredentials);
            this.Controls.Add(this.lbl_LoginHeader);
            this.Name = "LoginForm";
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_LoginHeader;
        private System.Windows.Forms.Label lbl_EnterYourCredentials;
        private System.Windows.Forms.TextBox txt_LoginName;
        private System.Windows.Forms.TextBox txt_LoginPass;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_CancelLogin;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
    }
}

