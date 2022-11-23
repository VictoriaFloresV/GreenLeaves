using System.ComponentModel.DataAnnotations;

namespace WebAPI.Modulos
{
    public class form
    {
        [Key]
        public int Id {get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Fecha { get; set; }
        [Required]
        public string Lugar { get; set; }
    }
}
