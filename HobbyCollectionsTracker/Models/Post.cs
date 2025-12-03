using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace HobbyCollectionsTracker.Models;

public class Post
{
  public int Id { get; set; }

  [Required, StringLength(100, ErrorMessage = "Title must be 100 characters or less.")]
  public string Title { get; set; } = string.Empty; //

  [Required, StringLength(2000, ErrorMessage = "Description must be 2000 characters or less.")]
  public string Description { get; set; } = string.Empty; //

  [Url]
  [Display(Name = "Image URL")]
  public string ImageUrl { get; set; } = string.Empty; //

  [Required, Display(Name = "Created At")]
  public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

  // Relation with Category Model
  [Required, Display(Name = "Category")]
  public int CategoryId { get; set; }
  public Category? Category { get; set; } 

  // Relation with User
  public string UserId { get; set; } = string.Empty;

  // public IdentityUser? User { get; set; }
}