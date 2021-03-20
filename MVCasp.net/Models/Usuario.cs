using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCasp.net.Models
{
    public class Usuario
    {
        public int id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(40, ErrorMessage = "use menos caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(40, ErrorMessage = "use menos caracteres")]
        public string Cargo { get; set; }
        public List<Departamento>Departamentos { get; set; }

    }
}
