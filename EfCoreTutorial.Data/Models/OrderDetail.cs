using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTutorial.Data.Models
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }
        public DateTime OrderDate  { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
