namespace VeltisERP.Domain.Entities;

public class Cliente : BaseEntity
{
    public string NomeRazaoSocial { get; set; } = string.Empty;

    public string? Documento { get; set; }

    public string? Email { get; set; }

    public string? Telefone { get; set; }

    public string? Endereco { get; set; }

    public string? Cidade { get; set; }

    public string? Estado { get; set; }

    public string? Cep { get; set; }

    public int EmpresaId { get; set; }

    public Empresa Empresa { get; set; } = null!;
}