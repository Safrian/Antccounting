using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Antccounting
{
    public partial class Base_Form : Form
    {
        public Base_Form()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 0;
            }
            else
                MenuVertical.Width = 250;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Resize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Taskbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Openforminpanel(object Formchild)
        {
            if (this.panelcontain.Controls.Count > 0)
                this.panelcontain.Controls.RemoveAt(0);
            Form Fc = Formchild as Form;
            Fc.TopLevel = false;
            Fc.Dock = DockStyle.Fill;
            this.panelcontain.Controls.Add(Fc);
            this.panelcontain.Tag = Fc;
            Fc.Show();
        }

        private void BtnCashIn_Click(object sender, EventArgs e)
        {
            Openforminpanel(new CashIn_form());
        }

        private void BtnCashOut_Click(object sender, EventArgs e)
        {
            Openforminpanel(new CashOut_form());
        }

        private void BtnAnotherTransaction_Click(object sender, EventArgs e)
        {
            Openforminpanel(new AnotherTransaction_form());
        }
    }
}
