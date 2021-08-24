
namespace Auram_Investigator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titlebar = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Panel();
            this.Viewer = new System.Windows.Forms.TreeView();
            this.TXT = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlebar
            // 
            this.Titlebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Titlebar.Controls.Add(this.Exit);
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(1200, 30);
            this.Titlebar.TabIndex = 0;
            this.Titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            this.Titlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseMove);
            this.Titlebar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseUp);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.DimGray;
            this.Exit.Location = new System.Drawing.Point(1175, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(20, 20);
            this.Exit.TabIndex = 1;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // Viewer
            // 
            this.Viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Viewer.BackColor = System.Drawing.Color.DimGray;
            this.Viewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Viewer.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Viewer.ForeColor = System.Drawing.Color.LightGray;
            this.Viewer.Indent = 30;
            this.Viewer.Location = new System.Drawing.Point(12, 36);
            this.Viewer.Name = "Viewer";
            this.Viewer.Size = new System.Drawing.Size(1176, 585);
            this.Viewer.TabIndex = 2;
            this.Viewer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Viewer_AfterSelect);
            // 
            // TXT
            // 
            this.TXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TXT.AutoSize = true;
            this.TXT.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXT.ForeColor = System.Drawing.Color.LightGray;
            this.TXT.Location = new System.Drawing.Point(12, 633);
            this.TXT.Name = "TXT";
            this.TXT.Size = new System.Drawing.Size(600, 33);
            this.TXT.TabIndex = 3;
            this.TXT.Text = "TTMC Corporation » Auram Investigator v0.1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Auram_Investigator.Properties.Resources.TTMC_ICON_WHITE;
            this.pictureBox1.Location = new System.Drawing.Point(1088, 566);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TXT);
            this.Controls.Add(this.Viewer);
            this.Controls.Add(this.Titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Main";
            this.Titlebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Titlebar;
        private System.Windows.Forms.Panel Exit;
        private System.Windows.Forms.TreeView Viewer;
        private System.Windows.Forms.Label TXT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

