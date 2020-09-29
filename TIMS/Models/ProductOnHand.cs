﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TIMS.Models
{
    public class ProductOnHand
    {
        public int ProductOnHandId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OnHandCount { get; set; }
    }
}
