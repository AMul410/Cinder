using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace Cinder.Models
{
  public class User
  {
    // Static -> Existiert in der Klasse, nicht der Instanz!
   
    public int Id { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
    public bool IsVegan { get; set; }
    public string Occupation { get; set; }
    public List<Recipe> UserRecipes { get; set; } 
    // public List<User> CachedUsers { get; set; } = new List<User>();

    //public User(string username, string password)
    //this.UserRecipes = new List<Recipe>();
    //{
    //this.UserRecipes = new List<Recipe>();
    //  this.Username = username;
     //this.UserRecipes = new List<Recipe>();
    // this.Password = password;
     //this.UserRecipes = new List<Recipe>();
    // this.IsVegan = false;
     //this.UserRecipes = new List<Recipe>();
    // this.Occupation = "";
    //this.UserRecipes = new List<Recipe>();
    //
    //}
  }
}
