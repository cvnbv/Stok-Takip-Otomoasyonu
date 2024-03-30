using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Entities.Tables
{
    public class BeniUnutma
    {

        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Sifre { get; set; }
        public bool hatirla { get; set; }
        public string tc { get; set; }
    }
}
