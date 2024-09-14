using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class Cliente
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string NombreCompleto { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe ser un email válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Phone(ErrorMessage = "Debe ser un teléfono válido")]
        public string Telefono { get; set; }
    }
}
