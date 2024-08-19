﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CUKCUK.NGHIA.Core.DTOs
{
    public class SinglePageData
    {
        public SinglePageData() { }

        public int TotalPage { get; set; }

        public int TotalRecord { get; set; }

        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        public object? Data { get; set; }
    }
}
