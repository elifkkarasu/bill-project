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
    public partial class Fatura : Form
    {
        public Fatura()
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
            SqlDataAdapter sda = new SqlDataAdapter("select * from fatura", baglanti);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void Fatura_Load(object sender, EventArgs e)
        {
            fodemedurum.SelectedItem = fodemedurum.Items[0];
            listele();
        }

        private void adtel_txt_TextChanged(object sender, EventArgs e)
        {                                               
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from fatura where fatura.musteri_ID in (select musteri_ID from musteri where musteri_ADI like '" + adtel_txt.Text + "%' or musteri_TEL like '" + adtel_txt.Text + "%')", baglanti);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            dataGridView1.DataSource = dt2;
            baglanti.Close();
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            String sorgu = "insert into fatura(musteri_ID,fatura_ADI,fatura_baslangic_tarihi,fatura_bitis_tarihi,fatura_odeme_tarihi,fatura_son_odeme_tarihi,fatura_UCRET,fatura_ODEME,tamamlanan_taahhut_suresi,taahhut_bitis_tarihi,fatura_TOPLAM_odenen_ay_sayisi,fatura_TOPLAM_gec_odenen_ay_sayisi,fatura_TOPLAM_zamanında_odenen_ay_sayisi) values('" + mid_txt.Text + "','" + fadi_txt.Text + "','" + fbaslangictarih_dtp.Text + "','" + fbitistarih_dtp.Text + "','" + fodemetarih_dtp.Text + "','" + fsonodemetarih_dtp.Text + "','" + fucret_txt.Text + "','" + fodemedurum.Text + "','" + ttahhutsure_txt.Text + "','" + taahhutbitistarih_dtp.Text + "','" + todenenfsayisi_txt.Text + "','" + tgecodenenfsayisi_txt.Text + "','" + tzamanindaodenenfsayisi_txt.Text + "')";
            komut = new SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Fatura Eklendi", "FATURA");
            dt.Clear();
            listele();
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM fatura WHERE fatura_ADI=@fadi";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("fadi", fadi_txt.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Fatura Silindi", "FATURA");
            dt.Clear();
            listele();
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE fatura SET musteri_ID=@mid, fatura_ADI=@fadi, fatura_baslangic_tarihi=@fbaslangictarih, fatura_bitis_tarihi=@fbitistarihi,fatura_odeme_tarihi=@fodemetarih,fatura_son_odeme_tarihi=@fsonodemetarih,fatura_UCRET=@fucret,fatura_ODEME=@fodemedurum,tamamlanan_taahhut_suresi=@ttahhutsure,taahhut_bitis_tarihi=@tbitistarih,fatura_TOPLAM_odenen_ay_sayisi=@ftoplamodenenaysayisi,fatura_TOPLAM_gec_odenen_ay_sayisi=@ftoplamgecodenenaysayisi,fatura_TOPLAM_zamanında_odenen_ay_sayisi=@ftoplamzamanindaodenenaysayisi WHERE fatura_ADI=@fadi";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@mid", mid_txt.Text);
            komut.Parameters.AddWithValue("@fadi", fadi_txt.Text);
            komut.Parameters.AddWithValue("@fbaslangictarih", fbaslangictarih_dtp.Text);
            komut.Parameters.AddWithValue("@fbitistarihi", fbitistarih_dtp.Text);
            komut.Parameters.AddWithValue("@fodemetarih", fodemetarih_dtp.Text);
            komut.Parameters.AddWithValue("@fsonodemetarih", fsonodemetarih_dtp.Text);
            komut.Parameters.AddWithValue("@fucret", fucret_txt.Text);
            komut.Parameters.AddWithValue("@fodemedurum", fodemedurum.Text);
            komut.Parameters.AddWithValue("@ttahhutsure", ttahhutsure_txt.Text);
            komut.Parameters.AddWithValue("@tbitistarih", taahhutbitistarih_dtp.Text);
            komut.Parameters.AddWithValue("@ftoplamodenenaysayisi", todenenfsayisi_txt.Text);
            komut.Parameters.AddWithValue("@ftoplamgecodenenaysayisi", tgecodenenfsayisi_txt.Text);
            komut.Parameters.AddWithValue("@ftoplamzamanindaodenenaysayisi", tzamanindaodenenfsayisi_txt.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Fatura Güncellendi", "FATURA");
            dt.Clear();
            listele();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            mid_txt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fadi_txt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fbaslangictarih_dtp.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            fbitistarih_dtp.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fodemetarih_dtp.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fsonodemetarih_dtp.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            fucret_txt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            fodemedurum.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            ttahhutsure_txt.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            taahhutbitistarih_dtp.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            todenenfsayisi_txt.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            tgecodenenfsayisi_txt.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            tzamanindaodenenfsayisi_txt.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
        }

        private void temizle_btn_Click(object sender, EventArgs e)
        {
            mid_txt.Clear();
            fadi_txt.Clear();
            fbaslangictarih_dtp.Text = "";
            fbitistarih_dtp.Text = "";
            fodemetarih_dtp.Text = "";
            fsonodemetarih_dtp.Text = "";
            fucret_txt.Clear();
            ttahhutsure_txt.Clear();
            taahhutbitistarih_dtp.Text = "";
            todenenfsayisi_txt.Clear();
            tgecodenenfsayisi_txt.Clear();
            tzamanindaodenenfsayisi_txt.Clear();
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
