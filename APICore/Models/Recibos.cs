using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APICore.Models
{
    public class Recibos
    {
        [Key]
        public int IdRecibo { get; set; }
        public int IdUsuario { get; set; }
        public string Proveedor { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public string Comentario { get; set; }
        public DateTime FechaComentario { get; set; }
    }
}
