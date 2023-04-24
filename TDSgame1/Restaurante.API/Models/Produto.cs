using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.API.Models
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdutoId { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Descrição é obrigatório")]
        public string? Descricao { get; set; }
        [Required(ErrorMessage = "Preço é obrigatório")]
        public decimal Preco { get; set; }
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}