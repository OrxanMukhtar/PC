using Lighten_2.Models;
using Microsoft.EntityFrameworkCore;

namespace Lighten_2.Data

{
    public class Lighten_2DbContext:DbContext
    {
        public Lighten_2DbContext(DbContextOptions<Lighten_2DbContext>options):base(options)
        {
            
        }
        public DbSet <About> About { get; set; }
        public DbSet <Blog> Blog { get; set; }
        public DbSet <ChooseUs> ChooseUs { get; set; }
        public DbSet  <Client> Client { get; set; }
        
        public DbSet  <Proces> Proces { get; set; }
        public DbSet  < Products> Products { get; set; }

    }
}
