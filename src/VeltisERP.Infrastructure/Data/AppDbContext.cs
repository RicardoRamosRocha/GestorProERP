using Microsoft.EntityFrameworkCore;
using VeltisERP.Domain.Entities;

namespace VeltisERP.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(
        DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Usuario> Usuarios => Set<Usuario>();

    public DbSet<Perfil> Perfis => Set<Perfil>();

    public DbSet<Permissao> Permissoes => Set<Permissao>();

    public DbSet<PerfilPermissao> PerfilPermissoes
        => Set<PerfilPermissao>();

     public DbSet<Empresa> Empresas => Set<Empresa>();   

    protected override void OnModelCreating(
        ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PerfilPermissao>()
            .HasKey(x => new
            {
                x.PerfilId,
                x.PermissaoId
            });
    }
}