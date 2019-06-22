using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Antccounting
{
    public partial class CashOut_form : Form
    {
        public CashOut_form()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void CashOut_form_Load(object sender, EventArgs e)
        {
            SqlConnection Connect = new SqlConnection("Server= ANTAREZA-PC\\SQLEXPRESS; Database= Antccounting;Integrated Security = SSPI; ");
            Connect.Open();
            SqlCommand Command = new SqlCommand("select * from Chart_Of_Account", Connect);
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                CmbDebit.Items.Add(reader["Account_No"]);
                Cmbkredit.Items.Add(reader["Account_No"]);

            }
        }

        private void CmbDebit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection Connect = new SqlConnection("Server= ANTAREZA-PC\\SQLEXPRESS; Database= Antccounting;Integrated Security = SSPI; ");
            Connect.Open();
            SqlCommand Command = new SqlCommand("select * from Chart_Of_Account WHERE Account_No='" + CmbDebit.Text + "'", Connect);
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                Txtdebit.Text = reader["Account_Name"].ToString();
            }
        }

        private void Cmbkredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection Connect = new SqlConnection("Server= ANTAREZA-PC\\SQLEXPRESS; Database= Antccounting;Integrated Security = SSPI; ");
            Connect.Open();
            SqlCommand Command = new SqlCommand("select * from Chart_Of_Account WHERE Account_No='" + Cmbkredit.Text + "'", Connect);
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                Txtkredit.Text = reader["Account_Name"].ToString();
            }
        }
    }
}
