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
    public partial class Puan : Form
    {
        public Puan()
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
            SqlDataAdapter sda = new SqlDataAdapter("select * from puan", baglanti);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void Puan_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void tel_txt_TextChanged(object sender, EventArgs e)
        {                                               
            baglanti.Open();                                 
            SqlDataAdapter sda = new SqlDataAdapter("select puan.fatura_ID,puan_ID,puan, puan_bilgi_TL_karsiligi from puan,fatura where fatura.musteri_ID in (select musteri_ID from musteri where musteri_TEL like '" + tel_txt.Text + "%') and puan.fatura_ID in (select fatura_ID from fatura where fatura_ADI like '" + faturaad_txt.Text + "%')", baglanti);
            DataTable dt2 = new DataTable();         
            sda.Fill(dt2);
            dataGridView1.DataSource = dt2;
            baglanti.Close();
            dt.Clear();
            listele();
        }

        private void faturaad_txt_TextChanged(object sender, EventArgs e)
        {                                               
            baglanti.Open();                                
            SqlDataAdapter sda = new SqlDataAdapter("select puan.fatura_ID,puan_ID,puan, puan_bilgi_TL_karsiligi from puan,fatura where fatura.musteri_ID in (select musteri_ID from musteri where musteri_TEL like '" + tel_txt.Text + "%') and puan.fatura_ID in (select fatura_ID from fatura where fatura_ADI like '" + faturaad_txt.Text + "%')", baglanti);
            DataTable dt2 = new DataTable();          
            sda.Fill(dt2);
            dataGridView1.DataSource = dt2;
            baglanti.Close();
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String sorgu = "insert into puan(puan_ID,fatura_ID,puan,puan_bilgi_TL_karsiligi) values('" + faturaID_txt.Text + "','" + puanID_txt.Text + "','" + puan_txt.Text + "','" + puanTLkarsiligi_txt.Text + "')";
            komut = new SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Puan Eklendi", "PUAN");
            dt.Clear();
            listele();
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM puan WHERE puan_ID=@puanid";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("puanid", faturaID_txt.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Puan Silindi", "PUAN");
            dt.Clear();
            listele();
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE puan SET puan_ID=@puanid,fatura_ID=@faturaid, puan=@puan, puan_bilgi_TL_karsiligi=@puantlkarsiligi WHERE puan_ID=@puanid";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@puanid", faturaID_txt.Text);
            komut.Parameters.AddWithValue("@faturaid", puanID_txt.Text);
            komut.Parameters.AddWithValue("@puan", puan_txt.Text);
            komut.Parameters.AddWithValue("@puantlkarsiligi", puanTLkarsiligi_txt.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Puan Güncellendi", "PUAN");
            dt.Clear();
            listele();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            faturaID_txt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            puanID_txt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            puan_txt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            puanTLkarsiligi_txt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void temizle_btn_Click(object sender, EventArgs e)
        {
            faturaID_txt.Clear();
            puanID_txt.Clear();
            puan_txt.Clear();
            puanTLkarsiligi_txt.Clear();
            tel_txt.Clear();
            faturaad_txt.Clear();
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
