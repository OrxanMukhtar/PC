using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lighten_2.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public int Title { get; set; }
       

        [Column("Qiymet")]
        public int Price { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }  


    }
}
