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

namespace StokTakipOtomasyonu.MusteriPaneli
{
    public partial class MusteriPaneli : Form
    {
        private IKullaniciServices _kullaniciServices;

        public MusteriPaneli(IKullaniciServices kullaniciServices)
        {
                _kullaniciServices = kullaniciServices;
                InitializeComponent();
        }

        private void MusteriAnaSayfa_Load(object sender, EventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminPaneli.AdminAnaSayfa>());
            KullaniciBilgileri();
            pictureBox_close.Image = Image.FromFile(@"..\..\Resimler\Close.png");
            pictureBox_minimaze.Image = Image.FromFile(@"..\..\Resimler\eksi.png");
            pictureBox_anasayfa.Image = Image.FromFile(@"..\..\Resimler\dashboard.png");
            pictureBox_sepetim.Image = Image.FromFile(@"..\..\Resimler\sepet.png");
            pictureBox_liste.Image = Image.FromFile(@"..\..\Resimler\list.png");
            pictureBox_cikis.Image = Image.FromFile(@"..\..\Resimler\exit.png");
            pictureBox_orta.Image = Image.FromFile(@"..\..\Resimler\tam.png");
            pictureBox3.Image = Image.FromFile(@"..\..\Resimler\bilgi.png");




        }

        private void KullaniciBilgileri()
        {
            label_bilgi_ad_soyad.Text = UserDetailBus.KullaniciName;
            label_bilgi_tc.Text = UserDetailBus.TCKimlik;
            label_bilgi_Cinsiyet.Text = UserDetailBus.Cinsiyet;
            label_bilgi_dogum.Text = UserDetailBus.Dogumtarihi.ToString("d");

            if (UserDetailBus.ResimYolu == null || UserDetailBus.ResimYolu == "")
            {
                pictureBox1.Image = Image.FromFile(@"..\..\Resimler\user2.png");
            }
            else
            {
                pictureBox1.Image = Image.FromFile(UserDetailBus.ResimYolu);
            }
        }

        private void MusteriAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelSaat.Text = DateTime.Now.ToLongTimeString();
            labelTarih.Text = DateTime.Now.ToShortDateString();
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

        #region Kapatma ve Küçültme İşlemleri
        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Uygulamadan Çıkmak İstiyor Musunuz?", "Çıkış Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
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

        private void pictureBox_minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                    ilkPanel.BackColor = Color.FromArgb(255,192,128);
                }

                panel.BackColor = Color.LightCyan;
                ilkPanel = panel;
                sayac++;
                return;
            }

            if (sayac == 1)
            {
                ilkPanel.BackColor = Color.FromArgb(255, 192, 128);
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

        #region Pencere Durumunun Takibi 
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

        #region Müşteri Panellerin Yüklenmesi
        private void MusteriAnaSayfa_MouseClicl(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminPaneli.AdminAnaSayfa>());
        }

        private void MusteriSepetim_MouseClic(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<MusteriSepet>());
        }

        private void MusteriAlisverisListesi_MouseClick(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<MusteriAlisverisListesi>());
        }
        private void MusteriBilgilerim_MouseClick(object sender, MouseEventArgs e)
        {
            PanelAnaDoldur(CompositionRoot.Resolve<AdminPaneli.AdminBilgilerim>());
        }
        #endregion


    }
}
