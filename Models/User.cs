﻿namespace Cinder.Models
{
  public class User
  {
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool IsVegan { get; set; }
    public string Occupation {  get; set; }
    public List<Recipe> UserRecipes { get; set; } = new List<Recipe>();
    public List<User> CachedUsers { get; set; } = new List<User>();

    public static List<User> AllUsers { get; set; } = new List<User>();
    public User(string username, string password)
    {
      this.Username = username;
      this.Password = password;
      this.IsVegan = false;
      this.Occupation = "";

      try
      {
        var latestId = User.AllUsers.Last().Id;
        this.Id = latestId + 1;
      }
      catch 
      {   
       this.Id = 0;
      }
      User.AllUsers.Add(this);
    }
  }
}