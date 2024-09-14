using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class Marca
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El país de origen es obligatorio")]
        public string PaisOrigen { get; set; }
    }
}
