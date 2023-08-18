using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_management_sistem.Kontrole
{
    public partial class Dolazak : UserControl
    {
        Baza_funkcija fn = new Baza_funkcija();
        String query;

        public Dolazak()
        {
            InitializeComponent();
        }


        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    string item = sdr.GetValue(i).ToString();//prebacivanje objekta u string

                    combo.Items.Add(item);
                }
            }
            sdr.Close();
        }

        private void txtTipSobe_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBrojSobe.Items.Clear();
            query = "select BROJ_SOBE from SOBE where TIP_KREVETA='" + txtTipKreveta.Text + "' and TIP_SOBE= '" + txtTipSobe.Text + "' and REZERVIRANO = 'NO' ";
            setComboBox(query, txtBrojSobe);
        }

        private void txtTipKreveta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTipSobe.SelectedIndex = -1;
            txtBrojSobe.Items.Clear();
        }

        int rid;

        private void txtBrojSobe_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select CIJENA,ID_SOBE from SOBE where BROJ_SOBE = '" + txtBrojSobe.Text + "'";
            DataSet ds = fn.getData(query);
            txtCijena.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnDodjeliSobu_Click(object sender, EventArgs e)
        {
            if (txtIme.Text != "" && txtTelefon.Text != "" && txtDrz.Text != "" && txtSpol.Text != "" && txtDob.Text != "" && txtDokument.Text != "" && txtGrad.Text != "" && txtCheckin.Text != "" && txtCijena.Text != "")
            {
                String IME_GOSTA = txtIme.Text;
                Int64 TEL_BROJ = Int64.Parse(txtTelefon.Text);
                string DRZAVLJANSTVO = txtDrz.Text;
                string SPOL = txtSpol.Text;
                string DATUM_RODENJA = txtDob.Text;
                string BROJ_DOKUMENTA = txtDokument.Text;
                string ADRESA = txtGrad.Text;
                string CHECK_IN = txtCheckin.Text;
                System.Diagnostics.Debug.WriteLine(CHECK_IN);

                query = "insert into GOSTI (IME_GOSTA, TEL_BROJ, DRZAVLJANSTVO, SPOL, DATUM_RODENJA, BROJ_DOKUMENTA, ADRESA, CHECK_IN, ID_SOBE) values ('" + IME_GOSTA + "','" + TEL_BROJ + "', '" + DRZAVLJANSTVO + "', '" + SPOL + "', '" + DATUM_RODENJA + "', '" + BROJ_DOKUMENTA + "', '" + ADRESA + "', '" + CHECK_IN + "', '" + rid + "') update SOBE set REZERVIRANO = 'YES' where BROJ_SOBE = '" + txtBrojSobe.Text + "'";
                fn.setData(query, "BROJ_SOBE " + txtBrojSobe.Text + " Uspjesno dodano. ");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Popunite sva polja.", "Paznja!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ClearAll()
        {
            txtIme.Clear();
            txtTelefon.Clear();
            txtDrz.Clear();
            txtSpol.SelectedIndex = -1;
            txtDob.ResetText();
            txtDokument.Clear();
            txtGrad.Clear();
            txtCheckin.ResetText();
            txtTipKreveta.SelectedIndex = -1;
            txtTipSobe.SelectedIndex = -1;
            txtBrojSobe.Items.Clear();
            txtCijena.Clear();
        }

        private void Dolazak_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
