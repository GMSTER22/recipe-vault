using Microsoft.EntityFrameworkCore;

namespace RecipeVault.Data
{
    public class RecipeContext : DbContext
    {
        public RecipeContext (DbContextOptions<RecipeContext> options)
            : base(options)
        {
        }

        public DbSet<RecipeVault.Models.Recipes> Recipes { get; set; }
    }
}