using StokTakipOtomasyonu.Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyonu.Kullanici_Islemleri
{
    public partial class SifremiUnuttum : Form
    {
        IKullaniciServices _kullaniciServices;
        public SifremiUnuttum(IKullaniciServices kullaniciServices)
        {
            _kullaniciServices = kullaniciServices;

            InitializeComponent();
        }

        private void button_sifremiUnuttum_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int KullaniciID = 0;
        private void button_bilgileri_kontrol_et_Click(object sender, EventArgs e)
        {

            string Cinsiyet = "";

            if (radioButton_erkek.Checked)
            {
                Cinsiyet = "Erkek";
            }
            else if (radioButton_Kadın.Checked)
            {
                Cinsiyet = "Kadın";
            }
            else if (radioButton_diger.Checked)
            {
                Cinsiyet = "Diger";
            }
            else
            {
                MessageBox.Show("Lütfen Cinsiyet Seçiniz!");
            }

            var result = _kullaniciServices.BilgiKontrol(textBox_SifremiUnuttum_KullaniciAdi.Text, textBox_SifremiUnuttum_tc_kimlik.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), Cinsiyet);

            if (result == true)
            {
                
                SifrePaneli sifrePaneli = CompositionRoot.Resolve<SifrePaneli>();

                this.Hide();
                sifrePaneli.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Kullanici Bilgileri Eşleşmiyor!");
            }


         

        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
            pictureBox_close.Image = Image.FromFile(@"..\..\Resimler\Close.png");
            pictureBox_minimaze.Image = Image.FromFile(@"..\..\Resimler\eksi.png");
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
