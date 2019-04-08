namespace Aerodromi
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
            this.airportListBox = new System.Windows.Forms.ListBox();
            this.destinationListBox = new System.Windows.Forms.ListBox();
            this.airportListBoxLabel = new System.Windows.Forms.Label();
            this.destinationListBoxLabel = new System.Windows.Forms.Label();
            this.addAirportButton = new System.Windows.Forms.Button();
            this.deleteAirportButton = new System.Windows.Forms.Button();
            this.addDestinationButton = new System.Windows.Forms.Button();
            this.destinationGroupBox = new System.Windows.Forms.GroupBox();
            this.mostExpensiveDestinationTextBox = new System.Windows.Forms.TextBox();
            this.mostExpensiveDestinationLabel = new System.Windows.Forms.Label();
            this.avgDestinationLengthLabel = new System.Windows.Forms.Label();
            this.avgDestinationLengthTextBox = new System.Windows.Forms.TextBox();
            this.destinationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // airportListBox
            // 
            this.airportListBox.FormattingEnabled = true;
            this.airportListBox.ItemHeight = 16;
            this.airportListBox.Location = new System.Drawing.Point(12, 31);
            this.airportListBox.Name = "airportListBox";
            this.airportListBox.Size = new System.Drawing.Size(374, 324);
            this.airportListBox.TabIndex = 0;
            this.airportListBox.SelectedIndexChanged += new System.EventHandler(this.airportListBox_SelectedIndexChanged);
            // 
            // destinationListBox
            // 
            this.destinationListBox.FormattingEnabled = true;
            this.destinationListBox.ItemHeight = 16;
            this.destinationListBox.Location = new System.Drawing.Point(414, 31);
            this.destinationListBox.Name = "destinationListBox";
            this.destinationListBox.Size = new System.Drawing.Size(374, 324);
            this.destinationListBox.TabIndex = 1;
            // 
            // airportListBoxLabel
            // 
            this.airportListBoxLabel.AutoSize = true;
            this.airportListBoxLabel.Location = new System.Drawing.Point(13, 8);
            this.airportListBoxLabel.Name = "airportListBoxLabel";
            this.airportListBoxLabel.Size = new System.Drawing.Size(82, 17);
            this.airportListBoxLabel.TabIndex = 2;
            this.airportListBoxLabel.Text = "Аеродроми";
            // 
            // destinationListBoxLabel
            // 
            this.destinationListBoxLabel.AutoSize = true;
            this.destinationListBoxLabel.Location = new System.Drawing.Point(411, 8);
            this.destinationListBoxLabel.Name = "destinationListBoxLabel";
            this.destinationListBoxLabel.Size = new System.Drawing.Size(89, 17);
            this.destinationListBoxLabel.TabIndex = 3;
            this.destinationListBoxLabel.Text = "Дестинации";
            // 
            // addAirportButton
            // 
            this.addAirportButton.Location = new System.Drawing.Point(12, 370);
            this.addAirportButton.Name = "addAirportButton";
            this.addAirportButton.Size = new System.Drawing.Size(374, 36);
            this.addAirportButton.TabIndex = 4;
            this.addAirportButton.Text = "Додади аеродром";
            this.addAirportButton.UseVisualStyleBackColor = true;
            this.addAirportButton.Click += new System.EventHandler(this.addAirportButton_Click);
            // 
            // deleteAirportButton
            // 
            this.deleteAirportButton.Location = new System.Drawing.Point(12, 412);
            this.deleteAirportButton.Name = "deleteAirportButton";
            this.deleteAirportButton.Size = new System.Drawing.Size(374, 36);
            this.deleteAirportButton.TabIndex = 5;
            this.deleteAirportButton.Text = "Избриши аеродром";
            this.deleteAirportButton.UseVisualStyleBackColor = true;
            this.deleteAirportButton.Click += new System.EventHandler(this.deleteAirportButton_Click);
            // 
            // addDestinationButton
            // 
            this.addDestinationButton.Location = new System.Drawing.Point(12, 454);
            this.addDestinationButton.Name = "addDestinationButton";
            this.addDestinationButton.Size = new System.Drawing.Size(374, 36);
            this.addDestinationButton.TabIndex = 6;
            this.addDestinationButton.Text = "Додади дестинација";
            this.addDestinationButton.UseVisualStyleBackColor = true;
            this.addDestinationButton.Click += new System.EventHandler(this.addDestinationButton_Click);
            // 
            // destinationGroupBox
            // 
            this.destinationGroupBox.Controls.Add(this.avgDestinationLengthLabel);
            this.destinationGroupBox.Controls.Add(this.avgDestinationLengthTextBox);
            this.destinationGroupBox.Controls.Add(this.mostExpensiveDestinationLabel);
            this.destinationGroupBox.Controls.Add(this.mostExpensiveDestinationTextBox);
            this.destinationGroupBox.Location = new System.Drawing.Point(414, 370);
            this.destinationGroupBox.Name = "destinationGroupBox";
            this.destinationGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.destinationGroupBox.Size = new System.Drawing.Size(374, 120);
            this.destinationGroupBox.TabIndex = 7;
            this.destinationGroupBox.TabStop = false;
            this.destinationGroupBox.Text = "Дестинации";
            // 
            // mostExpensiveDestinationTextBox
            // 
            this.mostExpensiveDestinationTextBox.Location = new System.Drawing.Point(7, 42);
            this.mostExpensiveDestinationTextBox.Name = "mostExpensiveDestinationTextBox";
            this.mostExpensiveDestinationTextBox.ReadOnly = true;
            this.mostExpensiveDestinationTextBox.Size = new System.Drawing.Size(361, 22);
            this.mostExpensiveDestinationTextBox.TabIndex = 0;
            // 
            // mostExpensiveDestinationLabel
            // 
            this.mostExpensiveDestinationLabel.AutoSize = true;
            this.mostExpensiveDestinationLabel.Location = new System.Drawing.Point(7, 19);
            this.mostExpensiveDestinationLabel.Name = "mostExpensiveDestinationLabel";
            this.mostExpensiveDestinationLabel.Size = new System.Drawing.Size(152, 17);
            this.mostExpensiveDestinationLabel.TabIndex = 1;
            this.mostExpensiveDestinationLabel.Text = "Најскапа дестинација";
            // 
            // avgDestinationLengthLabel
            // 
            this.avgDestinationLengthLabel.AutoSize = true;
            this.avgDestinationLengthLabel.Location = new System.Drawing.Point(7, 69);
            this.avgDestinationLengthLabel.Name = "avgDestinationLengthLabel";
            this.avgDestinationLengthLabel.Size = new System.Drawing.Size(251, 17);
            this.avgDestinationLengthLabel.TabIndex = 3;
            this.avgDestinationLengthLabel.Text = "Просечна должина на дестинациите";
            // 
            // avgDestinationLengthTextBox
            // 
            this.avgDestinationLengthTextBox.Location = new System.Drawing.Point(7, 92);
            this.avgDestinationLengthTextBox.Name = "avgDestinationLengthTextBox";
            this.avgDestinationLengthTextBox.ReadOnly = true;
            this.avgDestinationLengthTextBox.Size = new System.Drawing.Size(361, 22);
            this.avgDestinationLengthTextBox.TabIndex = 2;
            this.avgDestinationLengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.destinationGroupBox);
            this.Controls.Add(this.addDestinationButton);
            this.Controls.Add(this.deleteAirportButton);
            this.Controls.Add(this.addAirportButton);
            this.Controls.Add(this.destinationListBoxLabel);
            this.Controls.Add(this.airportListBoxLabel);
            this.Controls.Add(this.destinationListBox);
            this.Controls.Add(this.airportListBox);
            this.Name = "Form1";
            this.Text = "Аеродроми";
            this.destinationGroupBox.ResumeLayout(false);
            this.destinationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox airportListBox;
        private System.Windows.Forms.ListBox destinationListBox;
        private System.Windows.Forms.Label airportListBoxLabel;
        private System.Windows.Forms.Label destinationListBoxLabel;
        private System.Windows.Forms.Button addAirportButton;
        private System.Windows.Forms.Button deleteAirportButton;
        private System.Windows.Forms.Button addDestinationButton;
        private System.Windows.Forms.GroupBox destinationGroupBox;
        private System.Windows.Forms.Label avgDestinationLengthLabel;
        private System.Windows.Forms.TextBox avgDestinationLengthTextBox;
        private System.Windows.Forms.Label mostExpensiveDestinationLabel;
        private System.Windows.Forms.TextBox mostExpensiveDestinationTextBox;
    }
}

