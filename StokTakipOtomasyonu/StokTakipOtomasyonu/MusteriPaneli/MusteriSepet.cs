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

namespace StokTakipOtomasyonu.MusteriPaneli
{
    public partial class MusteriSepet : Form
    {
        private ISepetServices _sepetServices;
        private IKullaniciServices _kullaniciServices;
        private IUrunServices _urunServices;
        private ISatisServices _satisServices;
        public MusteriSepet(ISepetServices sepetServices,IKullaniciServices kullaniciServices,IUrunServices urunServices,ISatisServices satisServices)
        {
            _urunServices = urunServices;
            _satisServices = satisServices;
            _sepetServices = sepetServices;
            _kullaniciServices = kullaniciServices;
            InitializeComponent();
        }

        private void MusteriSepet_Load(object sender, EventArgs e)
        {

            if (UserDetailBus.RolID ==1 || UserDetailBus.RolID == 3)  //admin ve personel ise işlemler gözükücek
            {
                panel_sepetonay.Visible = false;
                panel_satis.Visible = true;
                panel_satisyapılcıak.Visible = true;
                DoldurMusteriComboDoldur();
            }


            if (UserDetailBus.RolID == 2) //giriş yapan kullanıcı ise 
            {
                panel_sepetonay.Visible = true;
                panel_satis.Visible = false;
                panel_satisyapılcıak.Visible = false;
            }


            SepetListele();
            DataGridStyle.DatagridviewSetting(dataGridView1);

            dataGridView1.Columns[0].Visible = false; //Id
            dataGridView1.Columns[1].HeaderText = "Barkod No"; //BarkodNo
            dataGridView1.Columns[2].HeaderText = "Urun Adı";//UrunAdı
            dataGridView1.Columns[3].Visible = false; //UserID
            dataGridView1.Columns[4].HeaderText = "Fiyat"; //Fiyat
            dataGridView1.Columns[5].HeaderText = "Miktar"; //Miktar
            dataGridView1.Columns[6].HeaderText = "Ağırlık Cinsi"; //Miktar Turu
            dataGridView1.Columns[7].HeaderText = "Tutar"; //Tutar
            DataGridTutarLarıToplama();

        }

        private void DoldurMusteriComboDoldur()
        {
            comboBox_satisyap.DisplayMember = "KullaniciName";
            comboBox_satisyap.ValueMember = "Id";
            comboBox_satisyap.DataSource = _kullaniciServices.GetAllMusteri();
        }

        private void DataGridTutarLarıToplama()
        {
            //Sepetteki Ürünlerin Toplam Fiyatının Hesaplanması
            double toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
            }
            textBox1.Text = toplam.ToString();
        }

