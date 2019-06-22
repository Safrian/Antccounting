namespace Antccounting
{
    partial class CashOut_form
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
            this.TitleCashOut = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DTPTransaksi = new System.Windows.Forms.DateTimePicker();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.CmbDebit = new System.Windows.Forms.ComboBox();
            this.Txtdebit = new System.Windows.Forms.TextBox();
            this.Cmbkredit = new System.Windows.Forms.ComboBox();
            this.Txtkredit = new System.Windows.Forms.TextBox();
            this.Txtdeskripsi = new System.Windows.Forms.TextBox();
            this.Txtnominal = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // TitleCashOut
            // 
            this.TitleCashOut.AutoSize = true;
            this.TitleCashOut.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleCashOut.Location = new System.Drawing.Point(249, 25);
            this.TitleCashOut.Name = "TitleCashOut";
            this.TitleCashOut.Size = new System.Drawing.Size(101, 23);
            this.TitleCashOut.TabIndex = 0;
            this.TitleCashOut.Text = "Cash Out";
            this.TitleCashOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(126)))), ((int)(((byte)(79)))));
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSave.Location = new System.Drawing.Point(54, 340);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 40);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(126)))), ((int)(((byte)(79)))));
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCancel.Location = new System.Drawing.Point(225, 340);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(150, 40);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(126)))), ((int)(((byte)(79)))));
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClose.Location = new System.Drawing.Point(396, 340);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 40);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number Transaction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Account Debit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Account Credit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Description Transaction";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nominal Transaction";
            // 
            // DTPTransaksi
            // 
            this.DTPTransaksi.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPTransaksi.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DTPTransaksi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPTransaksi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTPTransaksi.Location = new System.Drawing.Point(278, 83);
            this.DTPTransaksi.Name = "DTPTransaksi";
            this.DTPTransaksi.Size = new System.Drawing.Size(150, 23);
            this.DTPTransaksi.TabIndex = 12;
            // 
            // TxtNumber
            // 
            this.TxtNumber.BackColor = System.Drawing.SystemColors.Control;
            this.TxtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNumber.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtNumber.Location = new System.Drawing.Point(278, 118);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(189, 14);
            this.TxtNumber.TabIndex = 13;
            this.TxtNumber.Text = "Number";
            this.TxtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CmbDebit
            // 
            this.CmbDebit.BackColor = System.Drawing.SystemColors.Window;
            this.CmbDebit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbDebit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDebit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CmbDebit.FormattingEnabled = true;
            this.CmbDebit.Location = new System.Drawing.Point(278, 146);
            this.CmbDebit.Name = "CmbDebit";
            this.CmbDebit.Size = new System.Drawing.Size(52, 24);
            this.CmbDebit.TabIndex = 14;
            this.CmbDebit.SelectedIndexChanged += new System.EventHandler(this.CmbDebit_SelectedIndexChanged);
            // 
            // Txtdebit
            // 
            this.Txtdebit.BackColor = System.Drawing.SystemColors.Control;
            this.Txtdebit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtdebit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtdebit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txtdebit.Location = new System.Drawing.Point(337, 149);
            this.Txtdebit.Name = "Txtdebit";
            this.Txtdebit.Size = new System.Drawing.Size(131, 14);
            this.Txtdebit.TabIndex = 15;
            this.Txtdebit.Text = "Debit";
            this.Txtdebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cmbkredit
            // 
            this.Cmbkredit.BackColor = System.Drawing.SystemColors.Window;
            this.Cmbkredit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmbkredit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmbkredit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Cmbkredit.FormattingEnabled = true;
            this.Cmbkredit.Location = new System.Drawing.Point(278, 178);
            this.Cmbkredit.Name = "Cmbkredit";
            this.Cmbkredit.Size = new System.Drawing.Size(52, 24);
            this.Cmbkredit.TabIndex = 16;
            this.Cmbkredit.SelectedIndexChanged += new System.EventHandler(this.Cmbkredit_SelectedIndexChanged);
            // 
            // Txtkredit
            // 
            this.Txtkredit.BackColor = System.Drawing.SystemColors.Control;
            this.Txtkredit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtkredit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtkredit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txtkredit.Location = new System.Drawing.Point(336, 181);
            this.Txtkredit.Name = "Txtkredit";
            this.Txtkredit.Size = new System.Drawing.Size(131, 14);
            this.Txtkredit.TabIndex = 17;
            this.Txtkredit.Text = "Credit";
            this.Txtkredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txtdeskripsi
            // 
            this.Txtdeskripsi.AccessibleDescription = "";
            this.Txtdeskripsi.AccessibleName = "";
            this.Txtdeskripsi.BackColor = System.Drawing.SystemColors.Control;
            this.Txtdeskripsi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtdeskripsi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtdeskripsi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txtdeskripsi.Location = new System.Drawing.Point(135, 234);
            this.Txtdeskripsi.Name = "Txtdeskripsi";
            this.Txtdeskripsi.Size = new System.Drawing.Size(157, 14);
            this.Txtdeskripsi.TabIndex = 18;
            this.Txtdeskripsi.Text = "Description";
            this.Txtdeskripsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txtnominal
            // 
            this.Txtnominal.BackColor = System.Drawing.SystemColors.Control;
            this.Txtnominal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtnominal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtnominal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txtnominal.Location = new System.Drawing.Point(329, 234);
            this.Txtnominal.Name = "Txtnominal";
            this.Txtnominal.Size = new System.Drawing.Size(138, 14);
            this.Txtnominal.TabIndex = 19;
            this.Txtnominal.Text = "Nominal";
            this.Txtnominal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(600, 400);
            this.shapeContainer1.TabIndex = 20;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 329;
            this.lineShape5.X2 = 467;
            this.lineShape5.Y1 = 250;
            this.lineShape5.Y2 = 250;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 337;
            this.lineShape4.X2 = 467;
            this.lineShape4.Y1 = 197;
            this.lineShape4.Y2 = 197;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 337;
            this.lineShape3.X2 = 467;
            this.lineShape3.Y1 = 165;
            this.lineShape3.Y2 = 165;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 278;
            this.lineShape2.X2 = 467;
            this.lineShape2.Y1 = 134;
            this.lineShape2.Y2 = 134;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 135;
            this.lineShape1.X2 = 292;
            this.lineShape1.Y1 = 251;
            this.lineShape1.Y2 = 251;
            // 
            // CashOut_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.Txtnominal);
            this.Controls.Add(this.Txtdeskripsi);
            this.Controls.Add(this.Txtkredit);
            this.Controls.Add(this.Cmbkredit);
            this.Controls.Add(this.Txtdebit);
            this.Controls.Add(this.CmbDebit);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.DTPTransaksi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TitleCashOut);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashOut_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CashOut_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleCashOut;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTPTransaksi;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.ComboBox CmbDebit;
        private System.Windows.Forms.TextBox Txtdebit;
        private System.Windows.Forms.ComboBox Cmbkredit;
        private System.Windows.Forms.TextBox Txtkredit;
        private System.Windows.Forms.TextBox Txtdeskripsi;
        private System.Windows.Forms.TextBox Txtnominal;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
    }
}