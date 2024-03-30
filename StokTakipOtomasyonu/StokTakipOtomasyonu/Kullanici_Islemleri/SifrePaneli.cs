using StokTakipOtomasyonu.Business.Abstract;
using StokTakipOtomasyonu.Entities.Tables;
using StokTakipOtomasyonu.Security;
using StokTakipOtomasyonu.Security.UserInformation;
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
    public partial class SifrePaneli : Form
    {

        private IKullaniciServices _kullaniciServices;

        public SifrePaneli(IKullaniciServices kullaniciServices)
        {
            _kullaniciServices = kullaniciServices;

            InitializeComponent();
        }

        private void SifrePaneli_Load(object sender, EventArgs e)
        {
            ToolTip();
            pictureBox_close.Image = Image.FromFile(@"..\..\Resimler\Close.png");
            pictureBox_minimaze.Image = Image.FromFile(@"..\..\Resimler\eksi.png");
        }

        #region Şifre Gizleme
        private void txt_sifrepaneli_sifre_TextChanged(object sender, EventArgs e)
        {
            SifreTespit();
            if (checkBox_sifre.CheckState == CheckState.Unchecked)
            {
                txt_sifrepaneli_sifre.PasswordChar = '*';
            }
        }

        private void checkBox_sifre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sifre.CheckState == CheckState.Unchecked)
            {
                txt_sifrepaneli_sifre.PasswordChar = '*';
            }
            else
            {
                txt_sifrepaneli_sifre.PasswordChar = '\0';
            }
        }

        private void checkBox_sifre_onay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sifre_onay.CheckState == CheckState.Unchecked)
            {
                txt_sifrepaneli_sifre_onayla.PasswordChar = '*';
            }
            else
            {
                txt_sifrepaneli_sifre_onayla.PasswordChar = '\0';
            }
        }

        private void txt_sifrepaneli_sifre_onayla_TextChanged(object sender, EventArgs e)
        {
            SifreTespit();
            if (checkBox_sifre_onay.CheckState == CheckState.Unchecked)
            {
                txt_sifrepaneli_sifre_onayla.PasswordChar = '*';
            }
        }

        #endregion

        private void button_sifremiUnuttum_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SifreTespit()
        {
            if (txt_sifrepaneli_sifre.Text == txt_sifrepaneli_sifre_onayla.Text)
            {

                //Şifre gücünün tespiti yapılıp progress Bar ve yazı değişicek

                string sifre = txt_sifrepaneli_sifre.Text;
                PasswordPowerDetected password = new PasswordPowerDetected();

                switch (password.GetPasswordStrength(sifre))
                {
                    case PasswordPowerDetected.PasswordStrength.Gecersiz:

                        progressBar_sifreGucu.Value = password.GeneratePasswordScore(sifre);
                        progressBar_sifreGucu.ForeColor = DefaultForeColor;
                        label_new_sifreGucu.ForeColor = DefaultForeColor;
                        label_new_sifreGucu.Text = "Şifre Geçersiz!";

                        break;

                    case PasswordPowerDetected.PasswordStrength.Zayif:
                        progressBar_sifreGucu.Value = password.GeneratePasswordScore(sifre);
                        label_new_sifreGucu.ForeColor = Color.Red;
                        label_new_sifreGucu.Text = "Şifre Zayıf!";

                        break;

                    case PasswordPowerDetected.PasswordStrength.Normal:

                        progressBar_sifreGucu.Value = password.GeneratePasswordScore(sifre);
                        label_new_sifreGucu.ForeColor = Color.Yellow;
                        label_new_sifreGucu.Text = "Şifre Normal!";

                        break;

                    case PasswordPowerDetected.PasswordStrength.Guclu:

                        progressBar_sifreGucu.Value = password.GeneratePasswordScore(sifre);
                        label_new_sifreGucu.ForeColor = Color.YellowGreen;
                        label_new_sifreGucu.Text = "Şifre Güçlü!";

                        break;

                    case PasswordPowerDetected.PasswordStrength.Guvenli:

                        progressBar_sifreGucu.Value = password.GeneratePasswordScore(sifre);
                        label_new_sifreGucu.ForeColor = Color.Green;
                        label_new_sifreGucu.Text = "Şifre Güvenli!";

                        break;

                }
            }

        }

        public void ToolTip()
        {
            ToolTip Aciklama = new ToolTip();

            Aciklama.ToolTipTitle = "Şifre Detayları!";
            Aciklama.ToolTipIcon = ToolTipIcon.Warning;
            Aciklama.IsBalloon = true;

            Aciklama.SetToolTip(txt_sifrepaneli_sifre,
                "• Şifre Uzunluğu Minimum 8 Karakter Olmalıdır! \n " +
                "• Şifrenizde En az 1 büyük harf, 1 küçük harf, 1 rakam ve 1 özel (Örn; @#$% ) karakter bulunmalıdır! \n" +
                "• Şifreniz Kolay tahmin edilebilir olmamalıdır.");

            Aciklama.SetToolTip(txt_sifrepaneli_sifre_onayla,
                 "• Şifre Uzunluğu Minimum 8 Karakter Olmalıdır! \n " +
                 "• Şifrenizde En az 1 büyük harf, 1 küçük harf, 1 rakam ve 1 özel (Örn; @#$% ) karakter bulunmalıdır! \n" +
                 "• Şifreniz Kolay tahmin edilebilir olmamalıdır.");

        }

        private void button_Kaydet_Click(object sender, EventArgs e)
        {

            if (label_new_sifreGucu.Text == "Şifre Geçersiz!")
            {
                MessageBox.Show("Lütfen Geçerli Bir Şifre Giriniz!");
                return;
            }

            if (UserDetailBus.KullaniciPassword == txt_sifrepaneli_sifre.Text)
            {
                MessageBox.Show("Yeni şifreniz eski şifrenizle aynı olamaz!");
                return;
            }


            if (txt_sifrepaneli_sifre.Text == txt_sifrepaneli_sifre_onayla.Text && !string.IsNullOrEmpty(txt_sifrepaneli_sifre.Text) && !string.IsNullOrEmpty(txt_sifrepaneli_sifre_onayla.Text))
            {

               // Şifre güncelleme işlemleri
              
                var result =  _kullaniciServices.GetById(UserDetailBus.Id);

                result.KullaniciPassword = txt_sifrepaneli_sifre.Text;

                _kullaniciServices.Update(result);

                MessageBox.Show("Şifreniz Güncellendi!");

                this.Close();
            }
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
