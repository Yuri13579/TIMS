using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TIMS.DTO
{
    public class ProductPortalDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double GrossWeight  { get; set; }
        public string SKU { get; set; }
        public double Barcode { get; set; }
        public int MPE { get; set; }
        public string Photo { get; set; }
        public string Unit { get; set; }
        public string Category { get; set; }
        public string Trademark { get; set; }
        public int OnHand { get; set; }
        public double Price { get; set; }
        
    }
}
