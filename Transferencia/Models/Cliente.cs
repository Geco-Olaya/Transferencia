using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Transferencia.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        [StringLength(30)]
        public string Identificacion { get; set; }
    }
}