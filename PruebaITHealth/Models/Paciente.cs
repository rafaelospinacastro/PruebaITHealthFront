using System.ComponentModel.DataAnnotations;

namespace PruebaITHealth.Models
{
    public class Paciente
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? TipoDocumento { get; set; }
        [Required]
        public string? NumeroDocumento { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public DateTime? FechaNacimiento { get; set; }
        [Required]
        public string? Genero { get; set; }
        [Required]
        public string? Direccion { get; set; }
        [Required]
        public int? Telefono { get; set; }
        [Required]
        public bool? Activo { get; set; }


    }

}
