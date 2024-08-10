using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    //Class ismi tekil (Product), ilişkilendirelecek tabloda çoğul (Products)
    public class Product
    {
        public int ProductId { get; set; } //Primary key
        public int CategoryId { get; set; } //Foreign key
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
