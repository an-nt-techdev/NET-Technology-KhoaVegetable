﻿using System;
using System.Collections.Generic;

namespace ASP.NET_CORE_Final2019.Models
{
    public partial class Khachhang
    {
        public int Email { get; set; }
        public string Ten { get; set; }
        public int? Sdt { get; set; }
        public string DiaChi { get; set; }
    }
}