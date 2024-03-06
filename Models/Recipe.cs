namespace Cinder.Models
{
  public record Ingredient(string name, int amount);
  public class Recipe
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public string Image { get; set; }
    private static int _id = 0;

    public Recipe(string name, List<Ingredient> ingredients)
    {
      this.Name = name;
      this.Ingredients = ingredients;
      this.Image = string.Empty;
      this.Id = _id++;
    }
  }
}
