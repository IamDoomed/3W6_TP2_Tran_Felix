using Microsoft.EntityFrameworkCore;

namespace NutriVie.Models.Data
{
    public class NutriVieDbContext : DbContext
    {
        public NutriVieDbContext(DbContextOptions<NutriVieDbContext> options) : base(options) { }

        public DbSet<Aliment> Aliments { get; set; }
        public DbSet<AlimentRecette> AlimentRecettes { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Recette> Recettes { get; set; }

    }
}
