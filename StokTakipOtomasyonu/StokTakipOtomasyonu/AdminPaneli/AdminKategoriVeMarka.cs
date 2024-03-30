using StokTakipOtomasyonu.Business.Abstract;
using StokTakipOtomasyonu.DataAccessLayer.ComplexType;
using StokTakipOtomasyonu.Entities.Tables;
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
    public partial class AdminKategoriVeMarka : Form
    {
        private IKategoriServices _kategoriServices;
        private IMarkaServices _markaSevices;
        private IUrunServices _urunServices;
        public AdminKategoriVeMarka(IKategoriServices kategoriServices,IMarkaServices markaServices,IUrunServices urunServices)
        {
            _markaSevices = markaServices;
            _kategoriServices = kategoriServices;
            _urunServices = urunServices;
            InitializeComponent();
        }

        private void AdminKategoriVeMarka_Load(object sender, EventArgs e)
        {
            KategoriListele();
            MarkaListele();
            KategoriComboDoldur();

            dataGridView1.Columns[0].HeaderText = "Kategori Id";
            dataGridView1.Columns[1].HeaderText = "Kategori Adı";
            DataGridStyle.DatagridviewSetting(dataGridView1);

            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[1].HeaderText = "Marka Adı";
            dataGridView2.Columns[3].HeaderText = "Kategori Adı";
            
            DataGridStyle.DatagridviewSetting(dataGridView2);


        }

        private void KategoriComboDoldur()
        {


            comboBox1.DisplayMember = "KategoriAdi";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource  = _kategoriServices.GetAll();

        }

        private void MarkaListele()
        {
          
            dataGridView2.DataSource = _markaSevices.GetAllMarkawithKategori();
        }

        private void KategoriListele()
        {
            dataGridView1.DataSource = _kategoriServices.GetAll();
            dataGridView1.Columns[0].Visible = false;
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();

            if (_kategoriServices.varMi(textBox_kategoriName.Text)) //True Dönerse böyle bir kayıt yok demektir.
            {
               kategori.KategoriAdi = textBox_kategoriName.Text;

                var result = MessageBox.Show("Bu kategoriyi Eklemek istediğinize emin misiniz?", "Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    _kategoriServices.Add(kategori);
                    textBox_kategoriName.Clear();

                }

            }
            else
            {
                MessageBox.Show("Böyle Bir Kategori Bulunmaktadır Lütfen Farklı Bir Kategori Adı Giriniz!");

            }


            KategoriListele();
            KategoriComboDoldur();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
          
                var result = MessageBox.Show("Bu kategoriyi silmek istediğinize emin misiniz \n Silindiğinde Bu Kategoriye Ait Markalar ve Ürünlerde Veritabanından Kaldırılıcak?","Silme",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

                 if (result == DialogResult.OK)
                 {
                      var KategoriyeAitMarkalar = _markaSevices.SeciliKategori(KategoriID);
                      var KategoriyeAitUrunler = _urunServices.GetKategoriID(KategoriID);

                      _urunServices.DeleteRange(KategoriyeAitUrunler);
                      _markaSevices.DeleteRanger(KategoriyeAitMarkalar);
                     _kategoriServices.Delete(KategoriID);
                     textBox_kategoriName.Clear();

                MessageBox.Show("Kategori, Kategoriye ait markalar ve ürünler başarıyla silindi!");
              
                 }
                   KategoriListele();
            KategoriComboDoldur();

        }
        int KategoriID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            KategoriID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBox_kategoriName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {

            var guncellenecek = _kategoriServices.GetById(KategoriID);

            var result = MessageBox.Show("Bu kategoriyi güncellemek istediğinize emin misiniz?", "Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                guncellenecek.KategoriAdi = textBox_kategoriName.Text;
                _kategoriServices.Update(guncellenecek);

            }
            KategoriListele();
            KategoriComboDoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Marka marka = new Marka();
            int kategoriID = Convert.ToInt32(comboBox1.SelectedValue);
            if (_markaSevices.VarMi(textBox_markaAdi.Text , kategoriID)) //True Dönerse böyle bir kayıt yok demektir.
            {
                marka.MarkaAdi = textBox_markaAdi.Text;
                marka.KategoriID =kategoriID;

                var result = MessageBox.Show("Bu Markayı Eklemek istediğinize emin misiniz?", "Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    _markaSevices.Add(marka);
                    MarkaListele();
                }

            }
            else
            {
                MessageBox.Show("Böyle Bir Marka  Bulunmaktadır Lütfen Farklı Bir Kategori Adı Giriniz!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Bu Markayı silmek istediğinize emin misiniz?", "Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                _markaSevices.Delete(markaID);
                textBox_markaAdi.Clear();
                

            }
            MarkaListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var guncellenecek = _markaSevices.GetById(markaID);

            var result = MessageBox.Show("Bu Markayı güncellemek istediğinize emin misiniz?", "Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                guncellenecek.MarkaAdi = textBox_markaAdi.Text;
                guncellenecek.KategoriID =Convert.ToInt32( comboBox1.SelectedValue);
                _markaSevices.Update(guncellenecek);

            }
            MarkaListele();
            KategoriComboDoldur();
        }

        int markaID = 0;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex ==-1)
            {
                return;
            }

            markaID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            textBox_markaAdi.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        #region DataGridView İçerisnde Arama Yapma
        int sayac = 0;
        DataGridViewCell ilkaranan;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string aranan = textBox1.Text.Trim().ToUpper();

        
            for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView2.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {


                            if (cell.Value.ToString().ToUpper() == aranan)
                            {
                              

                                if(sayac == 0)
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

        #endregion


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
