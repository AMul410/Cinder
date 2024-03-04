namespace Cinder.Models
{
  public record Ingredient(string name, int amount);
  public class Recipe
  {
    public int id { get; set; }
    public string name { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public string Image { get; set; }
  }
}
