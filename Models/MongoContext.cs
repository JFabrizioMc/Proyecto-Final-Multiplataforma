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
    }
}