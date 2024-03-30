using StokTakipOtomasyonu.Business.Abstract;
using StokTakipOtomasyonu.Entities.Tables;
using StokTakipOtomasyonu.Mail;
using StokTakipOtomasyonu.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyonu.Kullanici_Islemleri
{
    public partial class YeniKullanici : Form
    {
        private IKullaniciServices _kullaniciServices;
        public YeniKullanici(IKullaniciServices kullaniciServices)
        {
            _kullaniciServices = kullaniciServices;
            InitializeComponent();
        }
       
        private void YeniKullanici_Load(object sender, EventArgs e)
        {
            pictureBox_resim.Image = Image.FromFile(@"..\..\Resimler\user2.png");
            pictureBox_close.Image = Image.FromFile(@"..\..\Resimler\Close.png");
            pictureBox_minimaze.Image = Image.FromFile(@"..\..\Resimler\eksi.png");
            ToolTip();

        }

        #region Şifre Gücünü Belirleme
        public void SifreTespit()
        {
            if (textBox_new_sifre.Text == textBox_new_sifreonay.Text)
            {

                //Şifre gücünün tespiti yapılıp progress Bar ve yazı değişicek

                string sifre = textBox_new_sifre.Text;
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
        #endregion

        #region Şifre Kurallarını Gösteren ToolTip
        public void ToolTip()
        {
            ToolTip Aciklama = new ToolTip();

            Aciklama.ToolTipTitle = "Şifre Detayları!";
            Aciklama.ToolTipIcon = ToolTipIcon.Warning;
            Aciklama.IsBalloon = true;

            Aciklama.SetToolTip(textBox_new_sifre, 
                "• Şifre Uzunluğu Minimum 8 Karakter Olmalıdır! \n " +
                "• Şifrenizde En az 1 büyük harf, 1 küçük harf, 1 rakam ve 1 özel (Örn; @#$% ) karakter bulunmalıdır! \n" +
                "• Şifreniz Kolay tahmin edilebilir olmamalıdır.");

            Aciklama.SetToolTip(textBox_new_sifreonay,
                 "• Şifre Uzunluğu Minimum 8 Karakter Olmalıdır! \n " +
                 "• Şifrenizde En az 1 büyük harf, 1 küçük harf, 1 rakam ve 1 özel (Örn; @#$% ) karakter bulunmalıdır! \n" +
                 "• Şifreniz Kolay tahmin edilebilir olmamalıdır.");

        }
        #endregion

        #region Kapatma
        private void button_new_kapat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Geri Dönmek İstiyor Musunuz?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


            if (result == DialogResult.OK)
            {
                this.Close();
            }

        }
        #endregion

        #region Şifre Gizleme Ve Gösterme
        private void textBox_new_sifre_TextChanged(object sender, EventArgs e)
        {
            SifreTespit();

            if (checkBox_new_sifre.Checked == false)
            {
                textBox_new_sifre.PasswordChar = '*';
            }
        }

        private void textBox_new_sifreonay_TextChanged(object sender, EventArgs e)
        {
            SifreTespit();
            if (checkBox_new_sifreonay.Checked == false)
            {
                textBox_new_sifreonay.PasswordChar = '*';
            }
        }

        private void checkBox_new_sifre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_new_sifre.Checked == false)
            {
                textBox_new_sifre.PasswordChar = '*';
            }
            else
            {
                textBox_new_sifre.PasswordChar = '\0';
            }
        }

        private void checkBox_new_sifreonay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_new_sifreonay.Checked == false)
            {
                textBox_new_sifreonay.PasswordChar = '*';
            }
            else
            {
                textBox_new_sifreonay.PasswordChar = '\0';
            }
        }

        #endregion

        #region Resim Yolu İşlemi
        private void button_gozat_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Ürün Resmi Seçiniz";
            //   | işretinin solu görünen yazı sağındaki ise filteri ysapıyor
            openFileDialog1.Filter = "JPEG Dosyaları (*.jpeg)|*.jpeg|Bitmap Dosyaları (*.bmp)|*.bmp|PNG Dosyaları (*.png)|*.png|JPG Dosyaları (*.jpg)|*.jpg ";


            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Resim ekleme sayfasında Tamam işlemi yapılırsa çalışıcak
            {
                pictureBox_resim.ImageLocation = openFileDialog1.FileName;
                textBox_new_resimyolu.Text = openFileDialog1.FileName;
            }

        }
        #endregion

        #region Form Temizleme İşlemi
        private void button_form_temizle_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Formu Temizlemek İstiyor Musunuz?", "Form Temizleme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


            if (result == DialogResult.OK)
            {
                textBox_new_ad.Clear();
                textBox_new_soyad.Clear();
                textBox_new_telefonNo.Clear();
                textBox_new_tc.Clear();
                textBox_new_sifreonay.Clear();
                textBox_new_mail.Clear();
                textBox_new_resimyolu.Clear();
                textBox_new_sifre.Clear();
                dateTimePicker1.Text = "";
                label_new_sifreGucu.Text ="";
                progressBar_sifreGucu.Value = 0;
                richTextBox_new_adres.Clear();
                checkBox_new_sifre.Checked = false;
                checkBox_new_sifreonay.Checked = false;

                pictureBox_resim.Image = Image.FromFile(@"..\..\Resimler\user2.png");
                pictureBox_resim.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
        #endregion

        #region Textboxların Renk Değişimi
        private void Textboxlar_giris(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.LightCyan;
        }

        private void Textboxlar_Cikis(object sender, EventArgs e)
        {

            (sender as Control).BackColor = Color.White;
        }
        #endregion

        #region Kayıt
        private void button_new_kaydet_Click(object sender, EventArgs e)
        {

            try
            {

                var KontorlTC = _kullaniciServices.KullaniciVarMi(textBox_new_tc.Text, textBox_new_ad.Text);

                if (!KontorlTC)//True gelirse böyle bir kullanıcı mevcuttur
                {
                    MessageBox.Show("Bu T.C Kimlik No'lu kullanıcı mevcut!");
                    return;
                }

                if (textBox_new_sifre.Text == textBox_new_sifreonay.Text && !string.IsNullOrEmpty(textBox_new_sifre.Text) && !string.IsNullOrEmpty(textBox_new_sifreonay.Text))
                {

                    if (label_new_sifreGucu.Text == "Şifre Geçersiz!")
                    {
                        MessageBox.Show("Şifreniz Geçersiz Lütfen Geçerli Bir Şifre Belirleyiniz!");
                        return;
                    }

                    Kullanici kullanici = new Kullanici();

                    string mesaj = "";
                    int hataSayaci = 0;

                    if (string.IsNullOrEmpty(textBox_new_ad.Text))
                    {
                        mesaj = "Ad Alanını Doldurunuz! \n";
                        hataSayaci++;
                    }
                    if (string.IsNullOrEmpty(textBox_new_soyad.Text))
                    {
                        mesaj = mesaj + "Soyad Alanını Doldurunuz! \n";
                        hataSayaci++;
                    }
                    if (string.IsNullOrEmpty(textBox_new_mail.Text))
                    {
                        mesaj = mesaj + "Mail Alanını Doldurunuz! \n";
                        hataSayaci++;
                    }
                    if (string.IsNullOrEmpty(richTextBox_new_adres.Text))
                    {
                        mesaj = mesaj + "Adres Alanını Doldurunuz! \n";
                        hataSayaci++;
                    }

                    if (dateTimePicker1.Value == DateTime.Now)
                    {
                        mesaj = mesaj + "Doğum Tarihi Seçiniz! \n";
                        hataSayaci++;
                    }
                    else if (dateTimePicker1.Value > DateTime.Now)
                    {
                        mesaj = mesaj + "Doğru Doğum Tarihi Seçiniz! \n";
                        hataSayaci++;
                    }
                    else
                    {
                        kullanici.Dogumtarihi = dateTimePicker1.Value;
                    }


                    if (string.IsNullOrEmpty(textBox_new_telefonNo.Text))
                    {
                        mesaj = mesaj + "Telefon No Alanını Doldurunuz! \n";
                        hataSayaci++;
                    }
                    if (string.IsNullOrEmpty(textBox_new_tc.Text))
                    {
                        mesaj = mesaj + "T.C Kimlik No Alanını Doldurunuz! \n";
                        hataSayaci++;
                    }
                    string kullaniciAdi = textBox_new_ad.Text.Trim() + " " + textBox_new_soyad.Text.Trim();
                    kullanici.KullaniciName = kullaniciAdi;


                    kullanici.KullaniciPassword = textBox_new_sifre.Text;
                    kullanici.Mail = textBox_new_mail.Text;
                    kullanici.Adres = richTextBox_new_adres.Text;
                    kullanici.TelNo = textBox_new_telefonNo.Text;
                    if (pictureBox_resim.ImageLocation == null)
                    {
                        kullanici.ResimYolu = "";
                        pictureBox_resim.ImageLocation = kullanici.ResimYolu; ;

                    }

                    kullanici.TCKimlik = textBox_new_tc.Text;

                    if (radioButton_erkek.Checked)
                    {
                        kullanici.Cinsiyet = "Erkek";
                    }
                    else if (radioButton_Kadın.Checked)
                    {
                        kullanici.Cinsiyet = "Kadın";
                    }
                    else if (radioButton_diger.Checked)
                    {
                        kullanici.Cinsiyet = "Diğer";
                    }
                    else
                    {
                        mesaj = mesaj + "Cinsiyet Alanını Doldurunuz! \n";
                        hataSayaci++;
                    }


                    if (hataSayaci == 0)
                    {

                            if (pictureBox_resim.ImageLocation == null || pictureBox_resim.ImageLocation == "") //Resim yok ise seçilen işlem yapılmıcak
                            {

                            }
                            else
                            {
                                //Kaydedilen Resmin Dizin içerisine alınması gerekiyor
                                string ResimFile = Path.GetFileName(pictureBox_resim.ImageLocation);
                                string ResimPath = Path.Combine(Application.StartupPath + "\\img\\" + ResimFile);
                                File.Copy(pictureBox_resim.ImageLocation, ResimPath, true);

                                 kullanici.ResimYolu = ResimPath;

                            }



                            _kullaniciServices.Add(kullanici);
                            MessageBox.Show("Kullanici Eklendi");

                            MailGonderme.MusteriMailGonderme mailGonderme = new MailGonderme.MusteriMailGonderme();
                            string OnayBekliyor = textBox_new_ad.Text + " Başvurunuz Onay Sürecine Alınmıştır En Kısa Sürede Geri Dönüş Yapılıcaktır!";
                            string Baslik = "Stok Takip Otomasyonu Kayıt Onay Süreci";
                            string mail = textBox_new_mail.Text;
                            mailGonderme.Mesaj(Baslik, OnayBekliyor, mail);

                            MailGonderme.AdminMailGonderme adminmail = new MailGonderme.AdminMailGonderme();

                            string OnayBekliyor2 = textBox_new_ad.Text + " Yeni kayıt başvurusu gerçekleştirdi ve onay ve rol bekleniyor Admin en kısa sürede onaylayınız!";
                            string Baslik2 = "Stok Takip Otomasyonu Kayıt Onay Bekleyen Kullanıcı";

                            adminmail.AdminMesaj(Baslik2, OnayBekliyor2);


                            this.Close();
                     


                    }
                    else
                    {
                        MessageBox.Show(mesaj, "Boş Alanlar", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    if (textBox_new_sifre.Text == "" || textBox_new_sifreonay.Text == "")
                    {
                        MessageBox.Show("Lütfen Şifre Giriniz! \n Alanları Doldurunuz!");
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Eşleşmiyor!");
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Bir İşlem Yaptınız Lütfen Tekrar Deneyiniz!");
            }

       

        }
        #endregion

        #region Sadece Sayı Girilmesi İçin
        private void Textboxlar_keypress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                //47 - 58 kodulu tuşlara basıldıysa yaızlıcak 0-1-2-3-4-5-6-7-8-9 rakamlarının karşılıkları

                e.Handled = false;// false ise handle çalışıyor 
            }
            else if ((int)e.KeyChar == 8)
            {
                //backspace in ascii kodu 8 dir
                e.Handled = false;
                //silme işlemide gerçekleştirebilri
            }
            else
            {
                e.Handled = true;

                //belirtmediğimiz bir ifade yazılmaya çalışırsa yazmıcak
            }

        }
        #endregion

        #region Textboxlar Arasında Ok İşaretleriyle Gezme işlemi
        private void Textboxlar_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {

                //klavyeden basılan tuşu alıp yukarı tuş mu diye kontrol ettirdik 
                //eğer yukarı tuş ise sıradaki controla yani objeye geçiyor

                this.SelectNextControl(sender as Control, true, true, true, true);

                // ilk ifade true ise tab index artan olarak gider 0-1-2-3-4-.... şeklinde

                e.Handled = true;

            }
        }

        private void Textboxlar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                //klavyeden basılan tuşu alıp yukarı tuş mu diye kontrol ettirdik 
                //eğer yukarı tuş ise sıradaki controla yani objeye geçiyor

                this.SelectNextControl(sender as Control, false, true, true, true);
                // ilk ifade false ise tab index azalan olarak gider 4-3-2-1-0-4-3-2.... şeklinde


                e.Handled = true;

            }
        }

        #endregion

        #region Kapatma Ve Küçültme İşlemleri
        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Uygulamadan Çıkmak İstiyor Musunuz?", "Çıkış Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox_minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
