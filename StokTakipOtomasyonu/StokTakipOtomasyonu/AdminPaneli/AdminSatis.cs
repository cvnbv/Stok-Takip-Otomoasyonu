using StokTakipOtomasyonu.Business.Abstract;
using StokTakipOtomasyonu.Entities.Tables;
using StokTakipOtomasyonu.Entities.Utilities;
using StokTakipOtomasyonu.Mail;
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

namespace StokTakipOtomasyonu.AdminPaneli
{
    public partial class AdminSatis : Form
    {

        private IKullaniciServices _kullaniciServices;
        private ISepetServices _sepetServices;
        private IUrunServices _urunServices;
        private ISatisServices _satisServices;
        public AdminSatis(IKullaniciServices kullaniciServices,ISepetServices sepetServices,IUrunServices urunServices,ISatisServices satisServices)
        {
            _kullaniciServices = kullaniciServices;
            _satisServices = satisServices;
            _sepetServices = sepetServices;
            _urunServices = urunServices;
            InitializeComponent();
        }
        private void AdminSatis_Load(object sender, EventArgs e)
        {
            comboBox_musteri.Text = "Kullanıcı İsmi Seçiniz!";
            KullaniciComboDoldur();
            TumSatisListele();

        }

      
        private void KullaniciComboDoldur()
        {
            comboBox_musteri.DisplayMember = "Ad";
            comboBox_musteri.ValueMember = "Id";
            comboBox_musteri.DataSource = _kullaniciServices.GetAllMusteri();
        }
 
        private void comboBox_musteri_SelectedIndexChanged(object sender, EventArgs e)
        {

            var result = _kullaniciServices.GetAllMusteriSepeti(Convert.ToInt32(comboBox_musteri.SelectedValue));

            textBox_tckimlik.Text = result.TCKimlik;
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

        private void button1_Click(object sender, EventArgs e)
        {
            var result = _sepetServices.GetAllKullaniciyaAitOlan(Convert.ToInt32(comboBox_musteri.SelectedValue));

            dataGridView1.DataSource = result;
            DataGridStyle.DatagridviewSetting(dataGridView1);

            dataGridView1.Columns[0].Visible = false; //Id
            dataGridView1.Columns[1].HeaderText = "Barkod No"; //BarkodNo
            dataGridView1.Columns[2].HeaderText = "Urun Adı";//UrunAdı
            dataGridView1.Columns[3].Visible = false; //UserID
            dataGridView1.Columns[4].HeaderText = "Fiyat"; //Fiyat
            dataGridView1.Columns[5].HeaderText = "Miktar"; //Miktar
            dataGridView1.Columns[6].HeaderText = "Ağırlık Cinsi"; //Miktar Turu
            dataGridView1.Columns[7].HeaderText = "Tutar"; //Tutar

        }

        private void button_satis_Click(object sender, EventArgs e)
        {
            if (_sepetServices.GetAllKullaniciyaAitOlan(Convert.ToInt32(comboBox_musteri.SelectedValue)).Count == 0 )
            {
                MessageBox.Show("Müşterinin Sepeti Mevcut Değil!");
                return;
            }

            if (comboBox_musteri.SelectedValue !=null )
            {
              
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    //Sepette Bulunan Her Urun(satir ) tek tek Satışlar isimli ana satış tablosuna eklenilcek ve stoktan düşülücek satılan ürünler

                    Satislar satislar = new Satislar();
                    
                    satislar.BarkodNo = dataGridView1.Rows[i].Cells[1].Value.ToString();

                    var stoktakiUrunBarkod = _urunServices.GetBarkodNo(satislar.BarkodNo);


                    satislar.UrunAdi = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    satislar.Fiyat =Convert.ToDecimal( dataGridView1.Rows[i].Cells[4].Value);
                    satislar.UserID = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    satislar.Miktar = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                    stoktakiUrunBarkod.MiktarSayisi = stoktakiUrunBarkod.MiktarSayisi - satislar.Miktar; //satış gerçekleşirse Ana Stokta Bulunan Ürün Miktarı silinicek

                    if (stoktakiUrunBarkod.MiktarSayisi == 0)
                    {
                        MailGonderme.AdminMailGonderme mailGonderme = new MailGonderme.AdminMailGonderme();
                        string OnayBekliyor = $" {stoktakiUrunBarkod.BarkodNo}'lu {stoktakiUrunBarkod.UrunAdi} ürünü stokları tükenmiştir!";
                        string Baslik = "Stok Bitişi Bilgilendirme";
                        mailGonderme.AdminMesaj(Baslik, OnayBekliyor);
                    }

                    if ((stoktakiUrunBarkod.MiktarSayisi ) <0) //stoktaki ürünün altında ürün almaya kalkışılırsa
                    {
                        MessageBox.Show($"{satislar.BarkodNo} Barkod Numaralı {satislar.UrunAdi} ürünümüzün stoğu bitmiştir.");
                        return;
                    }

                    satislar.Tutar = Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
                    satislar.MiktarTuru = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    satislar.SatisiOnaylayanUserID = UserDetailBus.Id;
                    satislar.SatisYapilanTarih = DateTime.Now;

                    _urunServices.Update(stoktakiUrunBarkod); //AnaStok Güncelleniyor
                    _satisServices.Add(satislar); 
                    _sepetServices.Delete(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString())); //Sepetteki Ürünler satıldıktan sonra sepete siliniyor

                    MessageBox.Show("Satış İşlemi Başarıyla gerçekleşti");

                }

                TumSatisListele();

            }
            else
            {
                MessageBox.Show("Lütfen Bir Kullanıcı Seçiniz!");
            }
        
        }

        private void button_tumsatislar_Click(object sender, EventArgs e)
        {
            TumSatisListele();
        }

        private void TumSatisListele()
        {
            dataGridView1.DataSource = _satisServices.GetSatislarwithUser();
            dataGridView1.Columns[0].Visible = false; //ıd
            dataGridView1.Columns[1].Visible = false;//Satın Alan Userıd
            dataGridView1.Columns[9].Visible = false;//Satisi Ypan kullanıcı


            dataGridView1.Columns[2].HeaderText = "Satın Alan";
            dataGridView1.Columns[3].HeaderText = "Barkod No";
            dataGridView1.Columns[4].HeaderText = "Ürün Adı";
            dataGridView1.Columns[5].HeaderText = "Miktar";
            dataGridView1.Columns[6].HeaderText = "Ağırlık Cinsi";
            dataGridView1.Columns[7].HeaderText = "Fiyat";
            dataGridView1.Columns[8].HeaderText = "Tutar";
            dataGridView1.Columns[10].HeaderText = "Satış Onaylayan";
            dataGridView1.Columns[11].HeaderText = "Tarih";

            DataGridStyle.DatagridviewSetting(dataGridView1);
        }
    }
}
