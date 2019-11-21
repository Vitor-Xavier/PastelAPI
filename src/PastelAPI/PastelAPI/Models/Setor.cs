using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PastelAPI.Models
{
    public class Setor
    {
        public int SetorId { get; set; }

        [Required, StringLength(40)]
        public string Nome { get; set; }

        [StringLength(15)]
        public string Sigla { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
