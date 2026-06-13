namespace VeltisERP.Domain.Entities;

public class Permissao
{
    public int Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Codigo { get; set; } = string.Empty;

    public string? Descricao { get; set; }

    public ICollection<PerfilPermissao> PerfilPermissoes
    {
        get;
        set;
    } = new List<PerfilPermissao>();
}