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
    public partial class SifreYenile : Form
    {
        public SifreYenile()
        {
            InitializeComponent();
        }
        public SqlConnection baglanti = new SqlConnection(@"Data Source=GULSUM; Initial Catalog=bilgi; Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommand komut = new SqlCommand();
        SqlDataReader sdr;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private void yenisifre_btn_Click(object sender, EventArgs e)
        {
            if (ksifre_txt.Text == ksifretekrar_txt.Text)
            {
                baglanti.Open();
                komut = new SqlCommand("select * from yonetici where y_kullanici_adi='" + kadi_txt.Text + "' and y_guvenliksorusu='" + guvsoru_txt.Text + "'", baglanti);
                sdr = komut.ExecuteReader();
                if (sdr.Read() == true)
                {
                    baglanti.Close();
                    baglanti.Open();
                    komut = new SqlCommand("Update yonetici Set y_sifre=@sifre Where y_kullanici_adi='" + kadi_txt.Text + "'", baglanti);
                    komut.Parameters.AddWithValue("@sifre", ksifre_txt.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Şifreniz Değiştirildi", "ŞİFRE");

                }
                else
                {
                    MessageBox.Show("Lütfen Kullanıcı Bilgilerinizi Doğru Giriniz!", "HATA");
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor","ŞİFRE HATASI");
            }

        }

        private void ytemizle_btn_Click(object sender, EventArgs e)
        {
            kadi_txt.Clear();
            guvsoru_txt.Clear();
            advesoyad_txt.Clear();
            ksifre_txt.Clear();
            ksifretekrar_txt.Clear();
        }

        private void c_yenisifre_btn_Click(object sender, EventArgs e)
        {
            if (c_ksifre_txt.Text == c_ksifretekrar_txt.Text)
            {
                baglanti.Open();
                komut = new SqlCommand("select * from calisan where c_kullanici_adi='" + c_kadi_txt.Text + "' and c_guvenliksorusu='" + c_guvsoru_txt.Text + "'", baglanti);
                sdr = komut.ExecuteReader();
                if (sdr.Read() == true)
                {

                    baglanti.Close();
                    baglanti.Open();
                    komut = new SqlCommand("Update calisan Set c_sifre=@csifre Where c_kullanici_adi='" + c_kadi_txt.Text + "'", baglanti);
                    komut.Parameters.AddWithValue("@csifre", c_ksifre_txt.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Şifreniz Değiştirildi", "ŞİFRE");
                }
                else
                {
                    MessageBox.Show("Lütfen Kullanıcı Bilgilerinizi Doğru Giriniz!", "HATA");
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor", "ŞİFRE HATASI");
            }
        }

        private void ctemizle_btn_Click(object sender, EventArgs e)
        {
            c_kadi_txt.Clear();
            c_guvsoru_txt.Clear();
            c_advesoyad_txt.Clear();
            c_ksifre_txt.Clear();
            c_ksifretekrar_txt.Clear();
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
    }
}
