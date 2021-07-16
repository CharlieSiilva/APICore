using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APICore.Models
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
    }
}
