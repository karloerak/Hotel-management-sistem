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
    public partial class Gosti : UserControl
    {
        Baza_funkcija fn = new Baza_funkcija();
        String query;
        public Gosti()
        {
            InitializeComponent();
        }

        private void txtPretraga_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPretraga.SelectedIndex == 0)
            {
                query = "select GOSTI.ID_GOSTA, GOSTI.IME_GOSTA, GOSTI.TEL_BROJ, GOSTI.DRZAVLJANSTVO, GOSTI.SPOL, GOSTI.DATUM_RODENJA, GOSTI.BROJ_DOKUMENTA, GOSTI.ADRESA, GOSTI.CHECK_IN, SOBE.BROJ_SOBE, SOBE.TIP_SOBE, SOBE.TIP_KREVETA, SOBE.CIJENA from GOSTI inner join SOBE on GOSTI.ID_SOBE = SOBE.ID_SOBE";
                getRecord(query);
            }
            else if (txtPretraga.SelectedIndex == 1)
            {
                query = "select GOSTI.ID_GOSTA, GOSTI.IME_GOSTA, GOSTI.TEL_BROJ, GOSTI.DRZAVLJANSTVO, GOSTI.SPOL, GOSTI.DATUM_RODENJA, GOSTI.BROJ_DOKUMENTA, GOSTI.ADRESA, GOSTI.CHECK_IN, SOBE.BROJ_SOBE, SOBE.TIP_SOBE, SOBE.TIP_KREVETA, SOBE.CIJENA from GOSTI inner join SOBE on GOSTI.ID_SOBE = SOBE.ID_SOBE where CHECK_OUT is null";
                getRecord(query);
            }
            else if (txtPretraga.SelectedIndex == 2)
            {
                query = "select GOSTI.ID_GOSTA, GOSTI.IME_GOSTA, GOSTI.TEL_BROJ, GOSTI.DRZAVLJANSTVO, GOSTI.SPOL, GOSTI.DATUM_RODENJA, GOSTI.BROJ_DOKUMENTA, GOSTI.ADRESA, GOSTI.CHECK_IN, SOBE.BROJ_SOBE, SOBE.TIP_SOBE, SOBE.TIP_KREVETA, SOBE.CIJENA from GOSTI inner join SOBE on GOSTI.ID_SOBE = SOBE.ID_SOBE where CHECK_OUT is not null";
                getRecord(query);
            }
        }

            private void getRecord(String query)
            {
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }

        }
    }
