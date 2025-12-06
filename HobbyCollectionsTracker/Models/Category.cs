using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace HobbyCollectionsTracker.Models;

public class Category
{
  /// <summary>
  /// Key Indentification oof the Category
  /// </summary>
  public int Id { get; set; }

  /// <summary>
  /// Category Name
  /// </summary>
  [Required, StringLength(50, ErrorMessage = "Name must be 50 characters or less.")]
  public string Name { get; set; } = string.Empty;

  /// <summary>
  /// List of the Post using this category
  /// </summary>
  public ICollection<Post> posts { get; set; } = new List<Post>();
}