using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.API.Models{
public class Mesa
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MesaId { get; set; }
    [Required(ErrorMessage = "Número é obrigatório")]
    public int Numero { get; set; }
    [Required(ErrorMessage = "Situação da mesa é obrigatória")]
    public bool Ocupada { get; set; }
    [Required(ErrorMessage = "Horário é obrigatório")]
    public DateTime? HoraAbertura { get; set; }
    public List<Atendimento> Atendimentos { get; set; }
}
}