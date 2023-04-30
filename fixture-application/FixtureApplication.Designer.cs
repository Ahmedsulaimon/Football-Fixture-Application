namespace HW
{
    partial class FixtureApplication
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
            this.btnCreateFixture = new System.Windows.Forms.Button();
            this.lblDateError = new System.Windows.Forms.Label();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.lblAwayTeam = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.txttime = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtAwayTeam = new System.Windows.Forms.TextBox();
            this.txtHomeTeam = new System.Windows.Forms.TextBox();
            this.lstFixtureList = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstScore = new System.Windows.Forms.ListBox();
            this.lblHomeTeamGoal = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblAwayTeamGoal = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnNewScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateFixture
            // 
            this.btnCreateFixture.Location = new System.Drawing.Point(168, 331);
            this.btnCreateFixture.Name = "btnCreateFixture";
            this.btnCreateFixture.Size = new System.Drawing.Size(141, 23);
            this.btnCreateFixture.TabIndex = 0;
            this.btnCreateFixture.Text = "Create Fixture";
            this.btnCreateFixture.UseVisualStyleBackColor = true;
            this.btnCreateFixture.Click += new System.EventHandler(this.btnCreateFixture_Click);
            // 
            // lblDateError
            // 
            this.lblDateError.AutoSize = true;
            this.lblDateError.Location = new System.Drawing.Point(198, 273);
            this.lblDateError.Name = "lblDateError";
            this.lblDateError.Size = new System.Drawing.Size(0, 15);
            this.lblDateError.TabIndex = 3;
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.AutoSize = true;
            this.lblHomeTeam.Location = new System.Drawing.Point(56, 107);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(68, 15);
            this.lblHomeTeam.TabIndex = 4;
            this.lblHomeTeam.Text = "HomeTeam";
            // 
            // lblAwayTeam
            // 
            this.lblAwayTeam.AutoSize = true;
            this.lblAwayTeam.Location = new System.Drawing.Point(56, 138);
            this.lblAwayTeam.Name = "lblAwayTeam";
            this.lblAwayTeam.Size = new System.Drawing.Size(64, 15);
            this.lblAwayTeam.TabIndex = 5;
            this.lblAwayTeam.Text = "AwayTeam";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(40, 179);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(109, 15);
            this.lbldate.TabIndex = 6;
            this.lbldate.Text = "Date(mm/dd/yyyy)";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(56, 216);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(33, 15);
            this.lbltime.TabIndex = 7;
            this.lbltime.Text = "Time";
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(168, 208);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(203, 23);
            this.txttime.TabIndex = 8;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(168, 171);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(203, 23);
            this.txtdate.TabIndex = 9;
            // 
            // txtAwayTeam
            // 
            this.txtAwayTeam.Location = new System.Drawing.Point(168, 138);
            this.txtAwayTeam.Name = "txtAwayTeam";
            this.txtAwayTeam.Size = new System.Drawing.Size(203, 23);
            this.txtAwayTeam.TabIndex = 10;
            this.txtAwayTeam.TextChanged += new System.EventHandler(this.txtAwayTeam_TextChanged);
            // 
            // txtHomeTeam
            // 
            this.txtHomeTeam.Location = new System.Drawing.Point(168, 99);
            this.txtHomeTeam.Name = "txtHomeTeam";
            this.txtHomeTeam.Size = new System.Drawing.Size(203, 23);
            this.txtHomeTeam.TabIndex = 11;
            this.txtHomeTeam.TextChanged += new System.EventHandler(this.txtHomeTeam_TextChanged);
            // 
            // lstFixtureList
            // 
            this.lstFixtureList.FormattingEnabled = true;
            this.lstFixtureList.ItemHeight = 15;
            this.lstFixtureList.Location = new System.Drawing.Point(406, 65);
            this.lstFixtureList.Name = "lstFixtureList";
            this.lstFixtureList.Size = new System.Drawing.Size(392, 289);
            this.lstFixtureList.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(456, 369);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(301, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // lstScore
            // 
            this.lstScore.FormattingEnabled = true;
            this.lstScore.ItemHeight = 15;
            this.lstScore.Location = new System.Drawing.Point(833, 67);
            this.lstScore.Name = "lstScore";
            this.lstScore.Size = new System.Drawing.Size(105, 289);
            this.lstScore.TabIndex = 14;
            // 
            // lblHomeTeamGoal
            // 
            this.lblHomeTeamGoal.AutoSize = true;
            this.lblHomeTeamGoal.Location = new System.Drawing.Point(944, 87);
            this.lblHomeTeamGoal.Name = "lblHomeTeamGoal";
            this.lblHomeTeamGoal.Size = new System.Drawing.Size(92, 15);
            this.lblHomeTeamGoal.TabIndex = 15;
            this.lblHomeTeamGoal.Text = "HomeTeamGoal";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(958, 117);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(98, 23);
            this.numericUpDown1.TabIndex = 16;
            // 
            // lblAwayTeamGoal
            // 
            this.lblAwayTeamGoal.AutoSize = true;
            this.lblAwayTeamGoal.Location = new System.Drawing.Point(967, 155);
            this.lblAwayTeamGoal.Name = "lblAwayTeamGoal";
            this.lblAwayTeamGoal.Size = new System.Drawing.Size(88, 15);
            this.lblAwayTeamGoal.TabIndex = 17;
            this.lblAwayTeamGoal.Text = "AwayTeamGoal";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(958, 171);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(98, 23);
            this.numericUpDown2.TabIndex = 18;
            // 
            // btnNewScore
            // 
            this.btnNewScore.Location = new System.Drawing.Point(944, 247);
            this.btnNewScore.Name = "btnNewScore";
            this.btnNewScore.Size = new System.Drawing.Size(111, 23);
            this.btnNewScore.TabIndex = 19;
            this.btnNewScore.Text = "Update Scoreline";
            this.btnNewScore.UseVisualStyleBackColor = true;
            this.btnNewScore.Click += new System.EventHandler(this.btnNewScore_Click);
            // 
            // FixtureApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 450);
            this.Controls.Add(this.btnNewScore);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.lblAwayTeamGoal);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblHomeTeamGoal);
            this.Controls.Add(this.lstScore);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstFixtureList);
            this.Controls.Add(this.txtHomeTeam);
            this.Controls.Add(this.txtAwayTeam);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblAwayTeam);
            this.Controls.Add(this.lblHomeTeam);
            this.Controls.Add(this.lblDateError);
            this.Controls.Add(this.btnCreateFixture);
            this.Name = "FixtureApplication";
            this.Text = "FixtureApplication";
            this.Load += new System.EventHandler(this.FixtureApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCreateFixture;
        private Label lblDateError;
        private Label lblHomeTeam;
        private Label lblAwayTeam;
        private Label lbldate;
        private Label lbltime;
        private TextBox txttime;
        private TextBox txtdate;
        private TextBox txtAwayTeam;
        private TextBox txtHomeTeam;
        private ListBox lstFixtureList;
        private Button btnDelete;
        private ListBox lstScore;
        private Label lblHomeTeamGoal;
        private NumericUpDown numericUpDown1;
        private Label lblAwayTeamGoal;
        private NumericUpDown numericUpDown2;
        private Button btnNewScore;
    }
}