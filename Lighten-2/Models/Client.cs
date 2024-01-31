using System.ComponentModel.DataAnnotations.Schema;

namespace Lighten_2.Models
{
    public class Client
    {

        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Date { get; set; }
        [Column("Metn")]
        public string Desc { get; set; }
    }
}
