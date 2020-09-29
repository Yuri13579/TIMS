using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TIMS.Models
{
    public class ProductPrice
    {
        public int ProductPriceId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public double PriceTaxExcluded { get; set; }
    }
}
