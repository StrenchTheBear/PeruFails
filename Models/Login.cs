using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeruFails.Models
{
    public class Login
    {
        public int Id { get; set; }

        [Required]        
        
        
        [Display(Name="Contraseña")]
         public string Contraseña { get; set; }
         
        [Display(Name="Correo")]
        public string Correo { get; set; }

    }
}