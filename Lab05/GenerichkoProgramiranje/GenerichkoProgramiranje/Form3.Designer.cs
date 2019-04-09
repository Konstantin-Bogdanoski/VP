namespace GenerichkoProgramiranje
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
            this.playerBox = new System.Windows.Forms.GroupBox();
            this.playerTextBox = new System.Windows.Forms.TextBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.addPlayerOK = new System.Windows.Forms.Button();
            this.addPlayerNOK = new System.Windows.Forms.Button();
            this.playerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerBox
            // 
            this.playerBox.Controls.Add(this.addPlayerNOK);
            this.playerBox.Controls.Add(this.addPlayerOK);
            this.playerBox.Controls.Add(this.scoreLabel);
            this.playerBox.Controls.Add(this.scoreTextBox);
            this.playerBox.Controls.Add(this.playerLabel);
            this.playerBox.Controls.Add(this.playerTextBox);
            this.playerBox.Location = new System.Drawing.Point(13, 13);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(259, 177);
            this.playerBox.TabIndex = 0;
            this.playerBox.TabStop = false;
            // 
            // playerTextBox
            // 
            this.playerTextBox.Location = new System.Drawing.Point(116, 35);
            this.playerTextBox.Name = "playerTextBox";
            this.playerTextBox.Size = new System.Drawing.Size(137, 22);
            this.playerTextBox.TabIndex = 0;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(33, 38);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(47, 17);
            this.playerLabel.TabIndex = 1;
            this.playerLabel.Text = "Играч";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(7, 84);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(103, 17);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Поени/Минута";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(116, 81);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(137, 22);
            this.scoreTextBox.TabIndex = 2;
            // 
            // addPlayerOK
            // 
            this.addPlayerOK.Location = new System.Drawing.Point(10, 127);
            this.addPlayerOK.Name = "addPlayerOK";
            this.addPlayerOK.Size = new System.Drawing.Size(109, 39);
            this.addPlayerOK.TabIndex = 4;
            this.addPlayerOK.Text = "Додади";
            this.addPlayerOK.UseVisualStyleBackColor = true;
            this.addPlayerOK.Click += new System.EventHandler(this.addPlayerOK_Click);
            // 
            // addPlayerNOK
            // 
            this.addPlayerNOK.Location = new System.Drawing.Point(134, 127);
            this.addPlayerNOK.Name = "addPlayerNOK";
            this.addPlayerNOK.Size = new System.Drawing.Size(109, 39);
            this.addPlayerNOK.TabIndex = 5;
            this.addPlayerNOK.Text = "Откажи";
            this.addPlayerNOK.UseVisualStyleBackColor = true;
            this.addPlayerNOK.Click += new System.EventHandler(this.addPlayerNOK_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 199);
            this.Controls.Add(this.playerBox);
            this.Name = "Form3";
            this.Text = "Додади стрелец";
            this.playerBox.ResumeLayout(false);
            this.playerBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox playerBox;
        private System.Windows.Forms.Button addPlayerNOK;
        private System.Windows.Forms.Button addPlayerOK;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.TextBox playerTextBox;
    }
}