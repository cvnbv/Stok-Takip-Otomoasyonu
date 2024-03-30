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

namespace StokTakipOtomasyonu.PersonelPaneli
{
    public partial class PersonelPaneli : Form
    {
        public PersonelPaneli()
        {
            InitializeComponent();
        }
        private void PersonelPaneli_Load(object sender, EventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminPaneli.AdminAnaSayfa>());
            KullaniciBilgileri();
            pictureBox_close.Image = Image.FromFile(@"..\..\Resimler\Close.png");
            pictureBox_minimaze.Image = Image.FromFile(@"..\..\Resimler\eksi.png");
            pictureBox_anasayfa.Image = Image.FromFile(@"..\..\Resimler\dashboard.png");
           
            pictureBox_musteri.Image = Image.FromFile(@"..\..\Resimler\musteri.png");
       
            pictureBox_satislar.Image = Image.FromFile(@"..\..\Resimler\sale.png");
            pictureBox_cikis.Image = Image.FromFile(@"..\..\Resimler\exit.png");
            pictureBox_urun.Image = Image.FromFile(@"..\..\Resimler\urun.png");
            pictureBox_kategori.Image = Image.FromFile(@"..\..\Resimler\kategori.png");
            pictureBox_orta.Image = Image.FromFile(@"..\..\Resimler\tam.png");
            pictureBox3.Image = Image.FromFile(@"..\..\Resimler\bilgi.png");
            pictureBox_alis.Image = Image.FromFile(@"..\..\Resimler\list.png");
            pictureBox_sepet.Image = Image.FromFile(@"..\..\Resimler\sepet.png");

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelSaat.Text = DateTime.Now.ToLongTimeString();
            labelTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void KullaniciBilgileri()
        {
            label_kullaniciad.Text = UserDetailBus.KullaniciName;
            label19_tckimlik.Text = UserDetailBus.TCKimlik;
            label17_cinsiyet.Text = UserDetailBus.Cinsiyet;
            label18_dogum.Text = UserDetailBus.Dogumtarihi.ToString("d");

            if (UserDetailBus.ResimYolu == null || UserDetailBus.ResimYolu =="")
            {
                pictureBox_adminresim.Image = Image.FromFile(@"..\..\Resimler\user2.png");
            }
            else
            {
                pictureBox_adminresim.Image = Image.FromFile(UserDetailBus.ResimYolu);
            }

        }
        private void PanelAnaDoldur(object FormhObje)
        {
            if (this.panelAna.Controls.Count > 0)
            {
                this.panelAna.Controls.RemoveAt(0);
            }
            Form fh = FormhObje as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelAna.Controls.Add(fh);
            this.panelAna.Tag = fh;
            fh.Show();

        }


        //Paneli yönlendirme işlemleri
        #region Personel Ana Sayfa 
        private void PersonelAnaSayda_MouseClick(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminPaneli.AdminAnaSayfa>());
        }

        #endregion
        #region Personel Sepet
        private void PersonelSepetim_MouseClicl(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<MusteriPaneli.MusteriSepet>());
        }
        #endregion
        #region Personel Alışveriş Listesi
        private void PersonelAlisveris(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<MusteriPaneli.MusteriAlisverisListesi>());
        }
        #endregion
        #region Personel Müşteri
        private void PersonelMusteri_MouseClick(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminPaneli.AdminMusteri>());
        }
        #endregion
        #region Personel Satışlar

        private void PersonelSatislar_MouseClick(object sender, MouseEventArgs e)
        {

            PanelAnaDoldur(CompositionRoot.Resolve<AdminPaneli.AdminSatis>());


        }
        #endregion
        #region Personel Urunler

        private void PersonelUrunler_MouseClick(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminPaneli.AdminUrun>());

        }
        #endregion
        #region Personel Kategori ve Marka
        private void pictureBox_kategori_MouseClick(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminPaneli.AdminKategoriVeMarka>());
        }

        #endregion
        #region Personel Bilgilerim
        private void PersonelBilgilerim_MouseClick(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminPaneli.AdminBilgilerim>());
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

        #region SiderBar ın renk Değiştirme işlemi
        int sayac = 0;
        private Panel ilkPanel;
        private void renkdegisimi(object sender, EventArgs e)
        {
            //(sender as Control).BackColor = Color.LightCyan;

            Panel panel = (sender as Panel);



            if (sayac == 0)
            {
                if (ilkPanel != null)
                {
                    ilkPanel.BackColor = Color.MediumTurquoise;
                }

                panel.BackColor = Color.LightCyan;
                ilkPanel = panel;
                sayac++;
                return;
            }

            if (sayac == 1)
            {
                ilkPanel.BackColor = Color.MediumTurquoise;
                panel.BackColor = Color.LightCyan;
                ilkPanel = panel;
                sayac = 0;
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

    
    }
}

