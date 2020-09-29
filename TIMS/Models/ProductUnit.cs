using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TIMS.Models
{
    public class ProductUnit
    {
        public int ProductUnitId { get; set; }
        public string UnitName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
