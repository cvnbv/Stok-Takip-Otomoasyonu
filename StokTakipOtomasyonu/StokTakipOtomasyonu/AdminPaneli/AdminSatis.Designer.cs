
namespace StokTakipOtomasyonu.AdminPaneli
{
    partial class AdminSatis
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_musteri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_tckimlik = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_satis = new System.Windows.Forms.Button();
            this.button_tumsatislar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 516);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox_musteri
            // 
            this.comboBox_musteri.FormattingEnabled = true;
            this.comboBox_musteri.Location = new System.Drawing.Point(245, 16);
            this.comboBox_musteri.Name = "comboBox_musteri";
            this.comboBox_musteri.Size = new System.Drawing.Size(166, 21);
            this.comboBox_musteri.TabIndex = 2;
            this.comboBox_musteri.SelectedIndexChanged += new System.EventHandler(this.comboBox_musteri_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sepetini Görmek İstediğiniz Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "T.C Kimlik No:";
            // 
            // textBox_tckimlik
            // 
            this.textBox_tckimlik.Location = new System.Drawing.Point(497, 16);
            this.textBox_tckimlik.Name = "textBox_tckimlik";
            this.textBox_tckimlik.Size = new System.Drawing.Size(146, 20);
            this.textBox_tckimlik.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_satis
            // 
            this.button_satis.Location = new System.Drawing.Point(740, 11);
            this.button_satis.Name = "button_satis";
            this.button_satis.Size = new System.Drawing.Size(128, 28);
            this.button_satis.TabIndex = 8;
            this.button_satis.Text = "Satışı Gerçekleştir";
            this.button_satis.UseVisualStyleBackColor = true;
            this.button_satis.Click += new System.EventHandler(this.button_satis_Click);
            // 
            // button_tumsatislar
            // 
            this.button_tumsatislar.Location = new System.Drawing.Point(740, 46);
            this.button_tumsatislar.Name = "button_tumsatislar";
            this.button_tumsatislar.Size = new System.Drawing.Size(128, 28);
            this.button_tumsatislar.TabIndex = 9;
            this.button_tumsatislar.Text = "Tüm Satışları Listele";
            this.button_tumsatislar.UseVisualStyleBackColor = true;
            this.button_tumsatislar.Click += new System.EventHandler(this.button_tumsatislar_Click);
            // 
            // AdminSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(880, 660);
            this.Controls.Add(this.button_tumsatislar);
            this.Controls.Add(this.button_satis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_tckimlik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_musteri);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSatis";
            this.Text = "AdminSatis";
            this.Load += new System.EventHandler(this.AdminSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_musteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_tckimlik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_satis;
        private System.Windows.Forms.Button button_tumsatislar;
    }
}