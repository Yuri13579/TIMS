using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TIMS.Models
{
    public class ProductTrademark
    {
        public int ProductTrademarkId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int TrademarkId { get; set; }
        public Trademark Trademark { get; set; }
    }
}
