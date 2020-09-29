using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TIMS.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public ProductDescription ProductDescription { get; set; }
        public ProductImage ProductImage { get; set; }
        public int ProductUnitId { get; set; }
        public ProductUnit ProductUnit { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<ProductTrademark> ProductTrademarks { get; set; }
        public ProductOnHand ProductOnHand { get; set; }
        public ProductPrice ProductPrice { get; set; }
    }

}
