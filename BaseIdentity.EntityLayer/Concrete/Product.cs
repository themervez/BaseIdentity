using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseIdentity.EntityLayer.Concrete
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Stock { get; set; }
        public int CategoryID { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
        
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
    }
}
