namespace F1Trki
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
            this.driversGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteDriverButton = new System.Windows.Forms.Button();
            this.addDriverButton = new System.Windows.Forms.Button();
            this.driversListBox = new System.Windows.Forms.ListBox();
            this.lapsGroupBox = new System.Windows.Forms.GroupBox();
            this.numericFilter = new System.Windows.Forms.NumericUpDown();
            this.timeFilterLabel = new System.Windows.Forms.Label();
            this.bestLapTextBox = new System.Windows.Forms.TextBox();
            this.bestLapLabel = new System.Windows.Forms.Label();
            this.addLapButton = new System.Windows.Forms.Button();
            this.numericSecondsLabel = new System.Windows.Forms.Label();
            this.numericSeconds = new System.Windows.Forms.NumericUpDown();
            this.numericMinutesLabel = new System.Windows.Forms.Label();
            this.numericMinutes = new System.Windows.Forms.NumericUpDown();
            this.lapsListBox = new System.Windows.Forms.ListBox();
            this.driversGroupBox.SuspendLayout();
            this.lapsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // driversGroupBox
            // 
            this.driversGroupBox.Controls.Add(this.deleteDriverButton);
            this.driversGroupBox.Controls.Add(this.addDriverButton);
            this.driversGroupBox.Controls.Add(this.driversListBox);
            this.driversGroupBox.Location = new System.Drawing.Point(13, 13);
            this.driversGroupBox.Name = "driversGroupBox";
            this.driversGroupBox.Size = new System.Drawing.Size(359, 462);
            this.driversGroupBox.TabIndex = 0;
            this.driversGroupBox.TabStop = false;
            this.driversGroupBox.Text = "Возачи";
            // 
            // deleteDriverButton
            // 
            this.deleteDriverButton.Location = new System.Drawing.Point(7, 406);
            this.deleteDriverButton.Name = "deleteDriverButton";
            this.deleteDriverButton.Size = new System.Drawing.Size(346, 47);
            this.deleteDriverButton.TabIndex = 2;
            this.deleteDriverButton.Text = "Избриши возач";
            this.deleteDriverButton.UseVisualStyleBackColor = true;
            this.deleteDriverButton.Click += new System.EventHandler(this.deleteDriverButton_Click);
            // 
            // addDriverButton
            // 
            this.addDriverButton.Location = new System.Drawing.Point(7, 353);
            this.addDriverButton.Name = "addDriverButton";
            this.addDriverButton.Size = new System.Drawing.Size(346, 47);
            this.addDriverButton.TabIndex = 1;
            this.addDriverButton.Text = "Додади возач";
            this.addDriverButton.UseVisualStyleBackColor = true;
            this.addDriverButton.Click += new System.EventHandler(this.addDriverButton_Click);
            // 
            // driversListBox
            // 
            this.driversListBox.FormattingEnabled = true;
            this.driversListBox.ItemHeight = 16;
            this.driversListBox.Location = new System.Drawing.Point(7, 22);
            this.driversListBox.Name = "driversListBox";
            this.driversListBox.Size = new System.Drawing.Size(346, 324);
            this.driversListBox.TabIndex = 0;
            this.driversListBox.SelectedIndexChanged += new System.EventHandler(this.driversListBox_SelectedIndexChanged);
            // 
            // lapsGroupBox
            // 
            this.lapsGroupBox.Controls.Add(this.numericFilter);
            this.lapsGroupBox.Controls.Add(this.timeFilterLabel);
            this.lapsGroupBox.Controls.Add(this.bestLapTextBox);
            this.lapsGroupBox.Controls.Add(this.bestLapLabel);
            this.lapsGroupBox.Controls.Add(this.addLapButton);
            this.lapsGroupBox.Controls.Add(this.numericSecondsLabel);
            this.lapsGroupBox.Controls.Add(this.numericSeconds);
            this.lapsGroupBox.Controls.Add(this.numericMinutesLabel);
            this.lapsGroupBox.Controls.Add(this.numericMinutes);
            this.lapsGroupBox.Controls.Add(this.lapsListBox);
            this.lapsGroupBox.Location = new System.Drawing.Point(377, 13);
            this.lapsGroupBox.Name = "lapsGroupBox";
            this.lapsGroupBox.Size = new System.Drawing.Size(359, 462);
            this.lapsGroupBox.TabIndex = 1;
            this.lapsGroupBox.TabStop = false;
            this.lapsGroupBox.Text = "Кругови";
            // 
            // numericFilter
            // 
            this.numericFilter.Location = new System.Drawing.Point(63, 421);
            this.numericFilter.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericFilter.Name = "numericFilter";
            this.numericFilter.Size = new System.Drawing.Size(120, 22);
            this.numericFilter.TabIndex = 9;
            this.numericFilter.ValueChanged += new System.EventHandler(this.numericFilter_ValueChanged);
            // 
            // timeFilterLabel
            // 
            this.timeFilterLabel.AutoSize = true;
            this.timeFilterLabel.Location = new System.Drawing.Point(6, 421);
            this.timeFilterLabel.Name = "timeFilterLabel";
            this.timeFilterLabel.Size = new System.Drawing.Size(50, 17);
            this.timeFilterLabel.TabIndex = 8;
            this.timeFilterLabel.Text = "Време";
            // 
            // bestLapTextBox
            // 
            this.bestLapTextBox.Location = new System.Drawing.Point(7, 387);
            this.bestLapTextBox.Name = "bestLapTextBox";
            this.bestLapTextBox.ReadOnly = true;
            this.bestLapTextBox.Size = new System.Drawing.Size(346, 22);
            this.bestLapTextBox.TabIndex = 7;
            this.bestLapTextBox.TextChanged += new System.EventHandler(this.bestLapTextBox_TextChanged);
            // 
            // bestLapLabel
            // 
            this.bestLapLabel.AutoSize = true;
            this.bestLapLabel.Location = new System.Drawing.Point(4, 367);
            this.bestLapLabel.Name = "bestLapLabel";
            this.bestLapLabel.Size = new System.Drawing.Size(100, 17);
            this.bestLapLabel.TabIndex = 6;
            this.bestLapLabel.Text = "Најдобар круг";
            // 
            // addLapButton
            // 
            this.addLapButton.Location = new System.Drawing.Point(246, 300);
            this.addLapButton.Name = "addLapButton";
            this.addLapButton.Size = new System.Drawing.Size(107, 42);
            this.addLapButton.TabIndex = 5;
            this.addLapButton.Text = "Додади круг";
            this.addLapButton.UseVisualStyleBackColor = true;
            this.addLapButton.Click += new System.EventHandler(this.addLapButton_Click);
            // 
            // numericSecondsLabel
            // 
            this.numericSecondsLabel.AutoSize = true;
            this.numericSecondsLabel.Location = new System.Drawing.Point(133, 289);
            this.numericSecondsLabel.Name = "numericSecondsLabel";
            this.numericSecondsLabel.Size = new System.Drawing.Size(67, 17);
            this.numericSecondsLabel.TabIndex = 4;
            this.numericSecondsLabel.Text = "Секунди:";
            // 
            // numericSeconds
            // 
            this.numericSeconds.Location = new System.Drawing.Point(133, 311);
            this.numericSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericSeconds.Name = "numericSeconds";
            this.numericSeconds.Size = new System.Drawing.Size(81, 22);
            this.numericSeconds.TabIndex = 3;
            this.numericSeconds.ValueChanged += new System.EventHandler(this.numericSeconds_ValueChanged);
            // 
            // numericMinutesLabel
            // 
            this.numericMinutesLabel.AutoSize = true;
            this.numericMinutesLabel.Location = new System.Drawing.Point(4, 289);
            this.numericMinutesLabel.Name = "numericMinutesLabel";
            this.numericMinutesLabel.Size = new System.Drawing.Size(61, 17);
            this.numericMinutesLabel.TabIndex = 2;
            this.numericMinutesLabel.Text = "Минути:";
            // 
            // numericMinutes
            // 
            this.numericMinutes.Location = new System.Drawing.Point(7, 311);
            this.numericMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericMinutes.Name = "numericMinutes";
            this.numericMinutes.Size = new System.Drawing.Size(81, 22);
            this.numericMinutes.TabIndex = 1;
            // 
            // lapsListBox
            // 
            this.lapsListBox.FormattingEnabled = true;
            this.lapsListBox.ItemHeight = 16;
            this.lapsListBox.Location = new System.Drawing.Point(7, 22);
            this.lapsListBox.Name = "lapsListBox";
            this.lapsListBox.Size = new System.Drawing.Size(346, 260);
            this.lapsListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 487);
            this.Controls.Add(this.lapsGroupBox);
            this.Controls.Add(this.driversGroupBox);
            this.Name = "Form1";
            this.Text = "Ф1Трка";
            this.driversGroupBox.ResumeLayout(false);
            this.lapsGroupBox.ResumeLayout(false);
            this.lapsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox driversGroupBox;
        private System.Windows.Forms.Button deleteDriverButton;
        private System.Windows.Forms.Button addDriverButton;
        private System.Windows.Forms.ListBox driversListBox;
        private System.Windows.Forms.GroupBox lapsGroupBox;
        private System.Windows.Forms.NumericUpDown numericFilter;
        private System.Windows.Forms.Label timeFilterLabel;
        private System.Windows.Forms.TextBox bestLapTextBox;
        private System.Windows.Forms.Label bestLapLabel;
        private System.Windows.Forms.Button addLapButton;
        private System.Windows.Forms.Label numericSecondsLabel;
        private System.Windows.Forms.NumericUpDown numericSeconds;
        private System.Windows.Forms.Label numericMinutesLabel;
        private System.Windows.Forms.NumericUpDown numericMinutes;
        private System.Windows.Forms.ListBox lapsListBox;
    }
}

