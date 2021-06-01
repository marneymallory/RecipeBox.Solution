using Microsoft.EntityFrameworkCore;

namespace RecipeBox.Models
{
  public class RecipeBoxContext : DbContext
  {
    public virtual DbSet<Category> Categories {get; set;}
    public virtual DbSet<Recipe> Recipes {get; set;}
    public virtual DbSet<CategoryRecipe> CategoryRecipes {get; set;}
  public RecipeBoxContext(DbContextOptions options) : base(options){ }
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<CategoryRecipe>()
          .HasIndex(cr => new { cr.RecipeId, cr.CategoryId })
          .IsUnique();
    }
  }
}