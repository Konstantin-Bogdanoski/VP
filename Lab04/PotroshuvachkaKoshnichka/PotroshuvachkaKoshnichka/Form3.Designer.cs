namespace PotroshuvachkaKoshnichka
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
            this.deleteProductOK = new System.Windows.Forms.Button();
            this.deleteProductNOK = new System.Windows.Forms.Button();
            this.allProductsListBox = new System.Windows.Forms.ListBox();
            this.allProductsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteProductOK
            // 
            this.deleteProductOK.Location = new System.Drawing.Point(23, 387);
            this.deleteProductOK.Name = "deleteProductOK";
            this.deleteProductOK.Size = new System.Drawing.Size(127, 67);
            this.deleteProductOK.TabIndex = 0;
            this.deleteProductOK.Text = "Избриши продукт";
            this.deleteProductOK.UseVisualStyleBackColor = true;
            this.deleteProductOK.Click += new System.EventHandler(this.deleteProductOK_Click);
            // 
            // deleteProductNOK
            // 
            this.deleteProductNOK.Location = new System.Drawing.Point(177, 387);
            this.deleteProductNOK.Name = "deleteProductNOK";
            this.deleteProductNOK.Size = new System.Drawing.Size(127, 67);
            this.deleteProductNOK.TabIndex = 1;
            this.deleteProductNOK.Text = "Откажи";
            this.deleteProductNOK.UseVisualStyleBackColor = true;
            this.deleteProductNOK.Click += new System.EventHandler(this.deleteProductNOK_Click);
            // 
            // allProductsListBox
            // 
            this.allProductsListBox.FormattingEnabled = true;
            this.allProductsListBox.ItemHeight = 16;
            this.allProductsListBox.Location = new System.Drawing.Point(23, 62);
            this.allProductsListBox.Name = "allProductsListBox";
            this.allProductsListBox.Size = new System.Drawing.Size(281, 308);
            this.allProductsListBox.TabIndex = 2;
            // 
            // allProductsLabel
            // 
            this.allProductsLabel.AutoSize = true;
            this.allProductsLabel.Location = new System.Drawing.Point(20, 32);
            this.allProductsLabel.Name = "allProductsLabel";
            this.allProductsLabel.Size = new System.Drawing.Size(167, 17);
            this.allProductsLabel.TabIndex = 3;
            this.allProductsLabel.Text = "Листа на сите продукти";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 466);
            this.Controls.Add(this.allProductsLabel);
            this.Controls.Add(this.allProductsListBox);
            this.Controls.Add(this.deleteProductNOK);
            this.Controls.Add(this.deleteProductOK);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteProductOK;
        private System.Windows.Forms.Button deleteProductNOK;
        private System.Windows.Forms.ListBox allProductsListBox;
        private System.Windows.Forms.Label allProductsLabel;
    }
}