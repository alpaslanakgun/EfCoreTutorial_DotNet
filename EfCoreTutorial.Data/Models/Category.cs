using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTutorial.Data.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName  { get; set; }
        public string  Description { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
