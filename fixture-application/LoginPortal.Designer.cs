namespace HW
{
    partial class LoginPortal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLOGIN = new System.Windows.Forms.Button();
            this.lblUserInput = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btncreateLOGIN = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.Location = new System.Drawing.Point(286, 204);
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Size = new System.Drawing.Size(118, 23);
            this.btnLOGIN.TabIndex = 0;
            this.btnLOGIN.Text = "LOGIN";
            this.btnLOGIN.UseVisualStyleBackColor = true;
            this.btnLOGIN.TextChanged += new System.EventHandler(this.btnLOGIN_TextChanged);
            this.btnLOGIN.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // lblUserInput
            // 
            this.lblUserInput.AutoSize = true;
            this.lblUserInput.Location = new System.Drawing.Point(313, 230);
            this.lblUserInput.Name = "lblUserInput";
            this.lblUserInput.Size = new System.Drawing.Size(0, 15);
            this.lblUserInput.TabIndex = 1;
            this.lblUserInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(275, 95);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(196, 23);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(275, 139);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(196, 23);
            this.txtPassWord.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(209, 103);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(212, 142);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // btncreateLOGIN
            // 
            this.btncreateLOGIN.Location = new System.Drawing.Point(212, 250);
            this.btncreateLOGIN.Name = "btncreateLOGIN";
            this.btncreateLOGIN.Size = new System.Drawing.Size(271, 23);
            this.btncreateLOGIN.TabIndex = 7;
            this.btncreateLOGIN.Text = "CreateLOGIN";
            this.btncreateLOGIN.UseVisualStyleBackColor = true;
            this.btncreateLOGIN.TextChanged += new System.EventHandler(this.btncreateLOGIN_TextChanged);
            this.btncreateLOGIN.Click += new System.EventHandler(this.btncreateLOGIN_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(286, 177);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(637, 302);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btncreateLOGIN);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserInput);
            this.Controls.Add(this.btnLOGIN);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Login Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLOGIN;
        private Label lblUserInput;
        private TextBox txtUserName;
        private TextBox txtPassWord;
        private Label lblUsername;
        private Label lblPassword;
        private Button btncreateLOGIN;
        private Label lblResult;
    }
}