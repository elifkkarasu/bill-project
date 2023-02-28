using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fatura_Bilgilerine_Bağlı_Telefon_Satma_Sistemi
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        public SqlConnection baglanti = new SqlConnection(@"Data Source=GULSUM; Initial Catalog=bilgi; Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private void yekle_btn_Click(object sender, EventArgs e)
        {
            if (ksifre_txt.Text == ksifretekrar_txt.Text)
            {
                baglanti.Open();
                string sorgu = "insert into yonetici(y_adisoyadi,y_kullanici_adi,y_sifre,y_mevki,y_guvenliksorusu) values('" + advesoyad_txt.Text + "','" + kadi_txt.Text + "','" + ksifre_txt.Text + "','" + mevki_txt.Text + "','" + guvsoru_txt.Text + "')";
                komut = new SqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yönetici Eklendi", "YÖNETİCİ");
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor", "Hatalı Şifre ");
            }
        }

        private void cekle_tbn_Click(object sender, EventArgs e)
        {
            if (c_ksifre_txt.Text == c_ksifretekrar_txt.Text)
            {
                baglanti.Open();
                string sorgu = "insert into calisan(c_adisoyadi,c_kullanici_adi,c_sifre,c_mevki,c_guvenliksorusu) values('" + c_advesoyad_txt.Text + "','" + c_kadi_txt.Text + "','" + c_ksifre_txt.Text + "','" + c_mevki_txt.Text + "','" + c_guvsoru_txt.Text + "')";
                komut = new SqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Çalışan Eklendi", "ÇALIŞAN");
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor", "Hatalı Şifre ");
            }
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

        private void ytemizle_btn_Click(object sender, EventArgs e)
        {
            advesoyad_txt.Clear();
            kadi_txt.Clear();
            ksifre_txt.Clear();
            ksifretekrar_txt.Clear();
            mevki_txt.Clear();
            guvsoru_txt.Clear();
            
            
        }

        private void ctemizle_btn_Click(object sender, EventArgs e)
        {
            c_advesoyad_txt.Clear();
            c_kadi_txt.Clear();
            c_ksifre_txt.Clear();
            c_ksifretekrar_txt.Clear();
            c_mevki_txt.Clear();
            c_guvsoru_txt.Clear();
        }
    }
}
