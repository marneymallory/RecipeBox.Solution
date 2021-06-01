using System.Collections.Generic;
namespace RecipeBox.Models
{
  public class Category
  {
    public Category()
    {
      CategoryRecipes = new HashSet<CategoryRecipe>();
    }

  public string Name {get; set;}
  public int CategoryId {get; set;}
  public virtual ICollection<CategoryRecipe> CategoryRecipes {get; set;}
  }
}