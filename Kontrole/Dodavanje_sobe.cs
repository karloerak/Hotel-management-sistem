using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_management_sistem.Kontrole
{
    public partial class Dodavanje_sobe : UserControl
    {

        Baza_funkcija fn = new Baza_funkcija();
        String query;
        public Dodavanje_sobe()
        {
            InitializeComponent();
        }

        private void Dodavanje_sobe_Load(object sender, EventArgs e)
        {
            query = "select * from SOBE";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnDodajSobu_Click(object sender, EventArgs e)
        {
            if(txtBrojSobe.Text!="" && txtTipSobe.Text!="" && txtTipKreveta.Text!="" && txtCijena.Text!="")
            {
                String BROJ_SOBE = txtBrojSobe.Text;
                String TIP_SOBE = txtTipSobe.Text;
                String TIP_KREVETA = txtTipKreveta.Text;
                Int64 CIJENA = Int64.Parse(txtCijena.Text);

                query = "insert into SOBE(BROJ_SOBE, TIP_SOBE, TIP_KREVETA, CIJENA) VALUES('" +BROJ_SOBE+ "','" +TIP_SOBE+ "','" +TIP_KREVETA+ "','" +CIJENA+ "')";
                fn.setData(query, "Soba dodana.");

                Dodavanje_sobe_Load(this, null);
                OcistiSve();
            }
            else
            {
                MessageBox.Show("Ispunite sva polja.", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void OcistiSve()
        {
            txtBrojSobe.Clear();
            txtTipSobe.SelectedIndex = -1;
            txtTipKreveta.SelectedIndex = -1;
            txtCijena.Clear();
        }

        private void Dodavanje_sobe_Leave(object sender, EventArgs e)
        {
            OcistiSve();
        }

        private void Dodavanje_sobe_Enter(object sender, EventArgs e)
        {
            Dodavanje_sobe_Load(this, null);
        }
    }
}
 