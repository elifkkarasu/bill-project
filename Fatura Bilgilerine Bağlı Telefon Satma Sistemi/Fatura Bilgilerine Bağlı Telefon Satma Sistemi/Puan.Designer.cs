namespace Fatura_Bilgilerine_Bağlı_Telefon_Satma_Sistemi
{
    partial class Puan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puan));
            this.label8 = new System.Windows.Forms.Label();
            this.faturaID_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.faturaad_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.puanTLkarsiligi_txt = new System.Windows.Forms.TextBox();
            this.puan_txt = new System.Windows.Forms.TextBox();
            this.puanID_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.temizle_btn = new System.Windows.Forms.Button();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.tel_txt = new System.Windows.Forms.MaskedTextBox();
            this.geridon_linklbl = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.anasayfayadon_btn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.AliceBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(78, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 57;
            this.label8.Text = "FATURA ID:";
            // 
            // faturaID_txt
            // 
            this.faturaID_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.faturaID_txt.Location = new System.Drawing.Point(159, 41);
            this.faturaID_txt.Name = "faturaID_txt";
            this.faturaID_txt.Size = new System.Drawing.Size(112, 21);
            this.faturaID_txt.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(524, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Fatura ADI:";
            // 
            // faturaad_txt
            // 
            this.faturaad_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.faturaad_txt.Location = new System.Drawing.Point(615, 63);
            this.faturaad_txt.Name = "faturaad_txt";
            this.faturaad_txt.Size = new System.Drawing.Size(128, 22);
            this.faturaad_txt.TabIndex = 54;
            this.faturaad_txt.TextChanged += new System.EventHandler(this.faturaad_txt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(319, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Telefon:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 166);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // puanTLkarsiligi_txt
            // 
            this.puanTLkarsiligi_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanTLkarsiligi_txt.Location = new System.Drawing.Point(159, 134);
            this.puanTLkarsiligi_txt.Name = "puanTLkarsiligi_txt";
            this.puanTLkarsiligi_txt.Size = new System.Drawing.Size(112, 21);
            this.puanTLkarsiligi_txt.TabIndex = 47;
            // 
            // puan_txt
            // 
            this.puan_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan_txt.Location = new System.Drawing.Point(159, 103);
            this.puan_txt.Name = "puan_txt";
            this.puan_txt.Size = new System.Drawing.Size(112, 21);
            this.puan_txt.TabIndex = 46;
            // 
            // puanID_txt
            // 
            this.puanID_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanID_txt.Location = new System.Drawing.Point(159, 72);
            this.puanID_txt.Name = "puanID_txt";
            this.puanID_txt.Size = new System.Drawing.Size(112, 21);
            this.puanID_txt.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(3, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "PUAN\'IN TL KARŞILIĞI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(111, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "PUAN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(93, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "PUAN ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.temizle_btn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.faturaID_txt);
            this.groupBox1.Controls.Add(this.puanTLkarsiligi_txt);
            this.groupBox1.Controls.Add(this.puan_txt);
            this.groupBox1.Controls.Add(this.puanID_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(21, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 219);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PUAN BİLGİLERİ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(165, 174);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 28);
            this.pictureBox5.TabIndex = 65;
            this.pictureBox5.TabStop = false;
            // 
            // temizle_btn
            // 
            this.temizle_btn.BackColor = System.Drawing.Color.DarkSalmon;
            this.temizle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizle_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.temizle_btn.Location = new System.Drawing.Point(163, 170);
            this.temizle_btn.Name = "temizle_btn";
            this.temizle_btn.Size = new System.Drawing.Size(108, 39);
            this.temizle_btn.TabIndex = 64;
            this.temizle_btn.Text = "TEMİZLE";
            this.temizle_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.temizle_btn.UseVisualStyleBackColor = false;
            this.temizle_btn.Click += new System.EventHandler(this.temizle_btn_Click);
            // 
            // ekle_btn
            // 
            this.ekle_btn.BackColor = System.Drawing.Color.DarkSalmon;
            this.ekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.ekle_btn.Location = new System.Drawing.Point(314, 269);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(131, 39);
            this.ekle_btn.TabIndex = 60;
            this.ekle_btn.Text = "PUAN EKLE";
            this.ekle_btn.UseVisualStyleBackColor = false;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.BackColor = System.Drawing.Color.DarkSalmon;
            this.sil_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.sil_btn.Location = new System.Drawing.Point(466, 269);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(127, 39);
            this.sil_btn.TabIndex = 61;
            this.sil_btn.Text = "PUAN SİL";
            this.sil_btn.UseVisualStyleBackColor = false;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.BackColor = System.Drawing.Color.DarkSalmon;
            this.guncelle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.guncelle_btn.Location = new System.Drawing.Point(615, 269);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(157, 39);
            this.guncelle_btn.TabIndex = 62;
            this.guncelle_btn.Text = "PUAN GÜNCELLE";
            this.guncelle_btn.UseVisualStyleBackColor = false;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // tel_txt
            // 
            this.tel_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tel_txt.Location = new System.Drawing.Point(390, 63);
            this.tel_txt.Mask = "(000)-000-0000";
            this.tel_txt.Name = "tel_txt";
            this.tel_txt.Size = new System.Drawing.Size(114, 21);
            this.tel_txt.TabIndex = 64;
            this.tel_txt.TextChanged += new System.EventHandler(this.tel_txt_TextChanged);
            // 
            // geridon_linklbl
            // 
            this.geridon_linklbl.ActiveLinkColor = System.Drawing.Color.Blue;
            this.geridon_linklbl.AutoSize = true;
            this.geridon_linklbl.BackColor = System.Drawing.Color.AliceBlue;
            this.geridon_linklbl.DisabledLinkColor = System.Drawing.Color.Blue;
            this.geridon_linklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geridon_linklbl.ForeColor = System.Drawing.Color.Blue;
            this.geridon_linklbl.LinkColor = System.Drawing.Color.Blue;
            this.geridon_linklbl.Location = new System.Drawing.Point(8, 7);
            this.geridon_linklbl.Name = "geridon_linklbl";
            this.geridon_linklbl.Size = new System.Drawing.Size(69, 16);
            this.geridon_linklbl.TabIndex = 65;
            this.geridon_linklbl.TabStop = true;
            this.geridon_linklbl.Text = "Geri Dön";
            this.geridon_linklbl.VisitedLinkColor = System.Drawing.Color.Blue;
            this.geridon_linklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.geridon_linklbl_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.AliceBlue;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.ForeColor = System.Drawing.Color.Red;
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(748, 35);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(48, 9);
            this.linkLabel2.TabIndex = 67;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ANA SAYFA";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // anasayfayadon_btn
            // 
            this.anasayfayadon_btn.BackColor = System.Drawing.Color.AliceBlue;
            this.anasayfayadon_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anasayfayadon_btn.BackgroundImage")));
            this.anasayfayadon_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anasayfayadon_btn.Location = new System.Drawing.Point(753, 3);
            this.anasayfayadon_btn.Name = "anasayfayadon_btn";
            this.anasayfayadon_btn.Size = new System.Drawing.Size(37, 33);
            this.anasayfayadon_btn.TabIndex = 66;
            this.anasayfayadon_btn.UseVisualStyleBackColor = false;
            this.anasayfayadon_btn.Click += new System.EventHandler(this.anasayfayadon_btn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSaat,
            this.lblTarih});
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(795, 22);
            this.statusStrip1.TabIndex = 68;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSaat
            // 
            this.lblSaat.BackColor = System.Drawing.Color.AliceBlue;
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(29, 17);
            this.lblSaat.Text = "Saat";
            // 
            // lblTarih
            // 
            this.lblTarih.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(34, 17);
            this.lblTarih.Text = "Tarih";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Puan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 368);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.anasayfayadon_btn);
            this.Controls.Add(this.geridon_linklbl);
            this.Controls.Add(this.tel_txt);
            this.Controls.Add(this.guncelle_btn);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.faturaad_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Puan";
            this.Text = "Puan";
            this.Load += new System.EventHandler(this.Puan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox faturaID_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox faturaad_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox puanTLkarsiligi_txt;
        private System.Windows.Forms.TextBox puan_txt;
        private System.Windows.Forms.TextBox puanID_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button temizle_btn;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.MaskedTextBox tel_txt;
        private System.Windows.Forms.LinkLabel geridon_linklbl;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button anasayfayadon_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSaat;
        private System.Windows.Forms.ToolStripStatusLabel lblTarih;
        private System.Windows.Forms.Timer timer1;
    }
}