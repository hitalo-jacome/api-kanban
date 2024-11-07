using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LinhaDireta.Dominio.Entities;

public class LinhaDiretaHistorico
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("LinhaDiretaMessage")]
    public int LinhaDiretaId { get; set; }
    public virtual LinhaDireta? LinhaDireta { get; set; }

    public DateTime DataAlteracao { get; set; } = DateTime.Now;
    public int StatusAnterior { get; set; }
    public int StatusAtual { get; set; }
    public int ResponsavelAlteracaoId { get; set; }
    public string? Comentarios { get; set; } // Justificativas ou observações

    public TimeSpan? TempoNoStatus { get; set; } // Calculado com base no tempo que o card ficou no status
}
