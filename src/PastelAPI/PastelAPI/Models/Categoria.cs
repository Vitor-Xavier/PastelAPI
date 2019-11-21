using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PastelAPI.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Required, StringLength(40)]
        public string Nome { get; set; }

        [StringLength(255)]
        public string Descricao { get; set; }

        [StringLength(40)]
        public string Tipo { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
