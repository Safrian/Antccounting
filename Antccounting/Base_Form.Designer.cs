namespace Antccounting
{
    partial class Base_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base_Form));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.BtnAnotherTransaction = new System.Windows.Forms.Button();
            this.BtnCashOut = new System.Windows.Forms.Button();
            this.BtnCashIn = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Taskbar = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Resize = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.BtnSlide = new System.Windows.Forms.PictureBox();
            this.panelcontain = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Taskbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(126)))), ((int)(((byte)(79)))));
            this.MenuVertical.Controls.Add(this.BtnAnotherTransaction);
            this.MenuVertical.Controls.Add(this.BtnCashOut);
            this.MenuVertical.Controls.Add(this.BtnCashIn);
            this.MenuVertical.Controls.Add(this.Logo);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 0;
            // 
            // BtnAnotherTransaction
            // 
            this.BtnAnotherTransaction.FlatAppearance.BorderSize = 0;
            this.BtnAnotherTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnAnotherTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnotherTransaction.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnotherTransaction.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAnotherTransaction.Location = new System.Drawing.Point(0, 217);
            this.BtnAnotherTransaction.Name = "BtnAnotherTransaction";
            this.BtnAnotherTransaction.Size = new System.Drawing.Size(250, 45);
            this.BtnAnotherTransaction.TabIndex = 3;
            this.BtnAnotherTransaction.Text = "Another Transaction";
            this.BtnAnotherTransaction.UseVisualStyleBackColor = true;
            this.BtnAnotherTransaction.Click += new System.EventHandler(this.BtnAnotherTransaction_Click);
            // 
            // BtnCashOut
            // 
            this.BtnCashOut.FlatAppearance.BorderSize = 0;
            this.BtnCashOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnCashOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCashOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCashOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCashOut.Location = new System.Drawing.Point(0, 150);
            this.BtnCashOut.Name = "BtnCashOut";
            this.BtnCashOut.Size = new System.Drawing.Size(250, 45);
            this.BtnCashOut.TabIndex = 2;
            this.BtnCashOut.Text = "Cash Out";
            this.BtnCashOut.UseVisualStyleBackColor = true;
            this.BtnCashOut.Click += new System.EventHandler(this.BtnCashOut_Click);
            // 
            // BtnCashIn
            // 
            this.BtnCashIn.FlatAppearance.BorderSize = 0;
            this.BtnCashIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnCashIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCashIn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCashIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCashIn.Location = new System.Drawing.Point(0, 88);
            this.BtnCashIn.Name = "BtnCashIn";
            this.BtnCashIn.Size = new System.Drawing.Size(250, 45);
            this.BtnCashIn.TabIndex = 1;
            this.BtnCashIn.Text = "Cash In";
            this.BtnCashIn.UseVisualStyleBackColor = true;
            this.BtnCashIn.Click += new System.EventHandler(this.BtnCashIn_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(22, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(210, 50);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Taskbar
            // 
            this.Taskbar.Controls.Add(this.Minimize);
            this.Taskbar.Controls.Add(this.Resize);
            this.Taskbar.Controls.Add(this.Close);
            this.Taskbar.Controls.Add(this.BtnSlide);
            this.Taskbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Taskbar.Location = new System.Drawing.Point(250, 0);
            this.Taskbar.Name = "Taskbar";
            this.Taskbar.Size = new System.Drawing.Size(1050, 50);
            this.Taskbar.TabIndex = 1;
            this.Taskbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Taskbar_MouseDown);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(946, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(15, 15);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 5;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Resize
            // 
            this.Resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Resize.Image = ((System.Drawing.Image)(resources.GetObject("Resize.Image")));
            this.Resize.Location = new System.Drawing.Point(982, 12);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(15, 15);
            this.Resize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Resize.TabIndex = 4;
            this.Resize.TabStop = false;
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(1018, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(15, 15);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 3;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // BtnSlide
            // 
            this.BtnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSlide.Image = ((System.Drawing.Image)(resources.GetObject("BtnSlide.Image")));
            this.BtnSlide.Location = new System.Drawing.Point(6, 9);
            this.BtnSlide.Name = "BtnSlide";
            this.BtnSlide.Size = new System.Drawing.Size(35, 35);
            this.BtnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSlide.TabIndex = 0;
            this.BtnSlide.TabStop = false;
            this.BtnSlide.Click += new System.EventHandler(this.BtnSlide_Click);
            // 
            // panelcontain
            // 
            this.panelcontain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontain.Location = new System.Drawing.Point(250, 50);
            this.panelcontain.Name = "panelcontain";
            this.panelcontain.Size = new System.Drawing.Size(1050, 600);
            this.panelcontain.TabIndex = 2;
            // 
            // Base_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelcontain);
            this.Controls.Add(this.Taskbar);
            this.Controls.Add(this.MenuVertical);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Base_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antccounting";
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Taskbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel Taskbar;
        private System.Windows.Forms.PictureBox BtnSlide;
        private System.Windows.Forms.Panel panelcontain;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox Resize;
        private System.Windows.Forms.Button BtnCashIn;
        private System.Windows.Forms.Button BtnAnotherTransaction;
        private System.Windows.Forms.Button BtnCashOut;
    }
}

