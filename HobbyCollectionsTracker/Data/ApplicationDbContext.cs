using HobbyCollectionsTracker.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HobbyCollectionsTracker.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
  public DbSet<Post> Posts { get; set; } = default!;
  public DbSet<Category> Categories { get; set; } = default!;
  public DbSet<PostLike> PostLikes { get; set; } = default!;

  protected override void OnModelCreating(ModelBuilder builder)
  {
    base.OnModelCreating(builder);

    builder.Entity<PostLike>()
      .HasIndex(pl => new { pl.PostId, pl.UserId })
      .IsUnique();
  }
}
