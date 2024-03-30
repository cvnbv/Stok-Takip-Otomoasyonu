using StokTakipOtomasyonu.Business.Abstract;
using StokTakipOtomasyonu.Entities.Utilities;
using StokTakipOtomasyonu.Kullanici_Islemleri;
using StokTakipOtomasyonu.Security.UserInformation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyonu.AdminPaneli
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        private void AdminAnaSayfa_Load(object sender, EventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminAnaSayfa>());
            KullaniciBilgileri();
            pictureBox_close.Image = Image.FromFile(@"..\..\Resimler\Close.png");
            pictureBox_minimaze.Image = Image.FromFile(@"..\..\Resimler\eksi.png");
            pictureBox_anasayfa.Image = Image.FromFile(@"..\..\Resimler\dashboard.png");
            pictureBox_personel.Image = Image.FromFile(@"..\..\Resimler\user1.png");
            pictureBox_musteri.Image = Image.FromFile(@"..\..\Resimler\musteri.png");
            pictureBox_kullaniciOnay.Image = Image.FromFile(@"..\..\Resimler\teknikDeste.png");
            pictureBox_satislar.Image = Image.FromFile(@"..\..\Resimler\sale.png");
            pictureBox_cikis.Image = Image.FromFile(@"..\..\Resimler\exit.png");
            pictureBox_urun.Image = Image.FromFile(@"..\..\Resimler\urun.png");
            pictureBox_kategori.Image = Image.FromFile(@"..\..\Resimler\kategori.png");
            pictureBox_orta.Image = Image.FromFile(@"..\..\Resimler\tam.png");
            pictureBox3.Image = Image.FromFile(@"..\..\Resimler\bilgi.png");
            pictureBox_liste.Image = Image.FromFile(@"..\..\Resimler\list.png");
            pictureBox_sepetim.Image = Image.FromFile(@"..\..\Resimler\sepet.png");
          
    
 
        }

        private void KullaniciBilgileri()
        {
            label_kullaniciad.Text = UserDetailBus.KullaniciName;
            label19_tckimlik.Text = UserDetailBus.TCKimlik;
            label17_cinsiyet.Text = UserDetailBus.Cinsiyet;
            label18_dogum.Text = UserDetailBus.Dogumtarihi.ToString("d");

            if (UserDetailBus.ResimYolu == null || UserDetailBus.ResimYolu == "")
            {
               pictureBox_adminresim.Image = Image.FromFile(@"..\..\Resimler\user2.png");
            }
            else
            {
             pictureBox_adminresim.Image = Image.FromFile(UserDetailBus.ResimYolu);
            }
          
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            labelSaat.Text = DateTime.Now.ToLongTimeString();
            labelTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void PanelAnaDoldur(object GelenForm)
        {
            if (this.panelAna.Controls.Count > 0)
            {
                this.panelAna.Controls.RemoveAt(0);
            }
            Form Formlar = GelenForm as Form;
            Formlar.TopLevel = false;
            Formlar.Dock = DockStyle.Fill;
            this.panelAna.Controls.Add(Formlar);
            this.panelAna.Tag = Formlar;
            Formlar.Show();

        }
        //Paneli yönlendirme işlemi

        #region Admin Ana Sayfa 
        private void AdminAnaSayfaMouseClick(object sender, MouseEventArgs e)
        {
            
            PanelAnaDoldur(CompositionRoot.Resolve<AdminAnaSayfa>());
        }
        #endregion
        #region Admin Personel Liste
        private void AdminPersonelMouseClick(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminPersonel>());
        }

        #endregion
        #region Admin Müşteri Liste
        private void AdminMusteriMouseClick(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminMusteri>());
        }
        #endregion
        #region Admin Satışlar
        private void AdminSatisMouseClick(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminSatis>());
        }

        #endregion
        #region Admin Kullanici Onay
        private void AdminKullaniciOnayMouseClick(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminKullaniciOnay>());
        }

        #endregion
        #region Admin Ürünler
        private void AdminUrunlerMouseClick(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminUrun>());
        }
        #endregion
        #region Admin Kategori ve Marka
        private void AdminKategoriMouseClick(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminKategoriVeMarka>());
        }
        #endregion
        #region Admin Kullanici Bİlgilerim
        private void AdminBilgilerim_MouseClick(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminBilgilerim>());
        }
        #endregion


        #region SiderBar ın renk Değiştirme işlemi
        int sayac = 0;
        private Panel ilkPanel;
        private void renkdegisimi(object sender, EventArgs e)
        {
            //(sender as Control).BackColor = Color.LightCyan;

            Panel panel = (sender as Panel);
            
      

            if (sayac == 0)
            {
                if (ilkPanel !=null)
                {
                    ilkPanel.BackColor = Color.DarkSeaGreen;
                }
              
                panel.BackColor = Color.LightCyan;
                ilkPanel = panel;
                sayac++;
                return;
            }

            if (sayac == 1 )
            {
                ilkPanel.BackColor = Color.DarkSeaGreen;
                panel.BackColor = Color.LightCyan;
                ilkPanel = panel;
                sayac = 0;
            }


          
        }









        #endregion

        #region Kapatma tuşlarının işlemleri
        private void pictureBox_minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox_close_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Uygulamadan Çıkmak İstiyor Musunuz?", "Çıkış Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }


        }
        private void pictureBox_cikis_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Uygulamadan Çıkmak İstiyor Musunuz?", "Çıkış Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginAna login = CompositionRoot.Resolve<LoginAna>();
                login.ShowDialog();
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Uygulamadan Çıkmak İstiyor Musunuz?", "Çıkış Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginAna login = CompositionRoot.Resolve<LoginAna>();
                login.ShowDialog();
            }


        }

        int ortasayac = 0;
        private void pictureBox_orta_Click(object sender, EventArgs e)
        {

            if (ortasayac == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                pictureBox_orta.Image = Image.FromFile(@"..\..\Resimler\pencereli.png");
                PencereDurumu.state = this.WindowState;

                ortasayac++;
                return;
            }

            if (ortasayac == 1)
            {
                this.WindowState = FormWindowState.Normal;
                pictureBox_orta.Image = Image.FromFile(@"..\..\Resimler\tam.png");
                PencereDurumu.state = this.WindowState;

                ortasayac--;
                return;
            }

        }
        #endregion

        #region Formun Mouse ile tutulup Hareket Edilmesi

        // Uygulamayı yukardan tutup istediğimiz yere sürükleme ( --> using System.Runtime.InteropServices;  )
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Paneltop_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }




        #endregion

        private void AdminUrunListesi_MouseClick(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<MusteriPaneli.MusteriAlisverisListesi>());
        }

        private void AdminSepet_MouseClick(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<MusteriPaneli.MusteriSepet>());
        }
    }
}
