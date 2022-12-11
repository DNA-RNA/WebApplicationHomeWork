using Microsoft.EntityFrameworkCore;
using WebApplicationHomeWork.Models;

namespace WebApplicationHomeWork.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


            // public DbSet<Ogrenci> students { get; set; }
            public DbSet<Veli> conservator { get; set; }
            public DbSet<Okul> schools { get; set; }
            public DbSet<Bolum> departments { get; set; }

        
   
    }
}
