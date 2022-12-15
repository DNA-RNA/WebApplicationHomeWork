using Microsoft.EntityFrameworkCore;
using WebApplicationHomeWork.Models;

namespace WebApplicationHomeWork.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


            public DbSet<Ogrenci> students { get; set; }
            public DbSet<Veli> conservator { get; set; }
            public DbSet<Okul> schools { get; set; }
            public DbSet<Bolum> departments { get; set; }
            public DbSet<Duyuru> announcements { get; set; }
            public DbSet<Oda> rooms { get; set; }
            public DbSet<Yatak> beds { get; set; }
            public DbSet<Yemek> foods { get; set; }
            public DbSet<Odeme> payments { get; set; }
            public DbSet<OgrenciSorun> studentproblems{ get; set; }
            public DbSet<Sorun> problems{ get; set; }
            public DbSet<Admin> admins { get; set; }




    }
}
