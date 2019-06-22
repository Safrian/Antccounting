using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Antccounting
{
    class AkuntansiDAO
    {
        // ID = sa;
        //Password=qwerty123!
        //Persist Security Info = True;

        private SqlCommand Command = null;
        string Configuration = "Server= ANTAREZA-PC\\SQLEXPRESS; Database= Antccounting;Integrated Security = SSPI;";
        SqlConnection Connection = new SqlConnection();
        public AkuntansiDAO()
        {
            Connection.ConnectionString = Configuration ;
        }
        
            
        public bool InsertData(Akuntansi AK)
        {
            Boolean stat = false;
            try
            {
                Connection.Open();
                Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandType = System.Data.CommandType.Text;
                Command.CommandText = "INSERT INTO Table_Transaksi VALUE('" + AK.No_Transaksi + "','" + AK.Tanggal + "','" + AK.Keterangan + "','" + AK.Akun_DT + "','" + AK.Akun_KR +"','"+AK.Nominal+ "')";
                Command.ExecuteNonQuery();
                stat = true;
                Connection.Close();
            }
            catch (SqlException)
            { }
            return stat;
        }

        public bool UpdateData(Akuntansi AK , string No_Transaksi)
        {
            Boolean stat = false;
            try
            {
                Connection.Open();
                Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandType = System.Data.CommandType.Text;
                Command.CommandText = "UPDATE Table_Transaksi SET No_Transaksi='" + AK.No_Transaksi+"',Tanggal='"+AK.Tanggal+"',Keterangan='"+AK.Keterangan+"',Akun_DT='"+AK.Akun_DT+"',Akun_KR='"+AK.Akun_KR+"',Nominal='"+AK.Nominal+ "'WHERE No_Transaksi='"+No_Transaksi+"'";
                Command.ExecuteNonQuery();
                stat = true;
                Connection.Close();
            }
            catch(SqlException)
            { }
            return stat;
        }
        public bool DeleteData(string No_Transaksi)
        {
            Boolean stat = false;
            try
            {
                Connection.Open();
                Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandType = System.Data.CommandType.Text;
                Command.CommandText = "DELETE FROM Table_Transaksi WHERE No_Transaksi='" + No_Transaksi + "'";
                Command.ExecuteNonQuery();
                stat = true;
                Connection.Close();
            }
            catch (SqlException)
            { }
            return stat;
        }


      /*  public void ListData()
        {
            SqlDataReader Reader = null;

            
            try
            {
                Connection.Open();
                Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandType = System.Data.CommandType.Text;
                Command.CommandText = "SELECT * FROM [Antccounting].[dbo].[Table_Transaksi]";
                SqlDataAdapter MDAP = new SqlDataAdapter(Command);
                MDAP.Fill(, "[Antccounting].[dbo].[Table_Transaksi]");
            }
        }*/
    }
}
