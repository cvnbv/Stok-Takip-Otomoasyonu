﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyonu.Entities.Tables
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }
        public string RolName { get; set; }

    }
}
