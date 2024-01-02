using Microsoft.EntityFrameworkCore;
using UserKayitveGirisEFProje.Entity;

namespace UserKayitveGirisEFProje.DataAccess
{
    public class DatabaseContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Category> Categorys { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-1BH7EFE\\MSSQLSERVER01;Database=ArabaAlSatSitesi;Trusted_Connection=true;TrustServerCertificate=True");
        }
    }
}
