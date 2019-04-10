namespace F1Trki
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
            this.components = new System.ComponentModel.Container();
            this.driverNameLabel = new System.Windows.Forms.Label();
            this.driverNameTextBox = new System.Windows.Forms.TextBox();
            this.racerAgeLabel = new System.Windows.Forms.Label();
            this.racerNumericAge = new System.Windows.Forms.NumericUpDown();
            this.racerFirstBool = new System.Windows.Forms.CheckBox();
            this.addDriverOK = new System.Windows.Forms.Button();
            this.addDriverNOK = new System.Windows.Forms.Button();
            this.racerNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.driverAgeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.racerNumericAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverAgeError)).BeginInit();
            this.SuspendLayout();
            // 
            // driverNameLabel
            // 
            this.driverNameLabel.AutoSize = true;
            this.driverNameLabel.Location = new System.Drawing.Point(13, 13);
            this.driverNameLabel.Name = "driverNameLabel";
            this.driverNameLabel.Size = new System.Drawing.Size(97, 17);
            this.driverNameLabel.TabIndex = 0;
            this.driverNameLabel.Text = "Име на возач";
            // 
            // driverNameTextBox
            // 
            this.driverNameTextBox.Location = new System.Drawing.Point(16, 34);
            this.driverNameTextBox.Name = "driverNameTextBox";
            this.driverNameTextBox.Size = new System.Drawing.Size(229, 22);
            this.driverNameTextBox.TabIndex = 1;
            this.driverNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.driverNameTextBox_Validating);
            // 
            // racerAgeLabel
            // 
            this.racerAgeLabel.AutoSize = true;
            this.racerAgeLabel.Location = new System.Drawing.Point(12, 70);
            this.racerAgeLabel.Name = "racerAgeLabel";
            this.racerAgeLabel.Size = new System.Drawing.Size(62, 17);
            this.racerAgeLabel.TabIndex = 2;
            this.racerAgeLabel.Text = "Возраст";
            // 
            // racerNumericAge
            // 
            this.racerNumericAge.Location = new System.Drawing.Point(13, 91);
            this.racerNumericAge.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.racerNumericAge.Name = "racerNumericAge";
            this.racerNumericAge.Size = new System.Drawing.Size(120, 22);
            this.racerNumericAge.TabIndex = 3;
            this.racerNumericAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.racerNumericAge.Validating += new System.ComponentModel.CancelEventHandler(this.racerNumericAge_Validating);
            // 
            // racerFirstBool
            // 
            this.racerFirstBool.AutoSize = true;
            this.racerFirstBool.Location = new System.Drawing.Point(140, 91);
            this.racerFirstBool.Name = "racerFirstBool";
            this.racerFirstBool.Size = new System.Drawing.Size(105, 21);
            this.racerFirstBool.TabIndex = 4;
            this.racerFirstBool.Text = "Прв возач?";
            this.racerFirstBool.UseVisualStyleBackColor = true;
            // 
            // addDriverOK
            // 
            this.addDriverOK.Location = new System.Drawing.Point(13, 130);
            this.addDriverOK.Name = "addDriverOK";
            this.addDriverOK.Size = new System.Drawing.Size(120, 41);
            this.addDriverOK.TabIndex = 5;
            this.addDriverOK.Text = "Додади";
            this.addDriverOK.UseVisualStyleBackColor = true;
            this.addDriverOK.Click += new System.EventHandler(this.addDriverOK_Click);
            // 
            // addDriverNOK
            // 
            this.addDriverNOK.Location = new System.Drawing.Point(137, 130);
            this.addDriverNOK.Name = "addDriverNOK";
            this.addDriverNOK.Size = new System.Drawing.Size(120, 41);
            this.addDriverNOK.TabIndex = 6;
            this.addDriverNOK.Text = "Откажи";
            this.addDriverNOK.UseVisualStyleBackColor = true;
            this.addDriverNOK.Click += new System.EventHandler(this.addDriverNOK_Click);
            // 
            // racerNameError
            // 
            this.racerNameError.ContainerControl = this;
            // 
            // driverAgeError
            // 
            this.driverAgeError.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 183);
            this.Controls.Add(this.addDriverNOK);
            this.Controls.Add(this.addDriverOK);
            this.Controls.Add(this.racerFirstBool);
            this.Controls.Add(this.racerNumericAge);
            this.Controls.Add(this.racerAgeLabel);
            this.Controls.Add(this.driverNameTextBox);
            this.Controls.Add(this.driverNameLabel);
            this.Name = "Form2";
            this.Text = "Додај возач";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.racerNumericAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverAgeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label driverNameLabel;
        private System.Windows.Forms.TextBox driverNameTextBox;
        private System.Windows.Forms.Label racerAgeLabel;
        private System.Windows.Forms.NumericUpDown racerNumericAge;
        private System.Windows.Forms.CheckBox racerFirstBool;
        private System.Windows.Forms.Button addDriverOK;
        private System.Windows.Forms.Button addDriverNOK;
        private System.Windows.Forms.ErrorProvider racerNameError;
        private System.Windows.Forms.ErrorProvider driverAgeError;
    }
}