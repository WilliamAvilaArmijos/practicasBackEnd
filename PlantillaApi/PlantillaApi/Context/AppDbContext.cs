using PlantillaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace PlantillaApi.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Usuarios> usuarios { get; set; }
    }
}
