namespace HW
{
    partial class CreateLOGIN
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCreateUsername = new System.Windows.Forms.TextBox();
            this.txtCreatePassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblerrorMessage = new System.Windows.Forms.Label();
            this.lblUserNameError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblinvalidCreation = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(381, 237);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(124, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCreateUsername
            // 
            this.txtCreateUsername.Location = new System.Drawing.Point(361, 117);
            this.txtCreateUsername.Name = "txtCreateUsername";
            this.txtCreateUsername.Size = new System.Drawing.Size(174, 23);
            this.txtCreateUsername.TabIndex = 1;
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.Location = new System.Drawing.Point(361, 151);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Size = new System.Drawing.Size(174, 23);
            this.txtCreatePassword.TabIndex = 2;
            this.txtCreatePassword.TextChanged += new System.EventHandler(this.txtCreatePassword_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(289, 124);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(289, 159);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblerrorMessage
            // 
            this.lblerrorMessage.AutoSize = true;
            this.lblerrorMessage.Location = new System.Drawing.Point(617, 154);
            this.lblerrorMessage.Name = "lblerrorMessage";
            this.lblerrorMessage.Size = new System.Drawing.Size(0, 15);
            this.lblerrorMessage.TabIndex = 5;
            // 
            // lblUserNameError
            // 
            this.lblUserNameError.AutoSize = true;
            this.lblUserNameError.Location = new System.Drawing.Point(617, 125);
            this.lblUserNameError.Name = "lblUserNameError";
            this.lblUserNameError.Size = new System.Drawing.Size(0, 15);
            this.lblUserNameError.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 185);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REQUIREMENTS.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Username must contain a letter.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password must contain a number.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password must contain a special character";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password must be atleast 8 characters long.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username must contain a number.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username must contain atleast one letter.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username must be atleast 5 characters long";
            // 
            // lblinvalidCreation
            // 
            this.lblinvalidCreation.AutoSize = true;
            this.lblinvalidCreation.Location = new System.Drawing.Point(391, 203);
            this.lblinvalidCreation.Name = "lblinvalidCreation";
            this.lblinvalidCreation.Size = new System.Drawing.Size(0, 15);
            this.lblinvalidCreation.TabIndex = 8;
            // 
            // CreateLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(845, 327);
            this.Controls.Add(this.lblinvalidCreation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUserNameError);
            this.Controls.Add(this.lblerrorMessage);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtCreatePassword);
            this.Controls.Add(this.txtCreateUsername);
            this.Controls.Add(this.btnCreate);
            this.Name = "CreateLOGIN";
            this.Text = "CreateLOGIN";
            this.Load += new System.EventHandler(this.CreateLOGIN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCreate;
        private TextBox txtCreateUsername;
        private TextBox txtCreatePassword;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblerrorMessage;
        private Label lblUserNameError;
        private GroupBox groupBox1;
        private Label lblinvalidCreation;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}