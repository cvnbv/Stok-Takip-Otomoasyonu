
namespace StokTakipOtomasyonu.MusteriPaneli
{
    partial class MusteriAlisverisListesi
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
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_arama = new System.Windows.Forms.TextBox();
            this.comboBox_kategori = new System.Windows.Forms.ComboBox();
            this.comboBox_marka = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_barkodno = new System.Windows.Forms.TextBox();
            this.textBox_urunadi = new System.Windows.Forms.TextBox();
            this.textBox_miktar = new System.Windows.Forms.TextBox();
            this.textBox_tutar = new System.Windows.Forms.TextBox();
            this.button_sepeteekle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 451);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 24);
            this.button1.TabIndex = 33;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(184, 479);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Barkod No ile Urun Ara :";
            // 
            // textBox_arama
            // 
            this.textBox_arama.Location = new System.Drawing.Point(183, 495);
            this.textBox_arama.Name = "textBox_arama";
            this.textBox_arama.Size = new System.Drawing.Size(123, 20);
            this.textBox_arama.TabIndex = 31;
            this.textBox_arama.TextChanged += new System.EventHandler(this.textBox_arama_TextChanged);
            // 
            // comboBox_kategori
            // 
            this.comboBox_kategori.FormattingEnabled = true;
            this.comboBox_kategori.Location = new System.Drawing.Point(439, 480);
            this.comboBox_kategori.Name = "comboBox_kategori";
            this.comboBox_kategori.Size = new System.Drawing.Size(121, 21);
            this.comboBox_kategori.TabIndex = 34;
            this.comboBox_kategori.SelectedIndexChanged += new System.EventHandler(this.comboBox_kategori_SelectedIndexChanged_1);
            // 
            // comboBox_marka
            // 
            this.comboBox_marka.FormattingEnabled = true;
            this.comboBox_marka.Location = new System.Drawing.Point(655, 480);
            this.comboBox_marka.Name = "comboBox_marka";
            this.comboBox_marka.Size = new System.Drawing.Size(121, 21);
            this.comboBox_marka.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(793, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Listele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Kategori :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Marka :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ürün Barkod No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ürün adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Satın Almak İstediğiniz Miktar :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 600);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tutar";
            // 
            // textBox_barkodno
            // 
            this.textBox_barkodno.Enabled = false;
            this.textBox_barkodno.Location = new System.Drawing.Point(487, 520);
            this.textBox_barkodno.Name = "textBox_barkodno";
            this.textBox_barkodno.Size = new System.Drawing.Size(100, 20);
            this.textBox_barkodno.TabIndex = 45;
            this.textBox_barkodno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_urunadi
            // 
            this.textBox_urunadi.Location = new System.Drawing.Point(486, 546);
            this.textBox_urunadi.Name = "textBox_urunadi";
            this.textBox_urunadi.Size = new System.Drawing.Size(170, 20);
            this.textBox_urunadi.TabIndex = 46;
            // 
            // textBox_miktar
            // 
            this.textBox_miktar.Location = new System.Drawing.Point(487, 572);
            this.textBox_miktar.Name = "textBox_miktar";
            this.textBox_miktar.Size = new System.Drawing.Size(100, 20);
            this.textBox_miktar.TabIndex = 47;
            this.textBox_miktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_miktar.TextChanged += new System.EventHandler(this.textBox_miktar_TextChanged);
            // 
            // textBox_tutar
            // 
            this.textBox_tutar.Location = new System.Drawing.Point(487, 600);
            this.textBox_tutar.Name = "textBox_tutar";
            this.textBox_tutar.Size = new System.Drawing.Size(100, 20);
            this.textBox_tutar.TabIndex = 48;
            this.textBox_tutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_sepeteekle
            // 
            this.button_sepeteekle.Location = new System.Drawing.Point(727, 545);
            this.button_sepeteekle.Name = "button_sepeteekle";
            this.button_sepeteekle.Size = new System.Drawing.Size(120, 49);
            this.button_sepeteekle.TabIndex = 49;
            this.button_sepeteekle.Text = "Sepetime ekle";
            this.button_sepeteekle.UseVisualStyleBackColor = true;
            this.button_sepeteekle.Click += new System.EventHandler(this.button_sepeteekle_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(732, 508);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "Tüm Ürünleri Listele";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 469);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // MusteriAlisverisListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(880, 660);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_sepeteekle);
            this.Controls.Add(this.textBox_tutar);
            this.Controls.Add(this.textBox_miktar);
            this.Controls.Add(this.textBox_urunadi);
            this.Controls.Add(this.textBox_barkodno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox_marka);
            this.Controls.Add(this.comboBox_kategori);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_arama);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriAlisverisListesi";
            this.Text = "MusteriAlisverisListesi";
            this.Load += new System.EventHandler(this.MusteriAlisverisListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_arama;
        private System.Windows.Forms.ComboBox comboBox_kategori;
        private System.Windows.Forms.ComboBox comboBox_marka;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_barkodno;
        private System.Windows.Forms.TextBox textBox_urunadi;
        private System.Windows.Forms.TextBox textBox_miktar;
        private System.Windows.Forms.TextBox textBox_tutar;
        private System.Windows.Forms.Button button_sepeteekle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}