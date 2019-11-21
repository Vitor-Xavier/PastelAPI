using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PastelAPI.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public int CategoriaId { get; set; }

        [Required, StringLength(80)]
        public string Nome { get; set; }

        [StringLength(255)]
        public string Descricao { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public decimal ValorUnitario { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<PedidoItem> Itens { get; set; }
    }
}
