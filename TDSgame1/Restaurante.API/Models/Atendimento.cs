using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.API.Models
{
    public class Atendimento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int AtendimentoId { get; set; }
        public int MesaId { get; set; }
        public Mesa? Mesa { get; set; }
        public int GarconId { get; set; }
        public Garcon? Garcon { get; set; }
        [Required(ErrorMessage = "Hora do pedido é obrigatório")]
        public DateTime HoraPedido { get; set; }
        public ICollection<Produto>? Produtos { get; set; }
}
    
}