        private void SepetListele()
        {
            dataGridView1.DataSource = _sepetServices.GetAllKullaniciyaAitOlan(UserDetailBus.Id);
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


        string BarkodNo = "";
        string MiktartTuru = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;

            }
            BarkodNo = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_barkodno.Text = BarkodNo;
            textBox_urunadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_miktar.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox_tutar.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            MiktartTuru = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void button_sepettenCikar_Click(object sender, EventArgs e)
        {
            var urun = _sepetServices.GetByBarkodNo(BarkodNo);

            if (urun !=null)
            {
                var soru=  MessageBox.Show($"{textBox_urunadi.Text } isimli ürünü sepetinizden çıkarmak istiyor musunuz?", "Sepet işlemleri", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (soru == DialogResult.OK)
                {
                   
                    _sepetServices.Delete(urun.Id);
                    SepetListele();
                    DataGridTutarLarıToplama();
                    FormTemizle();

                }

            }
            else
            {
                MessageBox.Show("Lütfen Bir Ürün Seçiniz!");
            }
        }

        private void button2_Click(object sender, EventArgs e)//sepetten ürün çıkartmak istersek
        {
            var urun = _sepetServices.GetByBarkodNo(BarkodNo); 

            if (urun != null)
            {
                var soru = MessageBox.Show($"{textBox_urunadi.Text } isimli ürününüzden {textBox_miktar.Text} {MiktartTuru} sepetinizden çıkarmak istiyor musunuz?", "Sepet işlemleri", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (soru == DialogResult.OK)
                {
                    urun.Miktar = urun.Miktar - Convert.ToInt32(textBox_miktar.Text);

                    if (urun.Miktar <= 0)      //sepetteki ürün 0 ın altına inerse sepetten çıkıcak
                    {
                       
                        _sepetServices.Delete(urun.Id);
                        
                        SepetListele();
                        DataGridTutarLarıToplama();
                        FormTemizle();
                  
                        return;
                    }
                    
                    urun.Tutar = urun.Miktar * urun.Fiyat;
                    _sepetServices.Update(urun);
               
                    SepetListele();
                    DataGridTutarLarıToplama();
                    FormTemizle();
                    

                }

            }
            else
            {
                MessageBox.Show("Lütfen Bir Ürün Seçiniz!");
            }
        }

        private void FormTemizle()
        {
            textBox_miktar.Clear();
            textBox_tutar.Clear();
            textBox_urunadi.Clear();
            textBox_barkodno.Clear();
        }

        private void textBox_miktar_TextChanged(object sender, EventArgs e)
        {
            var urun = _sepetServices.GetByBarkodNo(BarkodNo);

            if (textBox_miktar.Text !="")
            {
                textBox_tutar.Text = (urun.Fiyat * Convert.ToDecimal(textBox_miktar.Text)).ToString();
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e) //Müşteri ise personele ve ya admine mail gönderilmesi için
        {
            MailGonderme.MusteriMailGonderme mailGonderme = new MailGonderme.MusteriMailGonderme();
            string OnayBekliyor = $"{UserDetailBus.KullaniciName} sepet talebiniz onay sürecine alınmıştır.";
            string Baslik = "Sepet Onaylanma Süreci Bilgilendirme";
            string mail = UserDetailBus.Mail;
            mailGonderme.Mesaj(Baslik, OnayBekliyor, mail);

            MailGonderme.PersonelMailGonderme personelmailGonderme = new MailGonderme.PersonelMailGonderme();
            string OnayBekliyor1 = $"{UserDetailBus.KullaniciName} sepeti için onay bekliyor!"; ;
            string Baslik1= "Sepet Onay";
          
            personelmailGonderme.PersonelMesaj(Baslik1, OnayBekliyor1);

            MessageBox.Show("Sepet Onay Sürecine Alındı!");

        }

        private void button_satisYap_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count ==0)//Personelin veya Adminin Sepeti boş ise satış işlemine girmeden uyarı vericek
            {
                MessageBox.Show("Sepetiniz Boş Olduğundan Bu İşlem Gerçekleştirilemiyor?", "Satış", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;

            }

            var soru = MessageBox.Show("Satış Gerçekleştirilsin Mi?", "Satış", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (soru == DialogResult.OK)
            {
                if (comboBox_satisyap.SelectedValue != null)
                {

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {

                        //Sepette Bulunan Her Urun(satir ) tek tek Satışlar isimli ana satış tablosuna eklenilcek ve stoktan düşülücek satılan ürünler

                        Satislar satislar = new Satislar();

                        satislar.BarkodNo = dataGridView1.Rows[i].Cells[1].Value.ToString();

                        var stoktakiUrunBarkod = _urunServices.GetBarkodNo(satislar.BarkodNo);


                        satislar.UrunAdi = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        satislar.Fiyat = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                        satislar.UserID =Convert.ToInt32( comboBox_satisyap.SelectedValue);
                        satislar.Miktar = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                        stoktakiUrunBarkod.MiktarSayisi = stoktakiUrunBarkod.MiktarSayisi - satislar.Miktar; //satış gerçekleşirse Ana Stokta Bulunan Ürün Miktarı silinicek

                        if (stoktakiUrunBarkod.MiktarSayisi  < 0) //stoktaki ürünün altında ürün almaya kalkışılırsa
                        {
                            MessageBox.Show($"{satislar.BarkodNo} Barkod Numaralı {satislar.UrunAdi} ürünümüzün stoğu bitmiştir.");
                            //Stok biterse Adminlere mail Gitmeli
                            return;
                        }

                        satislar.Tutar = Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
                        satislar.MiktarTuru = dataGridView1.Rows[i].Cells[6].Value.ToString();
                        satislar.SatisiOnaylayanUserID = UserDetailBus.Id;
                        satislar.SatisYapilanTarih = DateTime.Now;

                        _urunServices.Update(stoktakiUrunBarkod); //AnaStok Güncelleniyor
                        _satisServices.Add(satislar);
                        _sepetServices.Delete(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString())); //Sepetteki Ürünler satıldıktan sonra sepete siliniyor

                 
                    

                    }

                    var _satisyapilanKulanici = _kullaniciServices.GetById(Convert.ToInt32(comboBox_satisyap.SelectedValue));
                    MailGonderme.MusteriMailGonderme mailGonderme = new MailGonderme.MusteriMailGonderme();
                    string OnayBekliyor = $" {_satisyapilanKulanici.KullaniciName} sepet talebiniz onay sürecine alınmıştır.";
                    string Baslik = "Sepet Onaylanma Süreci Bilgilendirme";
                    string mail = _satisyapilanKulanici.Mail;
                    mailGonderme.Mesaj(Baslik, OnayBekliyor, mail);

                    SepetListele();

                    MessageBox.Show("Satış İşlemi Başarıyla Gerçekleşti");
                }

            }

        }
    }
}
