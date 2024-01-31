using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lighten_2.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; } 
        public DateTime Date { get; set; }
        [Column ("Sherhler")]
        public string Comment { get; set; }
        public string Title { get; set; }   
    }
}
