using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatura_Bilgilerine_Bağlı_Telefon_Satma_Sistemi
{
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }
        private void musteribilgi_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Musteri m = new Musteri();
            m.Show();
        }

        private void faturabilgi_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Fatura f = new Fatura();
            f.Show();
        }

        private void puanbilgi_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Puan p = new Puan();
            p.Show();
        }

        private void anasayfayadon_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f = new Form1();
            f.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form1 f = new Form1();
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateSaat = DateTime.Now;
            lblSaat.Text = dateSaat.ToLongTimeString();
            lblTarih.Text = dateSaat.ToLongDateString();
        }

       
    }
}
