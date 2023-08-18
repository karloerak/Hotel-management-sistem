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
    public partial class Checkout : UserControl
    {
        Baza_funkcija fn = new Baza_funkcija();
        String query;

        public Checkout()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            query = "select GOSTI.ID_GOSTA, GOSTI.IME_GOSTA, GOSTI.TEL_BROJ, GOSTI.DRZAVLJANSTVO, GOSTI.SPOL, GOSTI.DATUM_RODENJA, GOSTI.BROJ_DOKUMENTA, GOSTI.ADRESA, GOSTI.CHECK_IN, SOBE.BROJ_SOBE, SOBE.TIP_SOBE, SOBE.TIP_KREVETA, SOBE.CIJENA from GOSTI inner join SOBE on GOSTI.ID_SOBE = SOBE.ID_SOBE where CHECKED_OUT = 'NO'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            query = "select GOSTI.ID_GOSTA, GOSTI.IME_GOSTA, GOSTI.TEL_BROJ, GOSTI.DRZAVLJANSTVO, GOSTI.SPOL, GOSTI.DATUM_RODENJA, GOSTI.BROJ_DOKUMENTA, GOSTI.ADRESA, GOSTI.CHECK_IN, SOBE.BROJ_SOBE, SOBE.TIP_SOBE, SOBE.TIP_KREVETA, SOBE.CIJENA from GOSTI inner join SOBE on GOSTI.ID_SOBE = SOBE.ID_SOBE where IME_GOSTA like '" + txtIme.Text + "%' and CHECKED_OUT = 'NO'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtImeGosta.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtBrojSobe.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();


            }
        }

        private void btnCO_Click(object sender, EventArgs e)
        {
            if(txtBrojSobe.Text != "")
            {
                if(MessageBox.Show("Jeste li sigurni?", "Potvrda", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txtCODatum.Text;
                    query = "select GOSTI.CHECK_IN, SOBE.CIJENA from GOSTI inner join SOBE on GOSTI.ID_SOBE = SOBE.ID_SOBE where IME_GOSTA like '" + txtIme.Text + "%' and CHECKED_OUT = 'NO'";
                    DataSet ds = fn.getData(query);

                    DataTable table = ds.Tables[0]; // Assuming the table you're interested in is the first table in the DataSet

                    List<DateTime> checkinList = new List<DateTime>(); // List to store checkin values
                    List<decimal> cijenaList = new List<decimal>();   // List to store cijena values

                    string checkin = null;
                    int cijena = 0;
                    int dayDifference = 0;

                    foreach (DataRow row in table.Rows)
                    {
                        // Assuming the columns are named "CHECK_IN" and "CIJENA"
                        checkin = (string)row["CHECK_IN"];
                        cijena = (int)row["CIJENA"];

                        DateTime date1 = DateTime.ParseExact(checkin, "dd/MM/yyyy", null);
                        DateTime date2 = DateTime.ParseExact(cdate, "dd/MM/yyyy", null);

                        TimeSpan difference = date2 - date1;
                        dayDifference = difference.Days;

                        System.Diagnostics.Debug.WriteLine(dayDifference * cijena);

                    }

            

                    query = "update GOSTI set CHECKED_OUT = 'YES' ,CHECK_OUT = '"+cdate+"' where ID_GOSTA = "+id+" update SOBE set REZERVIRANO = 'NO' where BROJ_SOBE ='"+txtBrojSobe.Text+"' ";
                    fn.setData(query, "Gost treba platiti iznos:" +dayDifference*cijena+ "EUR, za "+dayDifference+"noćenja po cijeni od "+cijena+" EUR po noćenju.");
                    Checkout_Load(this, null);
                    ClearAll();
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali gosta.", "Paznja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ClearAll()
        {
            txtIme.Clear();
            txtImeGosta.Clear();
            txtBrojSobe.Clear();
            txtCODatum.ResetText();
        }

        private void Checkout_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
