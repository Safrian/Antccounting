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
    public partial class CashIn_form : Form
    {
        
        public CashIn_form()
        {
            InitializeComponent();
        }
        AkuntansiDAO AKD = new AkuntansiDAO();

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void CashIn_form_Load(object sender, EventArgs e)
        {
            SqlConnection Connect = new SqlConnection("Server= ANTAREZA-PC\\SQLEXPRESS; Database= Antccounting;Integrated Security = SSPI;");
            Connect.Open();
            SqlCommand Command = new SqlCommand("select * from Chart_Of_Account", Connect);
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                Cmbkredit.Items.Add(reader["Account_No"]);
                CmbDebit.Items.Add(reader["Account_No"]);

            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtNumber.Text=="")
            {
                //Insert Data
                if(Txtdeskripsi.Text=="")
                {
                    MessageBox.Show("Deskripsi Kosong");
                    Txtdeskripsi.Focus();
                }
                else if (Txtnominal.Text=="")
                {
                    MessageBox.Show("Nominal Kosong");
                    Txtnominal.Focus();
                }
                else if(CmbDebit.Text=="101")
                {
                    //Proses Insert
                    Akuntansi AK = new Akuntansi();
                    AK.No_Transaksi =TxtNumber.Text;
                    AK.Tanggal =DTPTransaksi.Text;
                    AK.Keterangan =Txtdeskripsi.Text;
                    AK.Akun_DT =CmbDebit.Text;
                    AK.Akun_KR =Cmbkredit.Text;
                    AK.Nominal =Convert.ToDouble(Txtnominal.Text);

                    AKD.InsertData(AK);
                }
                else
                {
                    MessageBox.Show("Ini Form Untuk Kas Masuk(Cash In)");
                }
            }
            else
            {
                //Update Data
                Akuntansi AK = new Akuntansi();
                AK.No_Transaksi = TxtNumber.Text;
                AK.Tanggal = DTPTransaksi.Text;
                AK.Keterangan = Txtdeskripsi.Text;
                AK.Akun_DT = CmbDebit.Text;
                AK.Akun_KR = Cmbkredit.Text;
                AK.Nominal = Convert.ToDouble(Txtnominal.Text);

                AKD.UpdateData(AK, TxtNumber.Text);
            }
        }

        private void Cmbkredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection Connect = new SqlConnection("Server= ANTAREZA-PC\\SQLEXPRESS; Database= Antccounting;Integrated Security = SSPI; ");
            Connect.Open();
            SqlCommand Command = new SqlCommand("select * from Chart_Of_Account WHERE Account_No='"+Cmbkredit.Text+"'", Connect);
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                Txtkredit.Text = reader["Account_Name"].ToString();
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
    }
}
