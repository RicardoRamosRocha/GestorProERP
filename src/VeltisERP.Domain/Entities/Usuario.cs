namespace VeltisERP.Domain.Entities;

public class Usuario : BaseEntity
{
    public string Nome { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string SenhaHash { get; set; } = string.Empty;

    public int PerfilId { get; set; }

    public Perfil Perfil { get; set; } = null!;
}