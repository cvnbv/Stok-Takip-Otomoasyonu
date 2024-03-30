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
    public partial class AdminAnaSayfa : Form
    {
        public AdminAnaSayfa()
        {
            InitializeComponent();
        }

        private void AdminAnaSayfa_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\Resimler\Wıxı.png");

      
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
                    pictureBox1.Location =new Point( this.Width/2 -250 , this.Height/2 -250);
                    boyutsayaci++;

                    return;
                }

            }

            if (PencereDurumu.state == FormWindowState.Normal)
            {
                if (boyutsayaci == 1)
                {
                    this.Font = new Font(eski.FontFamily, eski.Size - 5, eski.Style);
                    pictureBox1.Location = new Point(this.Width / 2 - 250, this.Height / 2 - 260);
                    boyutsayaci--;

                    return;
                }
            }
        }

        #endregion
    }
}
