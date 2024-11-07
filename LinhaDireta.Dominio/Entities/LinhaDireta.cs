using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinhaDireta.Dominio.Entities;

[Table("LinhaDireta")]
public class LinhaDireta
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string Titulo { get; set; }
    [StringLength(100)]
    public string? NomeCompleto { get; set; }
    [StringLength(600)]
    public string? Mensagem { get; set; }
    public string Protocolo { get; set; }
    public string? Grupo { get; set; }
    public string? Cota { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public string? Departamento { get; set; }
    [StringLength(4)]
    public string? TipoDocumento { get; set; }
    [StringLength(15)]
    public string TipoUsuario { get; set; }
    [StringLength(20)]
    public string? NumeroDocumento { get; set; }
    public int ResponsavelId { get; set; }
    public DateTime DataRecebimento { get; set; } = DateTime.Now;

    [ForeignKey("StatusLinhaDireta")]
    public int StatusId { get; set; }
    public virtual StatusLinhaDireta? StatusLinhaDireta { get; set; }
    public DateTime? DataUltimaAtualizacao { get; set; }
    public int? ResponsavelUltimaAtualizacaoId { get; set; }

    // Propriedade de navegação para o histórico
    public virtual ICollection<LinhaDiretaHistorico>? Historico { get; set; }
}
