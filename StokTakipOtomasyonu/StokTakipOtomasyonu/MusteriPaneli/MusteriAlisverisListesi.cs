using StokTakipOtomasyonu.Business.Abstract;
using StokTakipOtomasyonu.Entities.Tables;
using StokTakipOtomasyonu.Entities.Utilities;
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

namespace StokTakipOtomasyonu.MusteriPaneli
{
    public partial class MusteriAlisverisListesi : Form
    {
        private IUrunServices _urunServices;
        private IKategoriServices _kategoriServices;
        private IMarkaServices _markaServices;
        private ISepetServices _sepetServices;
        public MusteriAlisverisListesi(IUrunServices urunServices,IKategoriServices kategoriServices,IMarkaServices markaServices,ISepetServices sepetServices)
        {
            _urunServices = urunServices;
            _markaServices = markaServices;
            _kategoriServices = kategoriServices;
            _sepetServices = sepetServices;
            InitializeComponent();
        }

        private void MusteriAlisverisListesi_Load(object sender, EventArgs e)
        {
            KategoriComboDoldur();
            comboBox_kategori.Text = "Kategori Seçiniz!";
            comboBox_marka.Text = "Marka Seçiniz!";

            ListeleTumUrunler();


        }
        private void KategoriComboDoldur()
        {
            comboBox_kategori.DisplayMember = "KategoriAdi";
            comboBox_kategori.ValueMember = "Id";
            comboBox_kategori.DataSource = _kategoriServices.GetAll();
        }
        private void comboBox_kategori_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox_marka.DisplayMember = "MarkaAdi";
            comboBox_marka.ValueMember = "Id";
            comboBox_marka.DataSource = _markaServices.SeciliKategori(Convert.ToInt32(comboBox_kategori.SelectedValue));
            comboBox_marka.Text = "Marka Seçiniz!";
        }

        #region Ürün Arama İşlemleri
        int sayac = 0;
        DataGridViewCell ilkaranan;
        private void textBox_arama_TextChanged(object sender, EventArgs e)
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

        #endregion

 

        private void ListeleTumUrunler()
        {
            dataGridView1.DataSource = _urunServices.GetAllStoktakilerwithMarkaKategori();
            DataGridStyle.DatagridviewSetting(dataGridView1);

            dataGridView1.Columns[0].Visible = false; //Id
            dataGridView1.Columns[1].HeaderText = "Barkod No"; //BarkodNo
            dataGridView1.Columns[2].HeaderText = "Urun Adı"; //UrunAdi

            dataGridView1.Columns[3].HeaderText = "Marka Kod"; //MarkaID
            dataGridView1.Columns[3].Visible =false; //MarkaID

            dataGridView1.Columns[4].HeaderText = "Marka Adı "; //Marka Adı
            dataGridView1.Columns[5].HeaderText = "Ağırlık Cinsi "; //Marka Adı

            dataGridView1.Columns[6].HeaderText = "Tane Ağırlık"; //taneağırlık
            dataGridView1.Columns[7].HeaderText = "Stok"; //stok

            dataGridView1.Columns[8].HeaderText = "Fiyat"; //fiyat
            dataGridView1.Columns[9].Visible = false;//Kategoriıd
            dataGridView1.Columns[10].HeaderText = "Kategori Adı"; //Miktar
            dataGridView1.Columns[11].Visible = false; //resim
 
            dataGridView1.Columns[12].Visible = false; //resimyolu
            dataGridView1.Columns[13].Visible = false; //alış
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox_kategori.Text != "Kategori Seçiniz!" && comboBox_marka.Text != "Marka Seçiniz!")
            {
                dataGridView1.DataSource = _urunServices.Getistenilenfiltre(Convert.ToInt32(comboBox_kategori.SelectedValue), Convert.ToInt32(comboBox_marka.SelectedValue));

            }
            else
            {
                ListeleTumUrunler();
                MessageBox.Show("Lütfen Kategori ve Marka Seçiniz!");
            }
        }

        double satisFiyati = 0.00;
        string miktarTuru = "";
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;

            }
            textBox_barkodno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_urunadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            satisFiyati = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            miktarTuru = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            var resimyolu = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();

            if (resimyolu==null || resimyolu=="")
            {
                pictureBox1.Image = Image.FromFile(@"..\..\Resimler\urun2.png");

            }
            else
            {
                pictureBox1.Image = Image.FromFile(resimyolu);
            }
         
        }

        private void textBox_miktar_TextChanged(object sender, EventArgs e)
        {
            if (textBox_miktar.Text =="")
            {
                textBox_tutar.Text = "";
                return;
            }
            else
            {
                textBox_tutar.Text = (int.Parse(textBox_miktar.Text) * satisFiyati).ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListeleTumUrunler();
        }

        private void button_sepeteekle_Click(object sender, EventArgs e)
        {
            var bulunanUrun = _sepetServices.GetByBarkodNo(textBox_barkodno.Text);

            if (bulunanUrun != null) //sepette aynı barkodta ürün var ise üzerine ekleme yapılcıak
            {
                var soru = MessageBox.Show("Bu ürünü sepetinizde mevcut üzerine eklemek istiyor musunuz?", "Sepete Ekleme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (soru == DialogResult.OK)
                {
                    bulunanUrun.Miktar = bulunanUrun.Miktar + Convert.ToInt32(textBox_miktar.Text);
                    bulunanUrun.Tutar = bulunanUrun.Tutar + Convert.ToDecimal(textBox_tutar.Text);

                    _sepetServices.Update(bulunanUrun);


                   
                    FormTemizle();
                }

            }
            else//sepette aynı barkodta ürün yok ise eklenir
            {
                var result = MessageBox.Show("Bu ürünü sepetinize eklemek istiyor musunuz?", "Sepete Ekleme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Sepet sepet = new Sepet();

                    sepet.BarkodNo = textBox_barkodno.Text;
                    sepet.Fiyat = Convert.ToDecimal(satisFiyati);
                    sepet.Miktar = Convert.ToInt32(textBox_miktar.Text);
                    sepet.Tutar = Convert.ToDecimal(textBox_tutar.Text);
                    sepet.UrunAdi = textBox_urunadi.Text;
                    sepet.UserID = UserDetailBus.Id;
                    sepet.MiktarTuru = miktarTuru;

                    _sepetServices.Add(sepet);

                    FormTemizle();

                }

            }



        }

        private void FormTemizle()
        {
            textBox_miktar.Clear();
            textBox_tutar.Clear();
            textBox_urunadi.Clear();
            textBox_barkodno.Clear();
        }

        #region Pencere Boyutunun Kontrolü ve Logoyu Ortalama
        int boyutsayaci = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Font eski = this.Font;

            if (PencereDurumu.state == FormWindowState.Maximized)
            {
                if (boyutsayaci == 0)
                {
                    this.Font = new Font(eski.FontFamily, eski.Size + 4, eski.Style);
               
                    boyutsayaci++;

                    return;
                }

            }

            if (PencereDurumu.state == FormWindowState.Normal)
            {
                if (boyutsayaci == 1)
                {
                    this.Font = new Font(eski.FontFamily, eski.Size - 4, eski.Style);
                 
                    boyutsayaci--;

                    return;
                }
            }
        }

        #endregion
    }
}
