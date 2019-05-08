namespace Pacman
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.progressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarValue = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scoreToolStripMenuItem,
            this.scoreTextBox,
            this.progressToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "pacmanMenuStrip";
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(61, 27);
            this.scoreToolStripMenuItem.Text = "Score:";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.ReadOnly = true;
            this.scoreTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // progressToolStripMenuItem
            // 
            this.progressToolStripMenuItem.Name = "progressToolStripMenuItem";
            this.progressToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.progressToolStripMenuItem.Text = "Progress:";
            // 
            // progressBarValue
            // 
            this.progressBarValue.Location = new System.Drawing.Point(257, 0);
            this.progressBarValue.Name = "progressBarValue";
            this.progressBarValue.Size = new System.Drawing.Size(526, 31);
            this.progressBarValue.TabIndex = 1;
            this.progressBarValue.Click += new System.EventHandler(this.progressBarValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 631);
            this.Controls.Add(this.progressBarValue);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pacman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox scoreTextBox;
        private System.Windows.Forms.ToolStripMenuItem progressToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBarValue;
    }
}

