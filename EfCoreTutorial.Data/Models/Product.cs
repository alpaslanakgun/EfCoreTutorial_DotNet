using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTutorial.Data.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public string  ProductName { get; set; }
        public decimal  UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

        public bool IsActive { get; set; }
        public Category Categories { get; set; }
        public Supplier Suppliers { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
