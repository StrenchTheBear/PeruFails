
namespace PeruFailsodels
{
    public class Subir
    {
        public int Id { get; set; }

        [Required]
        
        [Display(Name="Nombre")]
        public string Nombre { get; set; }
        
        [Display(Name="URL de la imagen del producto")]
         public string Url { get; set; }
    }
}