namespace VeltisERP.Domain.Entities;

public class Perfil : BaseEntity
{
    public string Nome { get; set; } = string.Empty;

    public string? Descricao { get; set; }

    public ICollection<Usuario> Usuarios { get; set; }
        = new List<Usuario>();
}