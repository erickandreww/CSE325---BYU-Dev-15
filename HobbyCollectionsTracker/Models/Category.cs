using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HobbyCollectionsTracker.Models;

public class Category
{
  public int Id { get; set; }
  
  [Required, StringLength(50, ErrorMessage = "Name must be 50 characters or less.")]
  public string Name { get; set; } = string.Empty;

  public ICollection<Post> posts { get; set; } = new List<Post>();
}