using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeruFails.Models
{
    public class Registrarse
    {
        public int Id { get; set; }

        [Required]
        
        [Display(Name="Nombre")]
        public string Nombre { get; set; }
        
        [Display(Name="Contraseña")]
         public string Contraseña { get; set; }
         
        [Display(Name="Correo")]
        public string Correo { get; set; }

    }
}