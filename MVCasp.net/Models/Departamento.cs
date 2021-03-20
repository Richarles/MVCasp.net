using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCasp.net.Models
{
    public class Departamento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(40, ErrorMessage = "use menos caracteres")]
        public string Setor { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        public string Salario { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

    }
}
