using StokTakipOtomasyonu.Business.Abstract;
using StokTakipOtomasyonu.Entities.Utilities;
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
    public partial class AdminPersonel : Form
    {
        private IKullaniciServices _kullaniciServices;
        public AdminPersonel(IKullaniciServices kullaniciServices)
        {
            _kullaniciServices = kullaniciServices;
            InitializeComponent();
        }
        
        private void AdminPersonel_Load(object sender, EventArgs e)
        {
            PersonelListele();

         
         
            dataGridView1.Columns[0].Visible = false; //Id
            dataGridView1.Columns[3].Visible = false; //RolID

            dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı"; //KullaniciName
            dataGridView1.Columns[2].HeaderText = "Sifre"; //sifre
            dataGridView1.Columns[4].HeaderText = "Telefon No"; //TelNo
            dataGridView1.Columns[5].HeaderText = "Mail"; //Mail
            dataGridView1.Columns[6].HeaderText = "Adres"; //Adres
            dataGridView1.Columns[7].HeaderText = "T.C. Kimlik"; //tckimlik

            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Profil Resmi"; //Resim


            dataGridView1.Columns[9].HeaderText = "Doğum Tarihi"; //dogum
            dataGridView1.Columns[10].HeaderText = "Cinsiyet"; //Cinsiyet
            dataGridView1.Columns[11].HeaderText = "Onay Durumu"; //Onayli


            DataGridStyle.DatagridviewSetting(dataGridView1);

        }

        private void PersonelListele()
        {
            dataGridView1.DataSource = _kullaniciServices.GetAllPersonel();
        }

        int sayac = 0;
        DataGridViewCell ilkaranan;
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            string aranan = textBox_arama.Text.Trim().ToUpper();


            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {


                            if (cell.Value.ToString().ToUpper() == aranan)
                            {


                                if (sayac == 0)
                                {
                                    if (ilkaranan != null)
                                    {
                                        ilkaranan.Style.BackColor = Color.Black;
                                    }

                                    cell.Style.BackColor = Color.Red;
                                    ilkaranan = cell;
                                    sayac++;
                                    return;
                                }

                                if (sayac == 1)
                                {
                                    ilkaranan.Style.BackColor = Color.Black;
                                    cell.Style.BackColor = Color.Red;
                                    ilkaranan = cell;
                                    sayac = 0;
                                }
                            }
                        }
                    }
                }
            }
        }
        int KulaniciID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KulaniciID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                textBox_kullaniciAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_sifre.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_telno.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox_mail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox_adres.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox_tc.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();



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


                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[9].Value);

                string cinsiyet = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

                if (cinsiyet == "Erkek")
                {
                    radioButton_erkek.Checked = true;
                }
                else if (cinsiyet == "Kadın")
                {
                    radioButton_kadin.Checked = true;
                }
                else
                {
                    radioButton_diger.Checked = true;
                }



                bool onaydurumu = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[11].Value);

                if (onaydurumu == true)
                {
                    comboBox1.Text = "Onaylandı";
                }
                else
                {
                    comboBox1.Text = "Onaylanmadı";
                }

                int rol = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

                if (rol == 1)
                {
                    comboBox2.Text = "Admin";
                }
                else if (rol == 2)
                {
                    comboBox2.Text = "Müşteri";
                }
                else
                {
                    comboBox2.Text = "Personel";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Bir İşlem Gerçekleştirdiniz Lütfen Yeniden Deneyiniz!");
            }
          

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            var guncellenicek = _kullaniciServices.GetById(KulaniciID);

            guncellenicek.KullaniciName = textBox_kullaniciAdi.Text;
            guncellenicek.KullaniciPassword = textBox_sifre.Text;
            guncellenicek.TelNo = textBox_telno.Text;
            guncellenicek.Mail = textBox_mail.Text;
            guncellenicek.Adres = textBox_adres.Text;
            guncellenicek.TCKimlik = textBox_tc.Text;
            guncellenicek.Dogumtarihi =dateTimePicker1.Value;

            if (radioButton_erkek.Checked)
            {
                guncellenicek.Cinsiyet = "Erkek";

            }
            else if (radioButton_kadin.Checked)
            {
                guncellenicek.Cinsiyet = "Kadın";

            }
            else if (radioButton_diger.Checked)
            {
                guncellenicek.Cinsiyet = "Diğer";

            }

            if (comboBox1.Text == "Onaylandı")
            {
                guncellenicek.Onayli = true;
            }
            else if (comboBox1.Text == "Onaylanmadı")
            {
                guncellenicek.Onayli = false;
            }


            if (comboBox2.Text == "Admin")
            {
                guncellenicek.RolID = 1;

            }
            else if (comboBox2.Text == "Müşteri")
            {
                guncellenicek.RolID = 2;

            }
            else if (comboBox2.Text == "Personel")
            {
                guncellenicek.RolID = 3;

            }


            var result = MessageBox.Show("Personeli güncellemek istediğinize emin misiniz?", "Personel Güncelleme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(result == DialogResult.OK)
            {
                _kullaniciServices.Update(guncellenicek);
                PersonelListele();
            }


        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Personeli Silmek istediğinize emin misiniz?", "Personel Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                _kullaniciServices.Delete(KulaniciID);
                PersonelListele();
                FormTemizle();
            }

         
        }

        private void FormTemizle()
        {
            textBox_kullaniciAdi.Clear();
            textBox_sifre.Clear();
            textBox_telno.Clear();
            textBox_mail.Clear();
            textBox_adres.Clear();
            textBox_arama.Clear();
            textBox_tc.Clear();
            comboBox1.Text ="Onay Durumu Belirleyiniz!";
            comboBox2.Text = "Rol Belirleyiniz!";
            dateTimePicker1.Value = DateTime.Now;
            radioButton_diger.Checked = false;
            radioButton_erkek.Checked = false;
            radioButton_kadin.Checked = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        #region Pencere Boyutunun Kontrolü
        int boyutsayaci = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Font eski = this.Font;

            if (PencereDurumu.state == FormWindowState.Maximized)
            {
                if (boyutsayaci ==0)
                {
                    this.Font = new Font(eski.FontFamily, eski.Size + 5, eski.Style);
                    boyutsayaci++;

                    return;
                }
                
            }
           
            if(PencereDurumu.state == FormWindowState.Normal)
            {
                if (boyutsayaci == 1)
                {
                    this.Font = new Font(eski.FontFamily, eski.Size -5, eski.Style);
                    boyutsayaci--;

                    return;
                }
            }
        }

        #endregion
    }
}
