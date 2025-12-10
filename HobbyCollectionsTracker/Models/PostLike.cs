using System;
using System.ComponentModel.DataAnnotations;

namespace HobbyCollectionsTracker.Models;

public class PostLike
{
    public int Id { get; set; }

    [Required]
    public int PostId { get; set; }
    public Post? Post { get; set; }

    [Required]
    public string UserId { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}