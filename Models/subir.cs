
namespace PeruFailsodels
{
    public class Subir
    {
        public int Id { get; set; }

        [Required]
        
        [Display(Name="Titulo")]
        public string Titulo { get; set; }
        
        [Display(Name="URL de la imagen")]
         public string Url { get; set; }
    }
}