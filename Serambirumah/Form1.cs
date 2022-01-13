using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJO_FORCE_CLOSE_SU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bayar_Click(object sender, EventArgs e)
        {
            double bptxtMeja, bptxtKursi, bptxtLemari, bptxtBuffet, bptxtRanjang, bptxtUP, bptax, bptxtTP, bptxtTH, bptxtKembalian;
            double hargaMj, hargaKs, hargaLm, hargaBf, hargaRj;

            bptxtMeja = double.Parse(txtMeja.Text);
            bptxtKursi = double.Parse(txtKursi.Text);
            bptxtLemari = double.Parse(txtLemari.Text);
            bptxtBuffet = double.Parse(txtBuffet.Text);
            bptxtRanjang = double.Parse(txtRanjang.Text);
            bptxtUP = double.Parse(txtUP.Text);

            hargaMj = bptxtMeja * 9000000;
            hargaKs = bptxtKursi * 4000000;
            hargaLm = bptxtLemari * 5000000;
            hargaBf = bptxtBuffet * 4000000;
            hargaRj = bptxtRanjang * 5000000;

            bptxtTH = hargaMj + hargaKs + hargaLm + hargaBf + hargaRj;
            bptax = bptxtTH * 0.1;

            bptxtTP = bptxtTH + bptax;
            bptxtKembalian = bptxtUP - bptxtTP;

            txtTH.Text = "Rp." + bptxtTH.ToString("N");
            tax.Text = "Rp." + bptax.ToString("N");
            txtTP.Text = "Rp." + bptxtTP.ToString("N");
            txtKembalian.Text = "Rp." + bptxtKembalian.ToString("N");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtKembalian_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
