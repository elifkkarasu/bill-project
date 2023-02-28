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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }
        public SqlConnection baglanti = new SqlConnection(@"Data Source=GULSUM; Initial Catalog=bilgi; Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommand komut = new SqlCommand();
        SqlCommandBuilder scomb;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        private void listele()
        {
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from musteri", baglanti);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void Musteri_Load(object sender, EventArgs e)
        {
            cinsiyet.SelectedItem = cinsiyet.Items[0];
            listele();
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            String sorgu = "insert into musteri(musteri_TC,musteri_ADI,musteri_SOYADI,musteri_CINSIYET,musteri_ANNE_adi,musteri_BABA_adi,musteri_DOGUM_yeri,musteri_DOGUM_tarihi,musteri_TEL,musteri_MAIL,musteri_ADRES,musterinin_satinaldigi_TELEFON) values('" + tc_txt.Text + "','" + adi_txt.Text + "','" + soyadi_txt.Text + "','" + cinsiyet.Text + "','" + anneadi_txt.Text + "','" + babaadi_txt.Text + "','" + dogumyeri_txt.Text + "','" + dogumtarihi_dtp.Text + "','" + tel_txt.Text + "','" + mail_txt.Text + "','" + adres_txt.Text + "','" + satinaldigitelefon_txt.Text + "')";
            komut = new SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Eklendi", "MÜŞTERİ");
            dt.Clear();
            listele();
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM musteri WHERE musteri_TC=@tc";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("tc", tc_txt.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Silindi", "MÜŞTERİ");
            dt.Clear();
            listele();

        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {

            string sorgu = "UPDATE musteri SET musteri_TC=@tc, musteri_ADI=@adi, musteri_SOYADI=@soyadi,musteri_CINSIYET=@cinsiyet,musteri_ANNE_adi=@anneadi,musteri_BABA_adi=@babaadi,musteri_DOGUM_yeri=@dogumyeri,musteri_DOGUM_tarihi=@dogumtarihi,musteri_TEL=@tel,musteri_MAIL=@mail, musteri_ADRES=@adres,musterinin_satinaldigi_TELEFON=@satinaldigitel WHERE musteri_TC=@tc";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc", tc_txt.Text);
            komut.Parameters.AddWithValue("@adi", adi_txt.Text);
            komut.Parameters.AddWithValue("@soyadi", soyadi_txt.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyet.Text);
            komut.Parameters.AddWithValue("@anneadi", anneadi_txt.Text);
            komut.Parameters.AddWithValue("@babaadi", babaadi_txt.Text);
            komut.Parameters.AddWithValue("@dogumyeri", dogumyeri_txt.Text);
            komut.Parameters.AddWithValue("@dogumtarihi", dogumtarihi_dtp.Text);
            komut.Parameters.AddWithValue("@tel", tel_txt.Text);
            komut.Parameters.AddWithValue("@mail", mail_txt.Text);
            komut.Parameters.AddWithValue("@adres", adres_txt.Text);
            komut.Parameters.AddWithValue("@satinaldigitel", satinaldigitelefon_txt.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Güncellendi", "MÜŞTERİ");
            dt.Clear();
            listele();

        }

        private void adtel_txt_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from musteri where musteri_ADI like '" + adtel_txt.Text + "%' or musteri_TEL like '" + adtel_txt.Text + "%'", baglanti);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            dataGridView1.DataSource = dt2;
            baglanti.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tc_txt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            adi_txt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            soyadi_txt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cinsiyet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            anneadi_txt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            babaadi_txt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dogumyeri_txt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dogumtarihi_dtp.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tel_txt.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            mail_txt.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            adres_txt.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            satinaldigitelefon_txt.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
        }

        private void temizle_btn_Click(object sender, EventArgs e)
        {
            tc_txt.Clear();
            adi_txt.Clear();
            soyadi_txt.Clear();
            anneadi_txt.Clear();
            babaadi_txt.Clear();
            dogumyeri_txt.Clear();
            dogumtarihi_dtp.Text = "";
            tel_txt.Clear();
            mail_txt.Clear();
            adres_txt.Clear();
            satinaldigitelefon_txt.Clear();
        }

        private void geridon_linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Yonetici y = new Yonetici();
            this.Visible = false;
            y.Show();
        }

        private void anasayfayadon_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f = new Form1();
            f.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
