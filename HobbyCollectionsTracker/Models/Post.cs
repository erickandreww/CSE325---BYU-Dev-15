using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace HobbyCollectionsTracker.Models;

public class Post
{
  /// <summary>
  /// Primary key for the post
  /// </summary>
  public int Id { get; set; }

  /// <summary>
  /// Post Title
  /// </summary>
  [Required, StringLength(45, ErrorMessage = "Title must be 45 characters or less.")]
  public string Title { get; set; } = string.Empty;

  /// <summary>
  /// Post Description
  /// </summary>
  [Required, StringLength(1000, ErrorMessage = "Description must be 1000 characters or less.")]
  public string Description { get; set; } = string.Empty;

  // Backing field for ImageUrl so we can normalize empty values
  private string? _imageUrl;

  /// <summary>
  /// Post image (optional). 
  /// </summary>
  [Url]
  [Display(Name = "Image URL")]
  public string? ImageUrl
  {
    get => _imageUrl;
    set
    {
      // Treat blank / whitespace as "no URL" so [Url] doesn't complain
      _imageUrl = string.IsNullOrWhiteSpace(value)
        ? null
        : value;
    }
  }

  /// <summary>
  /// Post Creation date 
  /// </summary>
  [Required, Display(Name = "Created At")]
  public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

  /// <summary>
  /// Category Id of the Category Selected for the post
  /// </summary>
  [Required, Display(Name = "Category")]
  public int CategoryId { get; set; }
  public Category? Category { get; set; }

  /// <summary>
  /// Key Id of the user who created the post
  /// </summary>
  public string UserId { get; set; } = string.Empty;

  public ICollection<PostLike> Likes { get; set; } = new List<PostLike>();
}