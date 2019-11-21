using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PastelAPI.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }

        public int? SetorId { get; set; }

        public DateTime DataPedido { get; set; }

        public DateTime? DataLimite { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public decimal ValorDesconto { get; set; }

        public PedidoStatus Status { get; set; }

        public virtual Setor Setor { get; set; }

        public virtual ICollection<PedidoItem> Itens { get; set; }
    }
}
