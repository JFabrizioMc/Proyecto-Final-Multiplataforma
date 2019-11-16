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