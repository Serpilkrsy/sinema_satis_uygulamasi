using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_büfe_satıs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        int kasaTutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir , bilet, su, cay, toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            bilet = Convert.ToInt16(txtbilet.Text);
            su = Convert.ToInt16(txtsu.Text);
            cay = Convert.ToInt16(txtcay.Text);
           
            Lblkasa.Text = kasaTutar.ToString();
            toplam = misir*4  +cay *2 + su *1 + bilet*8;
            Lbltoplam.Text = toplam.ToString() + "TL";
            kasaTutar = kasaTutar + toplam;
            Lblkasa.Text = kasaTutar.ToString();
        }

        private void TxtMisir_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbilet.Text = "";
            TxtMisir.Text = "";
            txtcay.Text = "";
            txtsu.Text = "";
            TxtMisir.Focus();

        }
    }
}
