using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lighten_2.Models
{
    public class ChooseUs
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [MinLength(1)]
        //[Column("Basliq")]
        public string Title { get; set; }   
        public string Uptitle { get; set; }
        public string Icon { get; set; }


    }
}
