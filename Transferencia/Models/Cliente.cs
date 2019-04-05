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
        
        [Required(ErrorMessage = "Hey!! paila ...")]
        [StringLength(200)]
        [Display(Name = "Tu nombre")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(10)]
        public string Identificacion { get; set; }
    }
}