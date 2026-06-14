using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VeltisERP.Domain.Entities;

namespace VeltisERP.Infrastructure.Data;

public static class DbInitializer
{
    public static async Task SeedAsync(
        AppDbContext context,
        UserManager<IdentityUser> userManager,
        RoleManager<IdentityRole> roleManager)
    {
        await context.Database.MigrateAsync();

        if (!await context.Empresas.AnyAsync())
        {
            context.Empresas.Add(new Empresa
            {
                NomeFantasia = "Viana Motos",
                RazaoSocial = "Viana Motos",
                Cnpj = "",
                Email = "contato@vianamotos.com.br",
                Telefone = "",
                Cidade = "",
                Estado = "MG"
            });

            await context.SaveChangesAsync();
        }

        const string adminRole = "Administrador";

        if (!await roleManager.RoleExistsAsync(adminRole))
        {
            await roleManager.CreateAsync(new IdentityRole(adminRole));
        }

        const string adminEmail = "admin@veltiserp.com";
        const string adminPassword = "Admin@123";

        var adminUser = await userManager.FindByEmailAsync(adminEmail);

        if (adminUser == null)
        {
            adminUser = new IdentityUser
            {
                UserName = adminEmail,
                Email = adminEmail,
                EmailConfirmed = true
            };

            var result = await userManager.CreateAsync(
                adminUser,
                adminPassword);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(
                    adminUser,
                    adminRole);
            }
        }
    }
}