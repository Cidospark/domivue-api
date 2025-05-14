using System.Text.Json;
using Domivue.Api.Modules.Categories.Models.Entities;
using Domivue.Api.Modules.Listings.Models.Entities;
using Domivue.Api.Modules.Tags.Models.Entities;
using Domivue.Api.Modules.Users.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Domivue.Api.Configs.Data;
public static class DbSeeder
    {
        public static async Task SeedAsync(IServiceProvider serviceProvider)
        {
            // Create a scope to resolve services
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            try{
                    // Ensure database is created
                    await context.Database.MigrateAsync();

                    // Seed roles
                    var roles = new List<string> { "Admin", "User", "Seller", "Guest" };
                    if(!context.Roles.Any())
                    {
                        foreach (var role in roles)
                        {
                            if (!await roleManager.RoleExistsAsync(role))
                                await roleManager.CreateAsync(new IdentityRole(role));
                        }
                    }

                    // Seed users
                    if (!context.Users.Any())
                    {
                        // Read and convert user seed data from JSON file to C# object
                        var userData = System.IO.File.ReadAllText("../Domivue.APi/Modules/Users/SeedData/UserSeeds.json");
                        var users = JsonConvert.DeserializeObject<List<User>>(userData);

                        if (users == null)
                        {
                            throw new Exception("Failed to deserialize user data");
                        }
                        foreach (var (user, index) in users.Select((value, i) => (value, i)))
                        {
                            user.UserName = user.Email;
                            var result = await userManager.CreateAsync(user, "Password123!");
                            if (result.Succeeded)
                            {
                                if(index == 0)
                                    await userManager.AddToRoleAsync(user, "Admin");
                                else if(index == 1)
                                    await userManager.AddToRoleAsync(user, "Seller");
                                else
                                await userManager.AddToRoleAsync(user, "User");
                            }
                            else
                            {
                                throw new Exception($"Failed to create user {user.Email}: {string.Join(", ", result.Errors.Select(e => e.Description))}");
                            }
                        }
                        await context.SaveChangesAsync();
                    }


                    // seed categories
                    if(!context.Categories.Any()){
                        var categoryData = System.IO.File.ReadAllText("../Domivue.APi/Modules/Categories/SeedData/Category.json");
                        var categories = JsonConvert.DeserializeObject<List<Category>>(categoryData);

                        if (categories == null)
                        {
                            throw new Exception("Failed to deserialize category data");
                        }
                        foreach (var category in categories)
                        {
                            context.Categories.Add(category);
                        }
                        await context.SaveChangesAsync();
                    }

                    // seed tags
                    if(!context.Tags.Any()){
                        var tagData = System.IO.File.ReadAllText("../Domivue.APi/Modules/Tags/SeedData/Tag.json");
                        var tags = JsonConvert.DeserializeObject<List<Tag>>(tagData);

                        if (tags == null)
                        {
                            throw new Exception("Failed to deserialize tag data");
                        }
                        foreach (var tag in tags)
                        {
                            context.Tags.Add(tag);
                        }
                        await context.SaveChangesAsync();
                    }

                    // seed listings
                    if(!context.Listings.Any()){
                        var listingData = System.IO.File.ReadAllText("../Domivue.APi/Modules/Listings/SeedData/Listings.json");
                        var listings = JsonConvert.DeserializeObject<List<Listing>>(listingData);

                        if (listings == null)
                        {
                            throw new Exception("Failed to deserialize listing data");
                        }
                        foreach (var listing in listings)
                        {
                            context.Listings.Add(listing);
                        }
                        await context.SaveChangesAsync();
                    }

                    Console.WriteLine($"Seeding data completed successfuly!");
            }
            catch(Exception ex){
                Console.WriteLine($"Error seeding data: {ex.Message}");
            }
        }
    }