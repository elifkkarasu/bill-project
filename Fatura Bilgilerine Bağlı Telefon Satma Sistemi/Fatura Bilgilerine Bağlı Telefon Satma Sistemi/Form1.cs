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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection sc = new SqlConnection();

        private void yonetici_btn_Click(object sender, EventArgs e)
        {
            String bc = @"Data Source=GULSUM; Initial Catalog=bilgi; Integrated Security=True";
            try
            {
                if (sc.State == ConnectionState.Open)
                    sc.Close();
                sc.ConnectionString = bc;
                sc.Open();

                String sorgu = "select y_kullanici_adi, y_sifre from yonetici where y_kullanici_adi='" + kullaniciadi_txt.Text + "' and y_sifre='" + sifre_txt.Text + "'";
                SqlCommand scom = new SqlCommand(sorgu, sc);
                SqlDataReader sdr = scom.ExecuteReader();
                if (!sdr.HasRows)
                {
                    MessageBox.Show("Lütfen Kullanıcı Adını ve Şifrenizi Kontrol Ediniz!",
                    "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Yonetici y = new Yonetici();
                this.Visible = false;
                y.Show();
                sc.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Sağlanamadı");
            }
        }

        private void calisan_btn_Click(object sender, EventArgs e)
        {
            String bc = @"Data Source=GULSUM; Initial Catalog=bilgi; Integrated Security=True";
            try
            {
                if (sc.State == ConnectionState.Open)
                    sc.Close();
                sc.ConnectionString = bc;
                sc.Open();

                String sorgu = "select c_kullanici_adi, c_sifre from calisan where c_kullanici_adi='" + kullaniciadi_txt.Text + "' and c_sifre='" + sifre_txt.Text + "'";
                SqlCommand scom = new SqlCommand(sorgu, sc);
                SqlDataReader sdr = scom.ExecuteReader();
                if (!sdr.HasRows)
                {
                    MessageBox.Show("Lütfen Kullanıcı Adını ve Şifrenizi Kontrol Ediniz!",
                    "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Calisan c = new Calisan();
                this.Visible = false;
                c.Show();
                sc.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Sağlanamadı");
            }
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            String bc = @"Data Source=GULSUM; Initial Catalog=bilgi; Integrated Security=True";
            try
            {
                if (sc.State == ConnectionState.Open)
                    sc.Close();
                sc.ConnectionString = bc;
                sc.Open();

                String sorgu = "select y_kullanici_adi, y_sifre from yonetici where y_kullanici_adi='" + kullaniciadi_txt.Text + "' and y_sifre='" + sifre_txt.Text + "'";
                SqlCommand scom = new SqlCommand(sorgu, sc);
                SqlDataReader sdr = scom.ExecuteReader();
                if (!sdr.HasRows)
                {
                    MessageBox.Show("Lütfen Kullanıcı Adını ve Şifrenizi Kontrol Ediniz!",
                    "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Admin a = new Admin();
                this.Visible = false;
                a.Show();
                sc.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Sağlanamadı");
            }
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreYenile s = new SifreYenile();
            this.Visible = false;
            s.Show();
        }
    }
}
