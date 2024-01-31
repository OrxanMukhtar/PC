using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lighten_2.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public int Title { get; set; }
        [MaxLength(200)]
        [Column("Metn")]
        public int UpTitle { get; set; }
       
    }
}
