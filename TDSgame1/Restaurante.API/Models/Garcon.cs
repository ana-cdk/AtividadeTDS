using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.API.Models
{
    public class Garcon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GarconId { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Sobrenome é obrigatório")]
        public string? Sobrenome { get; set; }
        [Required(ErrorMessage = "Número de indentificação é obrigatório")]
        public string? NumeroIdentificacao { get; set; }
        [Required(ErrorMessage = "Número de telefone é obrigatório")]
        public string? NumeroTelefone { get; set; }
    }
}