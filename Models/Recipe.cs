using System.ComponentModel.DataAnnotations;

namespace Cinder.Models
{
  public class Ingredient 
  {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
     [Required]
    public string Amount { get; set; } = string.Empty;
  };
  public class Recipe
  {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public List<Ingredient> Ingredients { get; set; }
    public string Image { get; set; }
    

    /* public Recipe(string name, List<Ingredient> ingredients)
    {
      this.Name = name;
      this.Ingredients = ingredients;
      this.Image = string.Empty;
      
    } */
  }
}
