using Microsoft.EntityFrameworkCore;

namespace CDFirstLibrary.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HPISNET;Initial Catalog=db_library2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

  

        public DbSet<Eserler> eserler { get; set; }
        public DbSet<Yazarlar> yazarlar { get; set; }
        public DbSet<Kategoriler> kategoriler { get; set; }
        public DbSet<Ülkeler> ülkeler { get; set; }


    }
}
