using StokTakipOtomasyonu.Business.Abstract;
using StokTakipOtomasyonu.Entities.Tables;
using StokTakipOtomasyonu.Mail;
using StokTakipOtomasyonu.Security.UserInformation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyonu.Kullanici_Islemleri
{
    public partial class LoginAna : Form
    {
       private IKullaniciServices _kullaniciServices;
       private IBeniUnutmaServices _beniUnutmaServices;

        public LoginAna(IKullaniciServices kullaniciServices,IBeniUnutmaServices beniUnutmaServices)
        {
            _beniUnutmaServices = beniUnutmaServices;
            _kullaniciServices = kullaniciServices;

            InitializeComponent();
        }


        private void LoginAna_Load(object sender, EventArgs e)
        { 
            BeniHatirla();

            pictureBox1.Image = Image.FromFile(@"..\..\Resimler\Wıxı.png");
            pictureBox_close.Image = Image.FromFile(@"..\..\Resimler\Close.png");
            pictureBox_minimaze.Image = Image.FromFile(@"..\..\Resimler\eksi.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BeniHatirla()
        {
            var benihatirla = _beniUnutmaServices.GetById(1);

            if (benihatirla.hatirla == true)
            {
                textBox_LoginAna_KullaniciAdi.Text = benihatirla.Ad;
                textBox_LoginAna_Password.Text = benihatirla.Sifre;
                textBox_LoginAna_tc_kimlik.Text = benihatirla.tc;
                checkBox1.Checked = true;
            }
        }

        #region Şifre Gizleme ve Gösterme
        private void checkBox_LoginAna_sifre_goster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_LoginAna_sifre_goster.Checked == true)
            {
                textBox_LoginAna_Password.PasswordChar = '\0';
            }
            else
            {
                textBox_LoginAna_Password.PasswordChar = '*';
            }
        }

        private void textBox_LoginAna_Password_TextChanged(object sender, EventArgs e)
        {

            if (checkBox_LoginAna_sifre_goster.Checked == false)
            {
                textBox_LoginAna_Password.PasswordChar = '*'; //başlarken checkbox false ise direkt * ile başlaması için
            }
        }

        #endregion

        private void button_sifremi_unuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sifremiUnuttum = CompositionRoot.Resolve<SifremiUnuttum>();

            this.Hide();
            sifremiUnuttum.ShowDialog();
            this.Show();

        }


        private void button_giris_yap_Click(object sender, EventArgs e)
        {
            if (_kullaniciServices.GenericIsLOgin(textBox_LoginAna_tc_kimlik.Text ,textBox_LoginAna_KullaniciAdi.Text, textBox_LoginAna_Password.Text))
            {
                #region BeniHatirla ile Textbox'larin Doldurulması
                var benihatirla = _beniUnutmaServices.GetById(1);
                
                if (checkBox1.Checked == true)
                {

                 
                    benihatirla.Ad = textBox_LoginAna_KullaniciAdi.Text;
                    benihatirla.Sifre = textBox_LoginAna_Password.Text;
                    benihatirla.tc = textBox_LoginAna_tc_kimlik.Text;
                    benihatirla.hatirla = true;

                    _beniUnutmaServices.Update(benihatirla);

                }
                else
                {
                    
                    benihatirla.Ad =" ";
                    benihatirla.Sifre = " ";
                    benihatirla.tc =" ";
                    benihatirla.hatirla = false;

                    _beniUnutmaServices.Update(benihatirla);
                }

                #endregion


                if (UserDetailBus.RolID == 1 && UserDetailBus.Onayli ==true)//Admin ise girş yapılcıak yer
                {
                    MessageBox.Show("Hoşgeldiniz " + textBox_LoginAna_KullaniciAdi.Text + "! ");

                    var frm = CompositionRoot.Resolve<AdminPaneli.AdminPanel>();
                    this.Hide();
                    frm.ShowDialog();
                    
                    
                    
                }
                else if (UserDetailBus.RolID == 2 && UserDetailBus.Onayli == true)//Müşteri Kısmına yönlendirilicek
                {
                    MessageBox.Show("Hoşgeldiniz " + textBox_LoginAna_KullaniciAdi.Text + " ! ");

                    var frm = CompositionRoot.Resolve<MusteriPaneli.MusteriPaneli>();
                    this.Hide();
                    frm.ShowDialog();
                    

                }
                else if (UserDetailBus.RolID == 3 && UserDetailBus.Onayli == true) //Personel Kısmına yönlendirilicek
                {
                    MessageBox.Show("Hoşgeldiniz " + textBox_LoginAna_KullaniciAdi.Text + "! ");

                    var frm = CompositionRoot.Resolve<PersonelPaneli.PersonelPaneli>();
                    this.Hide();
                    frm.ShowDialog();
                   
                }

                if (UserDetailBus.Onayli == false && UserDetailBus.RolID == 0)//Hesap Onaylanmamış ise Mesaj gösterilicek ekranda
                {
                    MessageBox.Show(textBox_LoginAna_KullaniciAdi.Text + " Hoşgeldiniz fakat hesabınız onaylanmadı lütfen yönetimin onaylamasını bekleyiniz! ");
                }




            }
            else
            {
                MessageBox.Show("Giriş Yapmaya Çalıştığınız Bilgiler Yanlış Lütfen Tekrar Deneyiniz!");
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            YeniKullanici yeniKullanici = CompositionRoot.Resolve<YeniKullanici>();

            this.Hide();
            yeniKullanici.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Uygulamadan Çıkmak İstiyor Musunuz?", "Çıkış Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

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
    }
}
