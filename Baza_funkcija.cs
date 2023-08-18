using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_management_sistem
{
    class Baza_funkcija
    {
        protected SqlConnection spajanje_baze()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (LocalDB)\\MSSQLLocalDB;database=HOTEL_BAZA;integrated security = True";
            return con;
        }

        public DataSet getData(String query) //Dohvacanje podataka iz baze
        {
            SqlConnection con = spajanje_baze();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        internal SqlDataReader GetForCombo(string query)
        {
            throw new NotImplementedException();
        }

        public void setData(String query,String message)// Dodavanje i brisanje u bazi
        {
            SqlConnection con = spajanje_baze();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(" '" + message + "' ", "Uspješno!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public SqlDataReader getForCombo(String query)
        {
            SqlConnection con = spajanje_baze();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}
