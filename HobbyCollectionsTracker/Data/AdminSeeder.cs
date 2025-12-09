using System;
using System.Threading.Tasks;
using HobbyCollectionsTracker.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace HobbyCollectionsTracker.Seeding;

/// <summary>
/// Seeds the default Admin role and admin user.
/// </summary>
public static class AdminSeeder
{
  public static async Task SeedAdminAsync(IServiceProvider services)
  {
    const string adminRoleName = "Admin";
    const string adminEmail = "admin@example.com";
    const string adminPassword = "Admin123!"; // local dev only

    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

    // 1. Ensure Admin role exists
    if (!await roleManager.RoleExistsAsync(adminRoleName))
    {
      await roleManager.CreateAsync(new IdentityRole(adminRoleName));
    }

    // 2. Ensure admin user exists
    var adminUser = await userManager.FindByEmailAsync(adminEmail);
    if (adminUser == null)
    {
      adminUser = new ApplicationUser
      {
        UserName = adminEmail,
        Email = adminEmail,
        EmailConfirmed = true
      };

      var createResult = await userManager.CreateAsync(adminUser, adminPassword);
      if (!createResult.Succeeded)
      {
        // If something went wrong, just stop seeding.
        return;
      }
    }

    // 3. Ensure user is in Admin role
    if (!await userManager.IsInRoleAsync(adminUser, adminRoleName))
    {
      await userManager.AddToRoleAsync(adminUser, adminRoleName);
    }
  }
}