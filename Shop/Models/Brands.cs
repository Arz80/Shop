using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Brands
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Brand_id { get; set; }
        public string Name { get; set; }
    }
}
