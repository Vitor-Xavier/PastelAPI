using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PastelAPI.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public int SetorId { get; set; }

        [Required, StringLength(60)]
        public string Username { get; set; }

        [Required, StringLength(80)]
        public string Nome { get; set; }

        [StringLength(40)]
        public string Apelido { get; set; }

        public virtual Setor Setor { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

        public virtual ICollection<PedidoItem> PedidoItens { get; set; }
    }
}
