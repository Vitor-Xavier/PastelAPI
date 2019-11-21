using System.ComponentModel.DataAnnotations.Schema;

namespace PastelAPI.Models
{
    public class PedidoItem
    {
        public int PedidoId { get; set; }

        public int ProdutoId { get; set; }

        public int UsuarioId { get; set; }

        public int Quantidade { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public decimal ValorUnitario { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public decimal? ValorDesconto { get; set; }

        public ItemStatus Status { get; set; }

        public virtual Pedido Pedido { get; set; }

        public virtual Produto Produto { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
