using StokTakipOtomasyonu.Business.Abstract;
using StokTakipOtomasyonu.Entities.Utilities;
using StokTakipOtomasyonu.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyonu.AdminPaneli
{
    public partial class AdminKullaniciOnay : Form
    {
        IKullaniciServices _kullaniciServices;
        public AdminKullaniciOnay(IKullaniciServices kullaniciServices)
        {
            _kullaniciServices = kullaniciServices;
            InitializeComponent();
        }


        private void AdminKullaniciOnay_Load(object sender, EventArgs e)
        {
            GridListele();

            dataGridView1.Columns[0].Visible = false; //Id

            dataGridView1.Columns[3].Visible = true; //RolID
            dataGridView1.Columns[3].HeaderText = "Rol"; //RolID

            dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı"; //KullaniciName

            dataGridView1.Columns[2].HeaderText = "Sifre"; //sifre
            dataGridView1.Columns[2].Visible = false; //sifre

            dataGridView1.Columns[4].HeaderText = "Telefon No"; //TelNo
            dataGridView1.Columns[4].Visible = false; //TelNo

            dataGridView1.Columns[5].HeaderText = "Mail"; //Mail
            dataGridView1.Columns[5].Visible = false; //Mail 

            dataGridView1.Columns[6].HeaderText = "Adres"; //Adres
            dataGridView1.Columns[6].Visible = false; //Adres

            dataGridView1.Columns[7].HeaderText = "T.C. Kimlik"; //tckimlik
            dataGridView1.Columns[7].Visible = false; //tckimlik

            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Profil Resmi"; //Resim

            dataGridView1.Columns[9].HeaderText = "Doğum Tarihi"; //dogum
            dataGridView1.Columns[9].Visible = false; //dogum

            dataGridView1.Columns[10].HeaderText = "Cinsiyet"; //Cinsiyet
            dataGridView1.Columns[10].Visible = false; //Cinsiyet

            dataGridView1.Columns[11].HeaderText = "Onay Durumu"; //Onayli

            DataGridStyle.DatagridviewSetting(dataGridView1);

            pictureBox1.Image = Image.FromFile(@"..\..\Resimler\user2.png");

        }

        private void GridListele()
        {
            dataGridView1.DataSource = _kullaniciServices.GetAllOnayBekleyenler();
        }

        int kullaniciID =0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                kullaniciID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                label_kullaniciAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                label_sifre.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                label_TelNo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                label_mail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                label1_adres.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                label1_tckimlik.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                if (dataGridView1.Rows[e.RowIndex].Cells[8].Value == null)
                {
                    pictureBox1.Image = Image.FromFile(@"..\..\Resimler\user1.png");

                }
                else if (dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString() == "")
                {
                    pictureBox1.Image = Image.FromFile(@"..\..\Resimler\user1.png");
                }
                else
                {

                    pictureBox1.Image = Image.FromFile(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
                }


                label_dogumtarihi.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                label_cinsiyet.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                label_onay.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();

                int rol = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (rol == 1)
                {
                    label_rol.Text = "Admin";
                }
                else if (rol == 2)
                {
                    label_rol.Text = "Müşteri";
                }
                else if (rol == 3)
                {
                    label_rol.Text = "Personel";
                }
                else
                {
                    label_rol.Text = "Rol Verilmesi Bekleniyor!";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Bir Seçim Yaptınız Lütfen Yeniden Deneyiniz!");
            }
            
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var guncellenicek = _kullaniciServices.GetById(kullaniciID);

            if (comboBox1.Text != "Rol Seçiniz" && comboBox2.Text !="Onay Belirleyiniz" && guncellenicek !=null)
            {
              
                if (comboBox1.Text == "Admin")
                {
                    guncellenicek.RolID = 1;
                }
                else if (comboBox1.Text == "Müşteri")
                {
                    guncellenicek.RolID = 2;

                }
                else if (comboBox1.Text =="Personel")
                {
                    guncellenicek.RolID = 3;

                }

                if (comboBox2.Text == "Onaylandı")
                {
                    guncellenicek.Onayli = true;
                }


                _kullaniciServices.Update(guncellenicek);

                GridListele();
              

                MailGonderme.MusteriMailGonderme mailGonderme = new MailGonderme.MusteriMailGonderme();

                string OnayBekliyor = label_kullaniciAdi.Text + " Başvurunuz Onaylandı artık sisteme giriş yapabilirsiniz!";
                string Baslik = "Stok Takip Otomasyonu Kayıt Onay Süreci";
                string mail = label_mail.Text;
                mailGonderme.Mesaj(Baslik, OnayBekliyor, mail);

                MessageBox.Show("Kullanıcı rol ve onay durumu güncellendi!");
                LabelTemizle();


            }
            else if (label_kullaniciAdi.Text =="")
            {
                MessageBox.Show("Kullanıcı Seçmelisiniz!");
            }
            else
            {
                MessageBox.Show("Lütfen Rol ve Onay Durumu Belirtiniz!");
            }
           
        }

        private void LabelTemizle()
        {
            label_kullaniciAdi.Text ="";
            label_sifre.Text = "";
            label_TelNo.Text = "";
            label_mail.Text = "";
            label1_adres.Text = "";
            label1_tckimlik.Text = "";
            label_dogumtarihi.Text ="";
            label_cinsiyet.Text = "";
            label_onay.Text = "";
            label_rol.Text = "";

            pictureBox1.Image = Image.FromFile(@"..\..\Resimler\user1.png");
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
    }
}
