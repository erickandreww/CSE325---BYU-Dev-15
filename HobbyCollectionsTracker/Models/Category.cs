using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HobbyCollectionsTracker.Models;

[Index(nameof(Name), IsUnique = true)]
public class Category
{
  /// <summary>
  /// Key Indentification oof the Category
  /// </summary>
  public int Id { get; set; }

  /// <summary>
  /// Category Name
  /// </summary>
  [Required, StringLength(20, ErrorMessage = "Name must be 20 characters or less.")]
  public string Name { get; set; } = string.Empty;

  /// <summary>
  /// List of the Post using this category
  /// </summary>
  public ICollection<Post> posts { get; set; } = new List<Post>();
}