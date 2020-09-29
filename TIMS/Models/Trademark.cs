using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TIMS.Models
{
    public class Trademark
    {
        public int TrademarkId { get; set; }
        public string TrademarkName { get; set; }
        public ICollection<ProductTrademark> ProductTrademarks { get; set; }
    }
}
