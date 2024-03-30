
namespace StokTakipOtomasyonu.MusteriPaneli
{
    partial class MusteriSepet
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_sepettenCikar = new System.Windows.Forms.Button();
            this.textBox_tutar = new System.Windows.Forms.TextBox();
            this.textBox_miktar = new System.Windows.Forms.TextBox();
            this.textBox_urunadi = new System.Windows.Forms.TextBox();
            this.textBox_barkodno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_sepetonay = new System.Windows.Forms.Panel();
            this.panel_satis = new System.Windows.Forms.FlowLayoutPanel();
            this.button_satisYap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_satisyap = new System.Windows.Forms.ComboBox();
            this.panel_satisyapılcıak = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_sepetonay.SuspendLayout();
            this.panel_satis.SuspendLayout();
            this.panel_satisyapılcıak.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 291);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_sepettenCikar
            // 
            this.button_sepettenCikar.Location = new System.Drawing.Point(525, 422);
            this.button_sepettenCikar.Name = "button_sepettenCikar";
            this.button_sepettenCikar.Size = new System.Drawing.Size(210, 44);
            this.button_sepettenCikar.TabIndex = 1;
            this.button_sepettenCikar.Text = "Seçili Ürünü Sepetten Çıkar";
            this.button_sepettenCikar.UseVisualStyleBackColor = true;
            this.button_sepettenCikar.Click += new System.EventHandler(this.button_sepettenCikar_Click);
            // 
            // textBox_tutar
            // 
            this.textBox_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_tutar.Location = new System.Drawing.Point(287, 509);
            this.textBox_tutar.Name = "textBox_tutar";
            this.textBox_tutar.Size = new System.Drawing.Size(100, 24);
            this.textBox_tutar.TabIndex = 56;
            this.textBox_tutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_miktar
            // 
            this.textBox_miktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_miktar.Location = new System.Drawing.Point(287, 479);
            this.textBox_miktar.Name = "textBox_miktar";
            this.textBox_miktar.Size = new System.Drawing.Size(100, 24);
            this.textBox_miktar.TabIndex = 55;
            this.textBox_miktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_miktar.TextChanged += new System.EventHandler(this.textBox_miktar_TextChanged);
            // 
            // textBox_urunadi
            // 
            this.textBox_urunadi.Enabled = false;
            this.textBox_urunadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_urunadi.Location = new System.Drawing.Point(287, 449);
            this.textBox_urunadi.Name = "textBox_urunadi";
            this.textBox_urunadi.Size = new System.Drawing.Size(170, 24);
            this.textBox_urunadi.TabIndex = 54;
            // 
            // textBox_barkodno
            // 
            this.textBox_barkodno.Enabled = false;
            this.textBox_barkodno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_barkodno.Location = new System.Drawing.Point(287, 419);
            this.textBox_barkodno.Name = "textBox_barkodno";
            this.textBox_barkodno.Size = new System.Drawing.Size(100, 24);
            this.textBox_barkodno.TabIndex = 53;
            this.textBox_barkodno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(212, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 52;
            this.label6.Text = "Tutar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(47, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "Satın Almak İstediğiniz Miktar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(183, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ürün adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(130, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Ürün Barkod No :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(525, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 44);
            this.button2.TabIndex = 57;
            this.button2.Text = "Seçili Ürünün Sepetteki Miktarını Azalt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(695, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Genel Tutar :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(770, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 44);
            this.button1.TabIndex = 61;
            this.button1.Text = "Sepet Onay Talebi Oluştur!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_sepetonay
            // 
            this.panel_sepetonay.Controls.Add(this.button1);
            this.panel_sepetonay.Location = new System.Drawing.Point(522, 518);
            this.panel_sepetonay.Name = "panel_sepetonay";
            this.panel_sepetonay.Size = new System.Drawing.Size(224, 71);
            this.panel_sepetonay.TabIndex = 62;
            // 
            // panel_satis
            // 
            this.panel_satis.Controls.Add(this.button_satisYap);
            this.panel_satis.Location = new System.Drawing.Point(522, 369);
            this.panel_satis.Name = "panel_satis";
            this.panel_satis.Size = new System.Drawing.Size(219, 51);
            this.panel_satis.TabIndex = 63;
            // 
            // button_satisYap
            // 
            this.button_satisYap.BackColor = System.Drawing.Color.LightSalmon;
            this.button_satisYap.Location = new System.Drawing.Point(3, 3);
            this.button_satisYap.Name = "button_satisYap";
            this.button_satisYap.Size = new System.Drawing.Size(210, 44);
            this.button_satisYap.TabIndex = 62;
            this.button_satisYap.Text = "Satışı Gerçekleştir";
            this.button_satisYap.UseVisualStyleBackColor = false;
            this.button_satisYap.Click += new System.EventHandler(this.button_satisYap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Satış Yapılıcak Kullanıcı :";
            // 
            // comboBox_satisyap
            // 
            this.comboBox_satisyap.FormattingEnabled = true;
            this.comboBox_satisyap.Location = new System.Drawing.Point(218, 7);
            this.comboBox_satisyap.Name = "comboBox_satisyap";
            this.comboBox_satisyap.Size = new System.Drawing.Size(186, 21);
            this.comboBox_satisyap.TabIndex = 65;
            // 
            // panel_satisyapılcıak
            // 
            this.panel_satisyapılcıak.Controls.Add(this.label2);
            this.panel_satisyapılcıak.Controls.Add(this.comboBox_satisyap);
            this.panel_satisyapılcıak.Location = new System.Drawing.Point(69, 382);
            this.panel_satisyapılcıak.Name = "panel_satisyapılcıak";
            this.panel_satisyapılcıak.Size = new System.Drawing.Size(411, 31);
            this.panel_satisyapılcıak.TabIndex = 66;
            // 
            // MusteriSepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(880, 660);
            this.Controls.Add(this.panel_satisyapılcıak);
            this.Controls.Add(this.panel_satis);
            this.Controls.Add(this.panel_sepetonay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_tutar);
            this.Controls.Add(this.textBox_miktar);
            this.Controls.Add(this.textBox_urunadi);
            this.Controls.Add(this.textBox_barkodno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_sepettenCikar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriSepet";
            this.Text = "MusteriSepet";
            this.Load += new System.EventHandler(this.MusteriSepet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_sepetonay.ResumeLayout(false);
            this.panel_satis.ResumeLayout(false);
            this.panel_satisyapılcıak.ResumeLayout(false);
            this.panel_satisyapılcıak.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_sepettenCikar;
        private System.Windows.Forms.TextBox textBox_tutar;
        private System.Windows.Forms.TextBox textBox_miktar;
        private System.Windows.Forms.TextBox textBox_urunadi;
        private System.Windows.Forms.TextBox textBox_barkodno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_sepetonay;
        private System.Windows.Forms.FlowLayoutPanel panel_satis;
        private System.Windows.Forms.Button button_satisYap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_satisyap;
        private System.Windows.Forms.Panel panel_satisyapılcıak;
    }
}