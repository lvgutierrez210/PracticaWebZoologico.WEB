using Microsoft.EntityFrameworkCore;
using PracticaWebZoologico.WEB.Models.Entities;

namespace PracticaWebZoologico.WEB.Models.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):
            base(options)
        {

        }

        public DbSet<Animal> Animales { get; set; } 
        public DbSet<ColorAnimal> ColoresAnimales { get; set; }  
        public DbSet<EspecieAnimal>EspeciesAnimales { get; set; }   

    }
}
