using Microsoft.EntityFrameworkCore;

namespace RecipeVault.Data;
public class RecipeContext : DbContext
  {
        public RecipeContext(
            DbContextOptions options) : base(options)
        {
        }

        public DbSet<Recipe> recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

  }