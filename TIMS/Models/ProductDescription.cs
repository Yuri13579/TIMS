using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TIMS.Models
{
    public class ProductDescription
    {
        public int ProductDescriptionId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public double GrossWeight { get; set; }
        [Index(IsUnique = true)]
        public ulong Barcode { get; set; }
        public int MPE { get; set; }
        public string SKU { get; set; }

    }
}
