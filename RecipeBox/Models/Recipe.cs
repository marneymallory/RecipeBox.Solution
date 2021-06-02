using System;
using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {
      CategoryRecipe = new HashSet<CategoryRecipe>();
    }
    public string Name {get; set;}
    public int RecipeId {get; set;}
    public int Rating {get; set;}
    public string Ingredient {get; set;}
    public virtual ApplicationUser User {get; set;}
    public virtual ICollection<CategoryRecipe> CategoryRecipe {get; set;}
  }
}