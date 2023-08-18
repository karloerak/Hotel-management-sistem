using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_management_sistem
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            dodavanje_sobe1.Visible = false;
            dolazak1.Visible = false;
            btnSobe.PerformClick();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            dodavanje_sobe1.Visible = true;
            dodavanje_sobe1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            dolazak1.Visible = true;
            dolazak1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            checkout1.Visible = true;
            checkout1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            gosti1.Visible = true;
            gosti1.BringToFront();
        }
    }
}
