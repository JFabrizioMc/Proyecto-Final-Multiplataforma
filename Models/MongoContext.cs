using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_Final_Multiplataforma.Models
{
    public class MongoContext : IdentityDbContext
    {
         public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public MongoContext(DbContextOptions<MongoContext> o) : base(o) {
        }
            protected override void OnModelCreating(ModelBuilder modelBuilder){

            base.OnModelCreating(modelBuilder);
             modelBuilder.Entity<Categorias>()
                        .HasData(new Categorias {
                            Id = 1, 
                            Nombre = "Teclados"
                            });
            modelBuilder.Entity<Categorias>()
                        .HasData(new Categorias {
                            Id = 2, 
                            Nombre = "Audifonos"
                            });
            modelBuilder.Entity<Categorias>()
                        .HasData(new Categorias {
                            Id = 3, 
                            Nombre = "Mouses"
                            });

            }

        
    }
}