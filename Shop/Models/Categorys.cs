using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Categorys
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Category_id { get; set; }
        public string Name { get; set; }
    }
}
