using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class Products
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Product_id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; } 
        public string Info { get; set; }
        [ForeignKey("Categorys")]
        public int Category_id { get; set; }
        //public Categorys Categorys { get; set; }
        [ForeignKey("Brands")]
        public int Brand_id { get; set; }
        //public Brands Brands { get; set; }
    }
}
