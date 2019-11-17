using Microsoft.AspNetCore.Identity;
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
                            Nombre = "CPU"
                            });
            modelBuilder.Entity<Categorias>()
                        .HasData(new Categorias {
                            Id = 2, 
                            Nombre = "Pantallas"
                            });
            modelBuilder.Entity<Categorias>()
                        .HasData(new Categorias {
                            Id = 3, 
                            Nombre = "Audifonos"
                            });
            modelBuilder.Entity<Categorias>()
                        .HasData(new Categorias {
                            Id = 4, 
                            Nombre = "Celulares"
                            });
            modelBuilder.Entity<Categorias>()
                        .HasData(new Categorias {
                            Id = 5, 
                            Nombre = "Perifericos"
                            });

            modelBuilder.Entity<Productos>()
                        .HasData(new Productos{
                            Id = 1,
                            Nombre="PC GAMER INTEL CORE I7-9700 RAM 16GB 2TB + SSD 120GB VIDEO 4GB",
                            Foto="https://http2.mlstatic.com/pc-gamer-core-i7-4ghz-16g-ram-gtx-1070-700w-ssd-1tera-D_NQ_NP_983679-MPE31254597571_062019-Q.jpg",
                            CategoriaId = 1,
                            PrecioUnit=3935.00M,
                            Descripcion="Es una buena pc para los juegos de ultima generacion"
                        });
            modelBuilder.Entity<IdentityRole>()
            .HasData(new IdentityRole{
                Id = "ROLE_ID",
                Name = "admin",
                NormalizedName = "admin"

            });
            var hasher = new PasswordHasher<IdentityUser>();
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser{
                Id="ADMIN_ID",
                UserName="admin@admin.com",
                NormalizedUserName="admin@admin.com",
                Email="admin@admin.com",
                NormalizedEmail="admin@admin.com",
                EmailConfirmed=true,
                PasswordHash=hasher.HashPassword(null,"1234567"),
                SecurityStamp = string.Empty
             });

             modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>{
                 RoleId = "ROLE_ID",
                 UserId = "ADMIN_ID"

             });
             
            

            }

        
    }
}