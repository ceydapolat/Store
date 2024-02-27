using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace StoreApp.Infrastructure.Extensions;

public static class ApplicationExtension
{
    public static void ConfigureAndCheckMigrations(this IApplicationBuilder appBuilder)
    {
        RepositoryContext context = appBuilder
            .ApplicationServices
            .CreateScope()
            .ServiceProvider
            .GetRequiredService<RepositoryContext>();

        if(context.Database.GetPendingMigrations().Any())
        {
            context.Database.Migrate(); //dotnet ef database update otomatik olarak yapılacak
        }
    }

    public static void ConfigureLocalization(this WebApplication app){
        var supportedCultures = new[] { "tr", "en" };

        app.UseRequestLocalization(options => 
        {
            options.AddSupportedCultures(supportedCultures)
                .AddSupportedUICultures(supportedCultures)
                .SetDefaultCulture("tr-TR");
        });
    }

    public static async void ConfigureDefaultAdminUser(this IApplicationBuilder appBuilder)
    {
        const string adminUser = "Admin";
        const string adminPassword = "Admin+123456"; 

        //UserManager
        UserManager<IdentityUser> userManager = appBuilder
            .ApplicationServices
            .CreateScope()
            .ServiceProvider
            .GetRequiredService<UserManager<IdentityUser>>();

        //RoleManager
        RoleManager<IdentityRole> roleManager = appBuilder
            .ApplicationServices
            .CreateAsyncScope()
            .ServiceProvider
            .GetRequiredService<RoleManager<IdentityRole>>();

        IdentityUser? user = await userManager.FindByNameAsync(adminUser);

        if(user is null)
        {
            user = new IdentityUser()
            {
                Email = "ceydapolat@marmara.edu.tr",
                PhoneNumber = "0000000000",
                UserName = adminUser
            }; 

            var result = await userManager.CreateAsync(user, adminPassword);
            if(!result.Succeeded)
                throw new Exception("Admin user could not created.");

            var roleResult = await userManager.AddToRolesAsync(user,
                    roleManager
                    .Roles
                    .Select(r => r.Name)
                    .ToList()
            );

          if(!roleResult.Succeeded)
            throw new Exception("System have problems with role definition for admin.");
        }
    }
}
