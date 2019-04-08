namespace Aerodromi
{
    partial class Form3
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
            this.addNewDestinationBox = new System.Windows.Forms.GroupBox();
            this.destinationForAirportTextBox = new System.Windows.Forms.TextBox();
            this.destinationForAirportLabel = new System.Windows.Forms.Label();
            this.newDestinationNameLabel = new System.Windows.Forms.Label();
            this.newDestinationNameTextBox = new System.Windows.Forms.TextBox();
            this.newDestinationLengthLabel = new System.Windows.Forms.Label();
            this.newDestinationLengthData = new System.Windows.Forms.NumericUpDown();
            this.newDestinationPriceData = new System.Windows.Forms.NumericUpDown();
            this.newDestinationPriceLabel = new System.Windows.Forms.Label();
            this.addNewDestinationOK = new System.Windows.Forms.Button();
            this.addNewDestinationNOK = new System.Windows.Forms.Button();
            this.addNewDestinationBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newDestinationLengthData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDestinationPriceData)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewDestinationBox
            // 
            this.addNewDestinationBox.Controls.Add(this.addNewDestinationNOK);
            this.addNewDestinationBox.Controls.Add(this.addNewDestinationOK);
            this.addNewDestinationBox.Controls.Add(this.newDestinationPriceData);
            this.addNewDestinationBox.Controls.Add(this.newDestinationPriceLabel);
            this.addNewDestinationBox.Controls.Add(this.newDestinationLengthData);
            this.addNewDestinationBox.Controls.Add(this.newDestinationLengthLabel);
            this.addNewDestinationBox.Controls.Add(this.newDestinationNameLabel);
            this.addNewDestinationBox.Controls.Add(this.newDestinationNameTextBox);
            this.addNewDestinationBox.Controls.Add(this.destinationForAirportLabel);
            this.addNewDestinationBox.Controls.Add(this.destinationForAirportTextBox);
            this.addNewDestinationBox.Location = new System.Drawing.Point(13, 13);
            this.addNewDestinationBox.Name = "addNewDestinationBox";
            this.addNewDestinationBox.Size = new System.Drawing.Size(300, 269);
            this.addNewDestinationBox.TabIndex = 0;
            this.addNewDestinationBox.TabStop = false;
            this.addNewDestinationBox.Text = "Додади дестинација";
            // 
            // destinationForAirportTextBox
            // 
            this.destinationForAirportTextBox.Location = new System.Drawing.Point(6, 51);
            this.destinationForAirportTextBox.Name = "destinationForAirportTextBox";
            this.destinationForAirportTextBox.ReadOnly = true;
            this.destinationForAirportTextBox.Size = new System.Drawing.Size(287, 22);
            this.destinationForAirportTextBox.TabIndex = 0;
            // 
            // destinationForAirportLabel
            // 
            this.destinationForAirportLabel.AutoSize = true;
            this.destinationForAirportLabel.Location = new System.Drawing.Point(3, 31);
            this.destinationForAirportLabel.Name = "destinationForAirportLabel";
            this.destinationForAirportLabel.Size = new System.Drawing.Size(184, 17);
            this.destinationForAirportLabel.TabIndex = 1;
            this.destinationForAirportLabel.Text = "Дестинација за аеродром:";
            // 
            // newDestinationNameLabel
            // 
            this.newDestinationNameLabel.AutoSize = true;
            this.newDestinationNameLabel.Location = new System.Drawing.Point(3, 82);
            this.newDestinationNameLabel.Name = "newDestinationNameLabel";
            this.newDestinationNameLabel.Size = new System.Drawing.Size(39, 17);
            this.newDestinationNameLabel.TabIndex = 3;
            this.newDestinationNameLabel.Text = "Име:";
            // 
            // newDestinationNameTextBox
            // 
            this.newDestinationNameTextBox.Location = new System.Drawing.Point(6, 102);
            this.newDestinationNameTextBox.Name = "newDestinationNameTextBox";
            this.newDestinationNameTextBox.Size = new System.Drawing.Size(287, 22);
            this.newDestinationNameTextBox.TabIndex = 2;
            // 
            // newDestinationLengthLabel
            // 
            this.newDestinationLengthLabel.AutoSize = true;
            this.newDestinationLengthLabel.Location = new System.Drawing.Point(6, 142);
            this.newDestinationLengthLabel.Name = "newDestinationLengthLabel";
            this.newDestinationLengthLabel.Size = new System.Drawing.Size(68, 17);
            this.newDestinationLengthLabel.TabIndex = 4;
            this.newDestinationLengthLabel.Text = "Должина";
            // 
            // newDestinationLengthData
            // 
            this.newDestinationLengthData.Location = new System.Drawing.Point(6, 162);
            this.newDestinationLengthData.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.newDestinationLengthData.Name = "newDestinationLengthData";
            this.newDestinationLengthData.Size = new System.Drawing.Size(119, 22);
            this.newDestinationLengthData.TabIndex = 5;
            // 
            // newDestinationPriceData
            // 
            this.newDestinationPriceData.Location = new System.Drawing.Point(174, 162);
            this.newDestinationPriceData.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.newDestinationPriceData.Name = "newDestinationPriceData";
            this.newDestinationPriceData.Size = new System.Drawing.Size(119, 22);
            this.newDestinationPriceData.TabIndex = 7;
            // 
            // newDestinationPriceLabel
            // 
            this.newDestinationPriceLabel.AutoSize = true;
            this.newDestinationPriceLabel.Location = new System.Drawing.Point(171, 142);
            this.newDestinationPriceLabel.Name = "newDestinationPriceLabel";
            this.newDestinationPriceLabel.Size = new System.Drawing.Size(43, 17);
            this.newDestinationPriceLabel.TabIndex = 6;
            this.newDestinationPriceLabel.Text = "Цена";
            // 
            // addNewDestinationOK
            // 
            this.addNewDestinationOK.Location = new System.Drawing.Point(6, 206);
            this.addNewDestinationOK.Name = "addNewDestinationOK";
            this.addNewDestinationOK.Size = new System.Drawing.Size(123, 57);
            this.addNewDestinationOK.TabIndex = 8;
            this.addNewDestinationOK.Text = "Додади";
            this.addNewDestinationOK.UseVisualStyleBackColor = true;
            this.addNewDestinationOK.Click += new System.EventHandler(this.addNewDestinationOK_Click);
            // 
            // addNewDestinationNOK
            // 
            this.addNewDestinationNOK.Location = new System.Drawing.Point(170, 206);
            this.addNewDestinationNOK.Name = "addNewDestinationNOK";
            this.addNewDestinationNOK.Size = new System.Drawing.Size(123, 57);
            this.addNewDestinationNOK.TabIndex = 9;
            this.addNewDestinationNOK.Text = "Откажи";
            this.addNewDestinationNOK.UseVisualStyleBackColor = true;
            this.addNewDestinationNOK.Click += new System.EventHandler(this.addNewDestinationNOK_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 294);
            this.Controls.Add(this.addNewDestinationBox);
            this.Name = "Form3";
            this.Text = "Нова дестинација";
            this.addNewDestinationBox.ResumeLayout(false);
            this.addNewDestinationBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newDestinationLengthData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDestinationPriceData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addNewDestinationBox;
        private System.Windows.Forms.Button addNewDestinationNOK;
        private System.Windows.Forms.Button addNewDestinationOK;
        private System.Windows.Forms.NumericUpDown newDestinationPriceData;
        private System.Windows.Forms.Label newDestinationPriceLabel;
        private System.Windows.Forms.NumericUpDown newDestinationLengthData;
        private System.Windows.Forms.Label newDestinationLengthLabel;
        private System.Windows.Forms.Label newDestinationNameLabel;
        private System.Windows.Forms.TextBox newDestinationNameTextBox;
        private System.Windows.Forms.Label destinationForAirportLabel;
        private System.Windows.Forms.TextBox destinationForAirportTextBox;
    }
}