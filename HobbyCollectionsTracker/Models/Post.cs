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
  [Required, StringLength(100, ErrorMessage = "Title must be 100 characters or less.")]
  public string Title { get; set; } = string.Empty; //

  /// <summary>
  /// Post Description
  /// </summary>
  [Required, StringLength(2000, ErrorMessage = "Description must be 2000 characters or less.")]
  public string Description { get; set; } = string.Empty; //

  // Post image (that is optional)
  [Url]
  [Display(Name = "Image URL")]
  public string? ImageUrl { get; set; }

  /// <summary>
  /// Post Creation data 
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
}