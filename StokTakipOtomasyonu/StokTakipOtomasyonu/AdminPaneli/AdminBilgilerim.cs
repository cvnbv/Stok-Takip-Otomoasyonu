using StokTakipOtomasyonu.Business.Abstract;
using StokTakipOtomasyonu.Entities.Utilities;
using StokTakipOtomasyonu.Kullanici_Islemleri;
using StokTakipOtomasyonu.Security.UserInformation;
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

namespace StokTakipOtomasyonu.AdminPaneli
{
    public partial class AdminBilgilerim : Form
    {
        private IKullaniciServices _kullaniciServices;

        public AdminBilgilerim(IKullaniciServices kullaniciServices)
        {
            _kullaniciServices = kullaniciServices;
            InitializeComponent();
        }

        #region Pencere Boyutunun Kontrolü
        int boyutsayaci = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Font eski = this.Font;

            if (PencereDurumu.state == FormWindowState.Maximized)
            {
                if (boyutsayaci == 0)
                {
                    this.Font = new Font(eski.FontFamily, eski.Size + 5, eski.Style);
                    boyutsayaci++;

                    return;
                }

            }

            if (PencereDurumu.state == FormWindowState.Normal)
            {
                if (boyutsayaci == 1)
                {
                    this.Font = new Font(eski.FontFamily, eski.Size - 5, eski.Style);
                    boyutsayaci--;

                    return;
                }
            }
        }

        #endregion

        private void button_sifre_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sifremiUnuttum = CompositionRoot.Resolve<SifremiUnuttum>();

           
            sifremiUnuttum.ShowDialog();
            this.Show();
        }

        private void AdminBilgilerim_Load(object sender, EventArgs e)
        {
            if (UserDetailBus.RolID == 3 || UserDetailBus.RolID ==2)
            {
                panel_sabitBilgi.Visible = false;
            }

         

            if (UserDetailBus.ResimYolu !=null)
            {
               pictureBox1.Image = Image.FromFile(UserDetailBus.ResimYolu);
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"..\..\Resimler\user1.png");
            }
           
            textBox_kullaniciAdi.Text = UserDetailBus.KullaniciName;
            textBox_adres.Text = UserDetailBus.Adres;
            textBox_mail.Text = UserDetailBus.Mail;
            textBox_sifre.Text = UserDetailBus.KullaniciPassword;
            textBox_tc.Text = UserDetailBus.TCKimlik;
            textBox_telno.Text = UserDetailBus.TelNo;
            textBox_resimyolu.Text = UserDetailBus.ResimYolu;

            if (UserDetailBus.Cinsiyet == "Erkek")
            {
                radioButton_erkek.Checked =true;
            }
            else if (UserDetailBus.Cinsiyet == "Kadın")
            {

                radioButton_kadin.Checked = true;
            }
            else
            {

                radioButton_diger.Checked = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Ürün Resmi Seçiniz";
            //   | işretinin solu görünen yazı sağındaki ise filteri ysapıyor
            openFileDialog1.Filter = "JPEG Dosyaları (*.jpeg)|*.jpeg|Bitmap Dosyaları (*.bmp)|*.bmp|PNG Dosyaları (*.png)|*.png|JPG Dosyaları (*.jpg)|*.jpg ";


            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Resim ekleme sayfasında Tamam işlemi yapılırsa çalışıcak
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                textBox_resimyolu.Text = openFileDialog1.FileName;
            }


        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Bilgilerinizi güncellemek istiyor musunuz?", "Bilgi Güncelleme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {

                var bilgilerim = _kullaniciServices.GetById(UserDetailBus.Id);

                bilgilerim.KullaniciName = textBox_kullaniciAdi.Text;
                bilgilerim.Mail = textBox_mail.Text;
                bilgilerim.Adres = textBox_adres.Text;
                bilgilerim.Dogumtarihi = dateTimePicker1.Value;
                bilgilerim.TCKimlik = textBox_tc.Text;

                if (UserDetailBus.ResimYolu != textBox_resimyolu.Text)
                {
                    bilgilerim.ResimYolu = textBox_resimyolu.Text;
                    string ResimFile = Path.GetFileName(pictureBox1.ImageLocation);
                    string ResimPath = Path.Combine(Application.StartupPath + "\\img\\" + ResimFile);
                    File.Copy(pictureBox1.ImageLocation, ResimPath, true);

                    //Resmin Yolunu Güncelleyip yeni resmi dizin içerisine aldım.
                }

                bilgilerim.TelNo = textBox_telno.Text;

                _kullaniciServices.Update(bilgilerim);

                MessageBox.Show("Lütfen Tekrar Giriş Yapınız ve bilgileriniz güncellensin!");

                this.Hide();
                LoginAna login = CompositionRoot.Resolve<LoginAna>();
                login.ShowDialog();


            }

        }
    }
}
