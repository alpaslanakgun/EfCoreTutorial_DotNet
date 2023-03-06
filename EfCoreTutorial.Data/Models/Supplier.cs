using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTutorial.Data.Models
{   public class Supplier
    {

        public int ID  { get; set; }
        public string  CompanyName   { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
