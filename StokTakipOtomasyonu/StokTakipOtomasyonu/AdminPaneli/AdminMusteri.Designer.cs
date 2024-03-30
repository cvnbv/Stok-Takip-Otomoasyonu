
namespace StokTakipOtomasyonu.AdminPaneli
{
    partial class AdminMusteri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton_diger = new System.Windows.Forms.RadioButton();
            this.radioButton_kadin = new System.Windows.Forms.RadioButton();
            this.radioButton_erkek = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox_musteri = new System.Windows.Forms.PictureBox();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_tc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_adres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_telno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.textBox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_arama = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_musteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.pictureBox_musteri);
            this.groupBox1.Controls.Add(this.button_sil);
            this.groupBox1.Controls.Add(this.button_guncelle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_tc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_adres);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_mail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_telno);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_sifre);
            this.groupBox1.Controls.Add(this.textBox_kullaniciAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 293);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Location = new System.Drawing.Point(530, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 89);
            this.panel1.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Onay Durumu :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Rol :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Onaylandı",
            "Onaylanmadı"});
            this.comboBox1.Location = new System.Drawing.Point(111, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.Text = "Onay Durumu";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Admin",
            "Müşteri",
            "Personel"});
            this.comboBox2.Location = new System.Drawing.Point(111, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 21);
            this.comboBox2.TabIndex = 35;
            this.comboBox2.Text = "Rol";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton_diger);
            this.panel2.Controls.Add(this.radioButton_kadin);
            this.panel2.Controls.Add(this.radioButton_erkek);
            this.panel2.Location = new System.Drawing.Point(619, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 75);
            this.panel2.TabIndex = 38;
            // 
            // radioButton_diger
            // 
            this.radioButton_diger.AutoSize = true;
            this.radioButton_diger.Location = new System.Drawing.Point(3, 48);
            this.radioButton_diger.Name = "radioButton_diger";
            this.radioButton_diger.Size = new System.Drawing.Size(50, 17);
            this.radioButton_diger.TabIndex = 2;
            this.radioButton_diger.TabStop = true;
            this.radioButton_diger.Text = "Diğer";
            this.radioButton_diger.UseVisualStyleBackColor = true;
            // 
            // radioButton_kadin
            // 
            this.radioButton_kadin.AutoSize = true;
            this.radioButton_kadin.Location = new System.Drawing.Point(3, 25);
            this.radioButton_kadin.Name = "radioButton_kadin";
            this.radioButton_kadin.Size = new System.Drawing.Size(52, 17);
            this.radioButton_kadin.TabIndex = 1;
            this.radioButton_kadin.TabStop = true;
            this.radioButton_kadin.Text = "Kadın";
            this.radioButton_kadin.UseVisualStyleBackColor = true;
            // 
            // radioButton_erkek
            // 
            this.radioButton_erkek.AutoSize = true;
            this.radioButton_erkek.Location = new System.Drawing.Point(3, 3);
            this.radioButton_erkek.Name = "radioButton_erkek";
            this.radioButton_erkek.Size = new System.Drawing.Size(53, 17);
            this.radioButton_erkek.TabIndex = 0;
            this.radioButton_erkek.TabStop = true;
            this.radioButton_erkek.Text = "Erkek";
            this.radioButton_erkek.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(619, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // pictureBox_musteri
            // 
            this.pictureBox_musteri.Location = new System.Drawing.Point(44, 52);
            this.pictureBox_musteri.Name = "pictureBox_musteri";
            this.pictureBox_musteri.Size = new System.Drawing.Size(146, 190);
            this.pictureBox_musteri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_musteri.TabIndex = 31;
            this.pictureBox_musteri.TabStop = false;
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(702, 255);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(75, 23);
            this.button_sil.TabIndex = 20;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_guncelle
            // 
            this.button_guncelle.Location = new System.Drawing.Point(621, 255);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(75, 23);
            this.button_guncelle.TabIndex = 19;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.UseVisualStyleBackColor = true;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefon No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mail :";
            // 
            // textBox_tc
            // 
            this.textBox_tc.Location = new System.Drawing.Point(342, 177);
            this.textBox_tc.Name = "textBox_tc";
            this.textBox_tc.Size = new System.Drawing.Size(121, 20);
            this.textBox_tc.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adres :";
            // 
            // textBox_adres
            // 
            this.textBox_adres.Location = new System.Drawing.Point(342, 130);
            this.textBox_adres.Multiline = true;
            this.textBox_adres.Name = "textBox_adres";
            this.textBox_adres.Size = new System.Drawing.Size(169, 41);
            this.textBox_adres.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "T.C Kimlik No :";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(342, 104);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(169, 20);
            this.textBox_mail.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Doğum Tarihi :";
            // 
            // textBox_telno
            // 
            this.textBox_telno.Location = new System.Drawing.Point(342, 78);
            this.textBox_telno.Name = "textBox_telno";
            this.textBox_telno.Size = new System.Drawing.Size(121, 20);
            this.textBox_telno.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(554, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cinsiyet :";
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(342, 52);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.Size = new System.Drawing.Size(122, 20);
            this.textBox_sifre.TabIndex = 11;
            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(342, 26);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(122, 20);
            this.textBox_kullaniciAdi.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 201);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Müşteri Ara :";
            // 
            // textBox_arama
            // 
            this.textBox_arama.Location = new System.Drawing.Point(91, 268);
            this.textBox_arama.Name = "textBox_arama";
            this.textBox_arama.Size = new System.Drawing.Size(123, 20);
            this.textBox_arama.TabIndex = 24;
            this.textBox_arama.TextChanged += new System.EventHandler(this.textBox_arama_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdminMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(880, 660);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_arama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMusteri";
            this.Text = "AdminMusteri";
            this.Load += new System.EventHandler(this.AdminMusteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_musteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton_diger;
        private System.Windows.Forms.RadioButton radioButton_kadin;
        private System.Windows.Forms.RadioButton radioButton_erkek;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox_musteri;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_tc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_adres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_telno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_kullaniciAdi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_arama;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
    }
}