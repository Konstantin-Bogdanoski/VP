namespace Aerodromi
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
            this.addAirportBox = new System.Windows.Forms.GroupBox();
            this.newAirportCityTextBox = new System.Windows.Forms.TextBox();
            this.newAirportCityLabel = new System.Windows.Forms.Label();
            this.newAirportNameLabel = new System.Windows.Forms.Label();
            this.newAirportNameTextBox = new System.Windows.Forms.TextBox();
            this.newAirportSlangLabel = new System.Windows.Forms.Label();
            this.newAirportSlangTextBox = new System.Windows.Forms.TextBox();
            this.addNewAirportOK = new System.Windows.Forms.Button();
            this.addNewAirportNOK = new System.Windows.Forms.Button();
            this.newAirportNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.newAirportCityErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.newAirportSlangErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addAirportBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newAirportNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAirportCityErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAirportSlangErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // addAirportBox
            // 
            this.addAirportBox.Controls.Add(this.addNewAirportNOK);
            this.addAirportBox.Controls.Add(this.addNewAirportOK);
            this.addAirportBox.Controls.Add(this.newAirportSlangLabel);
            this.addAirportBox.Controls.Add(this.newAirportSlangTextBox);
            this.addAirportBox.Controls.Add(this.newAirportNameLabel);
            this.addAirportBox.Controls.Add(this.newAirportNameTextBox);
            this.addAirportBox.Controls.Add(this.newAirportCityLabel);
            this.addAirportBox.Controls.Add(this.newAirportCityTextBox);
            this.addAirportBox.Location = new System.Drawing.Point(13, 13);
            this.addAirportBox.Name = "addAirportBox";
            this.addAirportBox.Size = new System.Drawing.Size(325, 262);
            this.addAirportBox.TabIndex = 0;
            this.addAirportBox.TabStop = false;
            this.addAirportBox.Text = "Додади аеродром";
            // 
            // newAirportCityTextBox
            // 
            this.newAirportCityTextBox.Location = new System.Drawing.Point(35, 50);
            this.newAirportCityTextBox.Name = "newAirportCityTextBox";
            this.newAirportCityTextBox.Size = new System.Drawing.Size(259, 22);
            this.newAirportCityTextBox.TabIndex = 0;
            // 
            // newAirportCityLabel
            // 
            this.newAirportCityLabel.AutoSize = true;
            this.newAirportCityLabel.Location = new System.Drawing.Point(32, 30);
            this.newAirportCityLabel.Name = "newAirportCityLabel";
            this.newAirportCityLabel.Size = new System.Drawing.Size(40, 17);
            this.newAirportCityLabel.TabIndex = 1;
            this.newAirportCityLabel.Text = "Град";
            // 
            // newAirportNameLabel
            // 
            this.newAirportNameLabel.AutoSize = true;
            this.newAirportNameLabel.Location = new System.Drawing.Point(32, 89);
            this.newAirportNameLabel.Name = "newAirportNameLabel";
            this.newAirportNameLabel.Size = new System.Drawing.Size(35, 17);
            this.newAirportNameLabel.TabIndex = 3;
            this.newAirportNameLabel.Text = "Име";
            // 
            // newAirportNameTextBox
            // 
            this.newAirportNameTextBox.Location = new System.Drawing.Point(35, 109);
            this.newAirportNameTextBox.Name = "newAirportNameTextBox";
            this.newAirportNameTextBox.Size = new System.Drawing.Size(259, 22);
            this.newAirportNameTextBox.TabIndex = 2;
            // 
            // newAirportSlangLabel
            // 
            this.newAirportSlangLabel.AutoSize = true;
            this.newAirportSlangLabel.Location = new System.Drawing.Point(32, 143);
            this.newAirportSlangLabel.Name = "newAirportSlangLabel";
            this.newAirportSlangLabel.Size = new System.Drawing.Size(71, 17);
            this.newAirportSlangLabel.TabIndex = 5;
            this.newAirportSlangLabel.Text = "Кратенка";
            // 
            // newAirportSlangTextBox
            // 
            this.newAirportSlangTextBox.Location = new System.Drawing.Point(35, 163);
            this.newAirportSlangTextBox.MaxLength = 3;
            this.newAirportSlangTextBox.Name = "newAirportSlangTextBox";
            this.newAirportSlangTextBox.Size = new System.Drawing.Size(158, 22);
            this.newAirportSlangTextBox.TabIndex = 4;
            // 
            // addNewAirportOK
            // 
            this.addNewAirportOK.Location = new System.Drawing.Point(6, 207);
            this.addNewAirportOK.Name = "addNewAirportOK";
            this.addNewAirportOK.Size = new System.Drawing.Size(139, 47);
            this.addNewAirportOK.TabIndex = 6;
            this.addNewAirportOK.Text = "Зачувај";
            this.addNewAirportOK.UseVisualStyleBackColor = true;
            this.addNewAirportOK.Click += new System.EventHandler(this.addNewAirportOK_Click);
            // 
            // addNewAirportNOK
            // 
            this.addNewAirportNOK.Location = new System.Drawing.Point(179, 207);
            this.addNewAirportNOK.Name = "addNewAirportNOK";
            this.addNewAirportNOK.Size = new System.Drawing.Size(139, 47);
            this.addNewAirportNOK.TabIndex = 7;
            this.addNewAirportNOK.Text = "Откажи";
            this.addNewAirportNOK.UseVisualStyleBackColor = true;
            this.addNewAirportNOK.Click += new System.EventHandler(this.addNewAirportNOK_Click);
            // 
            // newAirportNameErrorProvider
            // 
            this.newAirportNameErrorProvider.ContainerControl = this;
            // 
            // newAirportCityErrorProvider
            // 
            this.newAirportCityErrorProvider.ContainerControl = this;
            // 
            // newAirportSlangErrorProvider
            // 
            this.newAirportSlangErrorProvider.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 287);
            this.Controls.Add(this.addAirportBox);
            this.Name = "Form2";
            this.Text = "Нов аеродром";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.addAirportBox.ResumeLayout(false);
            this.addAirportBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newAirportNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAirportCityErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAirportSlangErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addAirportBox;
        private System.Windows.Forms.Button addNewAirportNOK;
        private System.Windows.Forms.Button addNewAirportOK;
        private System.Windows.Forms.Label newAirportSlangLabel;
        private System.Windows.Forms.TextBox newAirportSlangTextBox;
        private System.Windows.Forms.Label newAirportNameLabel;
        private System.Windows.Forms.TextBox newAirportNameTextBox;
        private System.Windows.Forms.Label newAirportCityLabel;
        private System.Windows.Forms.TextBox newAirportCityTextBox;
        private System.Windows.Forms.ErrorProvider newAirportNameErrorProvider;
        private System.Windows.Forms.ErrorProvider newAirportCityErrorProvider;
        private System.Windows.Forms.ErrorProvider newAirportSlangErrorProvider;
    }
}