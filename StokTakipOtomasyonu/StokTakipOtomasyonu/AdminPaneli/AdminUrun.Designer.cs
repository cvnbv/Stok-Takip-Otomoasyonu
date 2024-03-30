
namespace StokTakipOtomasyonu.AdminPaneli
{
    partial class AdminUrun
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_BarkodNo = new System.Windows.Forms.TextBox();
            this.textBox_urunadı = new System.Windows.Forms.TextBox();
            this.textBox_miktar = new System.Windows.Forms.TextBox();
            this.textBox_taneagirlik = new System.Windows.Forms.TextBox();
            this.textBox_alisfiyati = new System.Windows.Forms.TextBox();
            this.textBox_satisfiyati = new System.Windows.Forms.TextBox();
            this.textBox_resimyolu = new System.Windows.Forms.TextBox();
            this.comboBox_markaadi = new System.Windows.Forms.ComboBox();
            this.comboBox_miktarcesidi = new System.Windows.Forms.ComboBox();
            this.comboBox_kategori = new System.Windows.Forms.ComboBox();
            this.button_resimyolu = new System.Windows.Forms.Button();
            this.button_ekle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_stoktandus = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_arama = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_temizle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 274);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barkod No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Urun Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marka :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Miktar Çeşidi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tane Ağırlık :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 14);
            this.label6.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "Miktar :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "Alış Fiyatı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "Satış Fiyatı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 14);
            this.label10.TabIndex = 10;
            this.label10.Text = "Kategori :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 557);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 14);
            this.label11.TabIndex = 11;
            this.label11.Text = "Resim Yolu  :";
            // 
            // textBox_BarkodNo
            // 
            this.textBox_BarkodNo.Location = new System.Drawing.Point(94, 299);
            this.textBox_BarkodNo.Name = "textBox_BarkodNo";
            this.textBox_BarkodNo.Size = new System.Drawing.Size(130, 20);
            this.textBox_BarkodNo.TabIndex = 12;
            // 
            // textBox_urunadı
            // 
            this.textBox_urunadı.Location = new System.Drawing.Point(95, 327);
            this.textBox_urunadı.Name = "textBox_urunadı";
            this.textBox_urunadı.Size = new System.Drawing.Size(172, 20);
            this.textBox_urunadı.TabIndex = 13;
            // 
            // textBox_miktar
            // 
            this.textBox_miktar.Location = new System.Drawing.Point(94, 440);
            this.textBox_miktar.Name = "textBox_miktar";
            this.textBox_miktar.Size = new System.Drawing.Size(120, 20);
            this.textBox_miktar.TabIndex = 14;
            // 
            // textBox_taneagirlik
            // 
            this.textBox_taneagirlik.Location = new System.Drawing.Point(94, 467);
            this.textBox_taneagirlik.Name = "textBox_taneagirlik";
            this.textBox_taneagirlik.Size = new System.Drawing.Size(120, 20);
            this.textBox_taneagirlik.TabIndex = 15;
            // 
            // textBox_alisfiyati
            // 
            this.textBox_alisfiyati.Location = new System.Drawing.Point(94, 495);
            this.textBox_alisfiyati.Name = "textBox_alisfiyati";
            this.textBox_alisfiyati.Size = new System.Drawing.Size(120, 20);
            this.textBox_alisfiyati.TabIndex = 16;
            // 
            // textBox_satisfiyati
            // 
            this.textBox_satisfiyati.Location = new System.Drawing.Point(94, 523);
            this.textBox_satisfiyati.Name = "textBox_satisfiyati";
            this.textBox_satisfiyati.Size = new System.Drawing.Size(120, 20);
            this.textBox_satisfiyati.TabIndex = 17;
            // 
            // textBox_resimyolu
            // 
            this.textBox_resimyolu.Location = new System.Drawing.Point(94, 554);
            this.textBox_resimyolu.Name = "textBox_resimyolu";
            this.textBox_resimyolu.Size = new System.Drawing.Size(274, 20);
            this.textBox_resimyolu.TabIndex = 18;
            // 
            // comboBox_markaadi
            // 
            this.comboBox_markaadi.FormattingEnabled = true;
            this.comboBox_markaadi.Location = new System.Drawing.Point(94, 382);
            this.comboBox_markaadi.Name = "comboBox_markaadi";
            this.comboBox_markaadi.Size = new System.Drawing.Size(150, 22);
            this.comboBox_markaadi.TabIndex = 19;
            // 
            // comboBox_miktarcesidi
            // 
            this.comboBox_miktarcesidi.FormattingEnabled = true;
            this.comboBox_miktarcesidi.Location = new System.Drawing.Point(94, 411);
            this.comboBox_miktarcesidi.Name = "comboBox_miktarcesidi";
            this.comboBox_miktarcesidi.Size = new System.Drawing.Size(150, 22);
            this.comboBox_miktarcesidi.TabIndex = 20;
            // 
            // comboBox_kategori
            // 
            this.comboBox_kategori.FormattingEnabled = true;
            this.comboBox_kategori.Location = new System.Drawing.Point(94, 353);
            this.comboBox_kategori.Name = "comboBox_kategori";
            this.comboBox_kategori.Size = new System.Drawing.Size(150, 22);
            this.comboBox_kategori.TabIndex = 21;
            this.comboBox_kategori.SelectedIndexChanged += new System.EventHandler(this.comboBox_kategori_SelectedIndexChanged);
            // 
            // button_resimyolu
            // 
            this.button_resimyolu.Location = new System.Drawing.Point(374, 551);
            this.button_resimyolu.Name = "button_resimyolu";
            this.button_resimyolu.Size = new System.Drawing.Size(32, 25);
            this.button_resimyolu.TabIndex = 22;
            this.button_resimyolu.Text = "...";
            this.button_resimyolu.UseVisualStyleBackColor = true;
            this.button_resimyolu.Click += new System.EventHandler(this.button_resimyolu_Click);
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(164, 599);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(89, 34);
            this.button_ekle.TabIndex = 23;
            this.button_ekle.Text = "Ürün Ekle";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(445, 599);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(115, 34);
            this.button_sil.TabIndex = 24;
            this.button_sil.Text = "Depodan Kaldır";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(450, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_stoktandus
            // 
            this.button_stoktandus.Location = new System.Drawing.Point(350, 599);
            this.button_stoktandus.Name = "button_stoktandus";
            this.button_stoktandus.Size = new System.Drawing.Size(89, 34);
            this.button_stoktandus.TabIndex = 27;
            this.button_stoktandus.Text = "Stoktan Düş";
            this.button_stoktandus.UseVisualStyleBackColor = true;
            this.button_stoktandus.Click += new System.EventHandler(this.button_stoktandus_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(564, 609);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 14);
            this.label12.TabIndex = 29;
            this.label12.Text = "Urun Ara :";
            // 
            // textBox_arama
            // 
            this.textBox_arama.Location = new System.Drawing.Point(643, 606);
            this.textBox_arama.Name = "textBox_arama";
            this.textBox_arama.Size = new System.Drawing.Size(123, 20);
            this.textBox_arama.TabIndex = 28;
            this.textBox_arama.TextChanged += new System.EventHandler(this.textBox_arama_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(772, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 24);
            this.button1.TabIndex = 30;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_temizle
            // 
            this.button_temizle.Location = new System.Drawing.Point(69, 599);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(89, 34);
            this.button_temizle.TabIndex = 31;
            this.button_temizle.Text = "Formu Temizle";
            this.button_temizle.UseVisualStyleBackColor = true;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(738, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Stok Biten Ürünler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(738, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Tüm  Ürünler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_guncelle
            // 
            this.button_guncelle.Location = new System.Drawing.Point(259, 599);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(89, 34);
            this.button_guncelle.TabIndex = 34;
            this.button_guncelle.Text = "Ürünü Güncelle";
            this.button_guncelle.UseVisualStyleBackColor = true;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // AdminUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(880, 660);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_arama);
            this.Controls.Add(this.button_stoktandus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.button_resimyolu);
            this.Controls.Add(this.comboBox_kategori);
            this.Controls.Add(this.comboBox_miktarcesidi);
            this.Controls.Add(this.comboBox_markaadi);
            this.Controls.Add(this.textBox_resimyolu);
            this.Controls.Add(this.textBox_satisfiyati);
            this.Controls.Add(this.textBox_alisfiyati);
            this.Controls.Add(this.textBox_taneagirlik);
            this.Controls.Add(this.textBox_miktar);
            this.Controls.Add(this.textBox_urunadı);
            this.Controls.Add(this.textBox_BarkodNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUrun";
            this.Text = "AdminUrun";
            this.Load += new System.EventHandler(this.AdminUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_BarkodNo;
        private System.Windows.Forms.TextBox textBox_urunadı;
        private System.Windows.Forms.TextBox textBox_miktar;
        private System.Windows.Forms.TextBox textBox_taneagirlik;
        private System.Windows.Forms.TextBox textBox_alisfiyati;
        private System.Windows.Forms.TextBox textBox_satisfiyati;
        private System.Windows.Forms.TextBox textBox_resimyolu;
        private System.Windows.Forms.ComboBox comboBox_markaadi;
        private System.Windows.Forms.ComboBox comboBox_miktarcesidi;
        private System.Windows.Forms.ComboBox comboBox_kategori;
        private System.Windows.Forms.Button button_resimyolu;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_stoktandus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_arama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_guncelle;
    }
}