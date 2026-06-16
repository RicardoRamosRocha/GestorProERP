namespace VeltisERP.Domain.Entities;

public class Empresa : BaseEntity
{
    public string NomeFantasia { get; set; } = string.Empty;

    public string? RazaoSocial { get; set; }

    public string? Cnpj { get; set; }

    public string? Email { get; set; }

    public string? Telefone { get; set; }

    public string? Endereco { get; set; }

    public string? Cidade { get; set; }

    public string? Estado { get; set; }

    public string? Cep { get; set; }

    public string? LogoUrl { get; set; }

    public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
