namespace GenerichkoProgramiranje
{
    partial class Form2
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
            this.addDetailsBox = new System.Windows.Forms.GroupBox();
            this.gameTypeBox = new System.Windows.Forms.ComboBox();
            this.gameTypeLabel = new System.Windows.Forms.Label();
            this.homeTeamLabel = new System.Windows.Forms.Label();
            this.homeTeamTextBox = new System.Windows.Forms.TextBox();
            this.awayTeamTextBox = new System.Windows.Forms.TextBox();
            this.awayTeamLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.homeTeamScoreTextBox = new System.Windows.Forms.TextBox();
            this.awayTeamScoreTextBox = new System.Windows.Forms.TextBox();
            this.vsLabel = new System.Windows.Forms.Label();
            this.homeShootersListBox = new System.Windows.Forms.ListBox();
            this.shootersHomeBox = new System.Windows.Forms.GroupBox();
            this.awayShootersBox = new System.Windows.Forms.GroupBox();
            this.awayShootersListBox = new System.Windows.Forms.ListBox();
            this.addNewGameOK = new System.Windows.Forms.Button();
            this.addNewGameNOK = new System.Windows.Forms.Button();
            this.addHomeShooterButton = new System.Windows.Forms.Button();
            this.addAwayShooterButton = new System.Windows.Forms.Button();
            this.dateOfMatch = new System.Windows.Forms.DateTimePicker();
            this.dateOfMatchLabel = new System.Windows.Forms.Label();
            this.addDetailsBox.SuspendLayout();
            this.shootersHomeBox.SuspendLayout();
            this.awayShootersBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addDetailsBox
            // 
            this.addDetailsBox.Controls.Add(this.dateOfMatchLabel);
            this.addDetailsBox.Controls.Add(this.dateOfMatch);
            this.addDetailsBox.Controls.Add(this.addAwayShooterButton);
            this.addDetailsBox.Controls.Add(this.addHomeShooterButton);
            this.addDetailsBox.Controls.Add(this.addNewGameNOK);
            this.addDetailsBox.Controls.Add(this.addNewGameOK);
            this.addDetailsBox.Controls.Add(this.awayShootersBox);
            this.addDetailsBox.Controls.Add(this.shootersHomeBox);
            this.addDetailsBox.Controls.Add(this.vsLabel);
            this.addDetailsBox.Controls.Add(this.awayTeamScoreTextBox);
            this.addDetailsBox.Controls.Add(this.homeTeamScoreTextBox);
            this.addDetailsBox.Controls.Add(this.scoreLabel);
            this.addDetailsBox.Controls.Add(this.awayTeamTextBox);
            this.addDetailsBox.Controls.Add(this.awayTeamLabel);
            this.addDetailsBox.Controls.Add(this.homeTeamTextBox);
            this.addDetailsBox.Controls.Add(this.homeTeamLabel);
            this.addDetailsBox.Controls.Add(this.gameTypeLabel);
            this.addDetailsBox.Controls.Add(this.gameTypeBox);
            this.addDetailsBox.Location = new System.Drawing.Point(13, 13);
            this.addDetailsBox.Name = "addDetailsBox";
            this.addDetailsBox.Size = new System.Drawing.Size(455, 480);
            this.addDetailsBox.TabIndex = 0;
            this.addDetailsBox.TabStop = false;
            this.addDetailsBox.Text = "Внесете податоци";
            // 
            // gameTypeBox
            // 
            this.gameTypeBox.FormattingEnabled = true;
            this.gameTypeBox.Location = new System.Drawing.Point(197, 39);
            this.gameTypeBox.Name = "gameTypeBox";
            this.gameTypeBox.Size = new System.Drawing.Size(214, 24);
            this.gameTypeBox.TabIndex = 0;
            this.gameTypeBox.SelectedIndexChanged += new System.EventHandler(this.gameTypeBox_SelectedIndexChanged);
            // 
            // gameTypeLabel
            // 
            this.gameTypeLabel.AutoSize = true;
            this.gameTypeLabel.Location = new System.Drawing.Point(39, 42);
            this.gameTypeLabel.Name = "gameTypeLabel";
            this.gameTypeLabel.Size = new System.Drawing.Size(131, 17);
            this.gameTypeLabel.TabIndex = 1;
            this.gameTypeLabel.Text = "Тип на натпревар:";
            // 
            // homeTeamLabel
            // 
            this.homeTeamLabel.AutoSize = true;
            this.homeTeamLabel.Location = new System.Drawing.Point(42, 69);
            this.homeTeamLabel.Name = "homeTeamLabel";
            this.homeTeamLabel.Size = new System.Drawing.Size(67, 17);
            this.homeTeamLabel.TabIndex = 2;
            this.homeTeamLabel.Text = "Домаќин";
            // 
            // homeTeamTextBox
            // 
            this.homeTeamTextBox.Location = new System.Drawing.Point(197, 69);
            this.homeTeamTextBox.Name = "homeTeamTextBox";
            this.homeTeamTextBox.Size = new System.Drawing.Size(214, 22);
            this.homeTeamTextBox.TabIndex = 3;
            // 
            // awayTeamTextBox
            // 
            this.awayTeamTextBox.Location = new System.Drawing.Point(197, 97);
            this.awayTeamTextBox.Name = "awayTeamTextBox";
            this.awayTeamTextBox.Size = new System.Drawing.Size(214, 22);
            this.awayTeamTextBox.TabIndex = 5;
            // 
            // awayTeamLabel
            // 
            this.awayTeamLabel.AutoSize = true;
            this.awayTeamLabel.Location = new System.Drawing.Point(42, 97);
            this.awayTeamLabel.Name = "awayTeamLabel";
            this.awayTeamLabel.Size = new System.Drawing.Size(54, 17);
            this.awayTeamLabel.TabIndex = 4;
            this.awayTeamLabel.Text = "Гостин";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(39, 125);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(69, 17);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "Резултат";
            // 
            // homeTeamScoreTextBox
            // 
            this.homeTeamScoreTextBox.Location = new System.Drawing.Point(197, 125);
            this.homeTeamScoreTextBox.Name = "homeTeamScoreTextBox";
            this.homeTeamScoreTextBox.ReadOnly = true;
            this.homeTeamScoreTextBox.Size = new System.Drawing.Size(100, 22);
            this.homeTeamScoreTextBox.TabIndex = 7;
            // 
            // awayTeamScoreTextBox
            // 
            this.awayTeamScoreTextBox.Location = new System.Drawing.Point(321, 125);
            this.awayTeamScoreTextBox.Name = "awayTeamScoreTextBox";
            this.awayTeamScoreTextBox.ReadOnly = true;
            this.awayTeamScoreTextBox.Size = new System.Drawing.Size(90, 22);
            this.awayTeamScoreTextBox.TabIndex = 8;
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Location = new System.Drawing.Point(303, 128);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(12, 17);
            this.vsLabel.TabIndex = 9;
            this.vsLabel.Text = ":";
            // 
            // homeShootersListBox
            // 
            this.homeShootersListBox.FormattingEnabled = true;
            this.homeShootersListBox.ItemHeight = 16;
            this.homeShootersListBox.Location = new System.Drawing.Point(26, 23);
            this.homeShootersListBox.Name = "homeShootersListBox";
            this.homeShootersListBox.Size = new System.Drawing.Size(159, 84);
            this.homeShootersListBox.TabIndex = 10;
            // 
            // shootersHomeBox
            // 
            this.shootersHomeBox.Controls.Add(this.homeShootersListBox);
            this.shootersHomeBox.Location = new System.Drawing.Point(6, 277);
            this.shootersHomeBox.Name = "shootersHomeBox";
            this.shootersHomeBox.Size = new System.Drawing.Size(208, 133);
            this.shootersHomeBox.TabIndex = 12;
            this.shootersHomeBox.TabStop = false;
            this.shootersHomeBox.Text = "Стрелци дома";
            // 
            // awayShootersBox
            // 
            this.awayShootersBox.Controls.Add(this.awayShootersListBox);
            this.awayShootersBox.Location = new System.Drawing.Point(233, 277);
            this.awayShootersBox.Name = "awayShootersBox";
            this.awayShootersBox.Size = new System.Drawing.Size(216, 133);
            this.awayShootersBox.TabIndex = 13;
            this.awayShootersBox.TabStop = false;
            this.awayShootersBox.Text = "Стрелци гости";
            // 
            // awayShootersListBox
            // 
            this.awayShootersListBox.FormattingEnabled = true;
            this.awayShootersListBox.ItemHeight = 16;
            this.awayShootersListBox.Location = new System.Drawing.Point(29, 23);
            this.awayShootersListBox.Name = "awayShootersListBox";
            this.awayShootersListBox.Size = new System.Drawing.Size(172, 84);
            this.awayShootersListBox.TabIndex = 10;
            // 
            // addNewGameOK
            // 
            this.addNewGameOK.Location = new System.Drawing.Point(50, 416);
            this.addNewGameOK.Name = "addNewGameOK";
            this.addNewGameOK.Size = new System.Drawing.Size(120, 47);
            this.addNewGameOK.TabIndex = 14;
            this.addNewGameOK.Text = "Додади";
            this.addNewGameOK.UseVisualStyleBackColor = true;
            this.addNewGameOK.Click += new System.EventHandler(this.addNewGameOK_Click);
            // 
            // addNewGameNOK
            // 
            this.addNewGameNOK.Location = new System.Drawing.Point(282, 416);
            this.addNewGameNOK.Name = "addNewGameNOK";
            this.addNewGameNOK.Size = new System.Drawing.Size(120, 47);
            this.addNewGameNOK.TabIndex = 15;
            this.addNewGameNOK.Text = "Откажи";
            this.addNewGameNOK.UseVisualStyleBackColor = true;
            this.addNewGameNOK.Click += new System.EventHandler(this.addNewGameNOK_Click);
            // 
            // addHomeShooterButton
            // 
            this.addHomeShooterButton.Location = new System.Drawing.Point(7, 248);
            this.addHomeShooterButton.Name = "addHomeShooterButton";
            this.addHomeShooterButton.Size = new System.Drawing.Size(207, 23);
            this.addHomeShooterButton.TabIndex = 16;
            this.addHomeShooterButton.Text = "Додади стрелец - дома";
            this.addHomeShooterButton.UseVisualStyleBackColor = true;
            this.addHomeShooterButton.Click += new System.EventHandler(this.addHomeShooterButton_Click);
            // 
            // addAwayShooterButton
            // 
            this.addAwayShooterButton.Location = new System.Drawing.Point(233, 248);
            this.addAwayShooterButton.Name = "addAwayShooterButton";
            this.addAwayShooterButton.Size = new System.Drawing.Size(216, 23);
            this.addAwayShooterButton.TabIndex = 17;
            this.addAwayShooterButton.Text = "Додади стрелец - гостин";
            this.addAwayShooterButton.UseVisualStyleBackColor = true;
            this.addAwayShooterButton.Click += new System.EventHandler(this.addAwayShooterButton_Click);
            // 
            // dateOfMatch
            // 
            this.dateOfMatch.Location = new System.Drawing.Point(197, 153);
            this.dateOfMatch.Name = "dateOfMatch";
            this.dateOfMatch.Size = new System.Drawing.Size(214, 22);
            this.dateOfMatch.TabIndex = 18;
            // 
            // dateOfMatchLabel
            // 
            this.dateOfMatchLabel.AutoSize = true;
            this.dateOfMatchLabel.Location = new System.Drawing.Point(42, 157);
            this.dateOfMatchLabel.Name = "dateOfMatchLabel";
            this.dateOfMatchLabel.Size = new System.Drawing.Size(144, 17);
            this.dateOfMatchLabel.TabIndex = 19;
            this.dateOfMatchLabel.Text = "Датум на натпревар";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 505);
            this.Controls.Add(this.addDetailsBox);
            this.Name = "Form2";
            this.Text = "Додади натпревар";
            this.addDetailsBox.ResumeLayout(false);
            this.addDetailsBox.PerformLayout();
            this.shootersHomeBox.ResumeLayout(false);
            this.awayShootersBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addDetailsBox;
        private System.Windows.Forms.Button addNewGameNOK;
        private System.Windows.Forms.Button addNewGameOK;
        private System.Windows.Forms.GroupBox awayShootersBox;
        private System.Windows.Forms.ListBox awayShootersListBox;
        private System.Windows.Forms.GroupBox shootersHomeBox;
        private System.Windows.Forms.ListBox homeShootersListBox;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.TextBox awayTeamScoreTextBox;
        private System.Windows.Forms.TextBox homeTeamScoreTextBox;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox awayTeamTextBox;
        private System.Windows.Forms.Label awayTeamLabel;
        private System.Windows.Forms.TextBox homeTeamTextBox;
        private System.Windows.Forms.Label homeTeamLabel;
        private System.Windows.Forms.Label gameTypeLabel;
        private System.Windows.Forms.ComboBox gameTypeBox;
        private System.Windows.Forms.Button addAwayShooterButton;
        private System.Windows.Forms.Button addHomeShooterButton;
        private System.Windows.Forms.Label dateOfMatchLabel;
        private System.Windows.Forms.DateTimePicker dateOfMatch;
    }
}