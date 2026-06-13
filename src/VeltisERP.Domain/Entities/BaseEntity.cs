namespace VeltisERP.Domain.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }

    public bool Ativo { get; set; } = true;

    public DateTime DataCadastro { get; set; }
        = DateTime.Now;

    public DateTime? DataAlteracao { get; set; }
}