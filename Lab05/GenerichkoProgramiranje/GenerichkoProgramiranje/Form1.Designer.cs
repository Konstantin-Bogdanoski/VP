namespace GenerichkoProgramiranje
{
    partial class Form1
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
            this.basketballGroupBox = new System.Windows.Forms.GroupBox();
            this.basketballListBox = new System.Windows.Forms.ListBox();
            this.footballGroupBox = new System.Windows.Forms.GroupBox();
            this.footballListBox = new System.Windows.Forms.ListBox();
            this.gameDetailsBox = new System.Windows.Forms.GroupBox();
            this.gameLabel = new System.Windows.Forms.Label();
            this.gameHomeTextBox = new System.Windows.Forms.TextBox();
            this.gameScoreTextBox = new System.Windows.Forms.TextBox();
            this.gameAwayTextBox = new System.Windows.Forms.TextBox();
            this.shootersHomeLabel = new System.Windows.Forms.Label();
            this.shootersHomeListBox = new System.Windows.Forms.ListBox();
            this.shootersAwayListBox = new System.Windows.Forms.ListBox();
            this.shootersAwayLabel = new System.Windows.Forms.Label();
            this.gameDateLabel = new System.Windows.Forms.Label();
            this.gameDateTextBox = new System.Windows.Forms.TextBox();
            this.addGameButton = new System.Windows.Forms.Button();
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.basketballGroupBox.SuspendLayout();
            this.footballGroupBox.SuspendLayout();
            this.gameDetailsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // basketballGroupBox
            // 
            this.basketballGroupBox.Controls.Add(this.basketballListBox);
            this.basketballGroupBox.Location = new System.Drawing.Point(13, 13);
            this.basketballGroupBox.Name = "basketballGroupBox";
            this.basketballGroupBox.Size = new System.Drawing.Size(265, 224);
            this.basketballGroupBox.TabIndex = 0;
            this.basketballGroupBox.TabStop = false;
            this.basketballGroupBox.Text = "Кошарка";
            // 
            // basketballListBox
            // 
            this.basketballListBox.FormattingEnabled = true;
            this.basketballListBox.ItemHeight = 16;
            this.basketballListBox.Location = new System.Drawing.Point(7, 22);
            this.basketballListBox.Name = "basketballListBox";
            this.basketballListBox.Size = new System.Drawing.Size(252, 196);
            this.basketballListBox.TabIndex = 0;
            this.basketballListBox.SelectedIndexChanged += new System.EventHandler(this.basketballListBox_SelectedIndexChanged);
            // 
            // footballGroupBox
            // 
            this.footballGroupBox.Controls.Add(this.footballListBox);
            this.footballGroupBox.Location = new System.Drawing.Point(338, 13);
            this.footballGroupBox.Name = "footballGroupBox";
            this.footballGroupBox.Size = new System.Drawing.Size(265, 224);
            this.footballGroupBox.TabIndex = 1;
            this.footballGroupBox.TabStop = false;
            this.footballGroupBox.Text = "Фудбал";
            // 
            // footballListBox
            // 
            this.footballListBox.FormattingEnabled = true;
            this.footballListBox.ItemHeight = 16;
            this.footballListBox.Location = new System.Drawing.Point(7, 22);
            this.footballListBox.Name = "footballListBox";
            this.footballListBox.Size = new System.Drawing.Size(252, 196);
            this.footballListBox.TabIndex = 0;
            this.footballListBox.SelectedIndexChanged += new System.EventHandler(this.footballListBox_SelectedIndexChanged);
            // 
            // gameDetailsBox
            // 
            this.gameDetailsBox.Controls.Add(this.gameDateTextBox);
            this.gameDetailsBox.Controls.Add(this.gameDateLabel);
            this.gameDetailsBox.Controls.Add(this.shootersAwayListBox);
            this.gameDetailsBox.Controls.Add(this.shootersAwayLabel);
            this.gameDetailsBox.Controls.Add(this.shootersHomeListBox);
            this.gameDetailsBox.Controls.Add(this.shootersHomeLabel);
            this.gameDetailsBox.Controls.Add(this.gameAwayTextBox);
            this.gameDetailsBox.Controls.Add(this.gameScoreTextBox);
            this.gameDetailsBox.Controls.Add(this.gameHomeTextBox);
            this.gameDetailsBox.Controls.Add(this.gameLabel);
            this.gameDetailsBox.Location = new System.Drawing.Point(13, 244);
            this.gameDetailsBox.Name = "gameDetailsBox";
            this.gameDetailsBox.Size = new System.Drawing.Size(590, 233);
            this.gameDetailsBox.TabIndex = 2;
            this.gameDetailsBox.TabStop = false;
            this.gameDetailsBox.Text = "Детали за натпревар";
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(54, 34);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(80, 17);
            this.gameLabel.TabIndex = 0;
            this.gameLabel.Text = "Натпревар";
            // 
            // gameHomeTextBox
            // 
            this.gameHomeTextBox.Location = new System.Drawing.Point(137, 34);
            this.gameHomeTextBox.Name = "gameHomeTextBox";
            this.gameHomeTextBox.ReadOnly = true;
            this.gameHomeTextBox.Size = new System.Drawing.Size(128, 22);
            this.gameHomeTextBox.TabIndex = 1;
            // 
            // gameScoreTextBox
            // 
            this.gameScoreTextBox.Location = new System.Drawing.Point(271, 34);
            this.gameScoreTextBox.Name = "gameScoreTextBox";
            this.gameScoreTextBox.ReadOnly = true;
            this.gameScoreTextBox.Size = new System.Drawing.Size(51, 22);
            this.gameScoreTextBox.TabIndex = 2;
            // 
            // gameAwayTextBox
            // 
            this.gameAwayTextBox.Location = new System.Drawing.Point(328, 34);
            this.gameAwayTextBox.Name = "gameAwayTextBox";
            this.gameAwayTextBox.ReadOnly = true;
            this.gameAwayTextBox.Size = new System.Drawing.Size(128, 22);
            this.gameAwayTextBox.TabIndex = 3;
            // 
            // shootersHomeLabel
            // 
            this.shootersHomeLabel.AutoSize = true;
            this.shootersHomeLabel.Location = new System.Drawing.Point(137, 63);
            this.shootersHomeLabel.Name = "shootersHomeLabel";
            this.shootersHomeLabel.Size = new System.Drawing.Size(64, 17);
            this.shootersHomeLabel.TabIndex = 4;
            this.shootersHomeLabel.Text = "Стрелци";
            // 
            // shootersHomeListBox
            // 
            this.shootersHomeListBox.FormattingEnabled = true;
            this.shootersHomeListBox.ItemHeight = 16;
            this.shootersHomeListBox.Location = new System.Drawing.Point(137, 84);
            this.shootersHomeListBox.Name = "shootersHomeListBox";
            this.shootersHomeListBox.Size = new System.Drawing.Size(128, 100);
            this.shootersHomeListBox.TabIndex = 5;
            // 
            // shootersAwayListBox
            // 
            this.shootersAwayListBox.FormattingEnabled = true;
            this.shootersAwayListBox.ItemHeight = 16;
            this.shootersAwayListBox.Location = new System.Drawing.Point(328, 84);
            this.shootersAwayListBox.Name = "shootersAwayListBox";
            this.shootersAwayListBox.Size = new System.Drawing.Size(128, 100);
            this.shootersAwayListBox.TabIndex = 7;
            // 
            // shootersAwayLabel
            // 
            this.shootersAwayLabel.AutoSize = true;
            this.shootersAwayLabel.Location = new System.Drawing.Point(329, 63);
            this.shootersAwayLabel.Name = "shootersAwayLabel";
            this.shootersAwayLabel.Size = new System.Drawing.Size(64, 17);
            this.shootersAwayLabel.TabIndex = 6;
            this.shootersAwayLabel.Text = "Стрелци";
            // 
            // gameDateLabel
            // 
            this.gameDateLabel.AutoSize = true;
            this.gameDateLabel.Location = new System.Drawing.Point(54, 198);
            this.gameDateLabel.Name = "gameDateLabel";
            this.gameDateLabel.Size = new System.Drawing.Size(84, 17);
            this.gameDateLabel.TabIndex = 8;
            this.gameDateLabel.Text = "Одржан на:";
            // 
            // gameDateTextBox
            // 
            this.gameDateTextBox.Location = new System.Drawing.Point(137, 198);
            this.gameDateTextBox.Name = "gameDateTextBox";
            this.gameDateTextBox.ReadOnly = true;
            this.gameDateTextBox.Size = new System.Drawing.Size(319, 22);
            this.gameDateTextBox.TabIndex = 9;
            // 
            // addGameButton
            // 
            this.addGameButton.Location = new System.Drawing.Point(38, 484);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(195, 53);
            this.addGameButton.TabIndex = 3;
            this.addGameButton.Text = "Додади натпревар";
            this.addGameButton.UseVisualStyleBackColor = true;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.Location = new System.Drawing.Point(384, 483);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(195, 53);
            this.closeWindowButton.TabIndex = 4;
            this.closeWindowButton.Text = "Затвори прозорец";
            this.closeWindowButton.UseVisualStyleBackColor = true;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 549);
            this.Controls.Add(this.closeWindowButton);
            this.Controls.Add(this.addGameButton);
            this.Controls.Add(this.gameDetailsBox);
            this.Controls.Add(this.footballGroupBox);
            this.Controls.Add(this.basketballGroupBox);
            this.Name = "Form1";
            this.Text = "Резултати";
            this.basketballGroupBox.ResumeLayout(false);
            this.footballGroupBox.ResumeLayout(false);
            this.gameDetailsBox.ResumeLayout(false);
            this.gameDetailsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox basketballGroupBox;
        private System.Windows.Forms.ListBox basketballListBox;
        private System.Windows.Forms.GroupBox footballGroupBox;
        private System.Windows.Forms.ListBox footballListBox;
        private System.Windows.Forms.GroupBox gameDetailsBox;
        private System.Windows.Forms.TextBox gameDateTextBox;
        private System.Windows.Forms.Label gameDateLabel;
        private System.Windows.Forms.ListBox shootersAwayListBox;
        private System.Windows.Forms.Label shootersAwayLabel;
        private System.Windows.Forms.ListBox shootersHomeListBox;
        private System.Windows.Forms.Label shootersHomeLabel;
        private System.Windows.Forms.TextBox gameAwayTextBox;
        private System.Windows.Forms.TextBox gameScoreTextBox;
        private System.Windows.Forms.TextBox gameHomeTextBox;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.Button closeWindowButton;
    }
}

