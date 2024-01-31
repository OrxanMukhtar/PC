using Lighten_2.Models;

namespace Lighten_2.Views
{
    public class HomeViewModel
    {

        public List<Products> Products { get; set; }
        public About About { get; set; }    
        public List <Blog> Blogs { get; set; }
        public Client Client { get; set; }
    }
}
