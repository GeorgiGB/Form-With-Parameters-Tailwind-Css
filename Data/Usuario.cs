using System.ComponentModel.DataAnnotations;

namespace FormPersonalizable.Data
{
    public class Usuario
    {
        [Required(ErrorMessage = "Falta campo por rellenar")]
        [MinLength(3, ErrorMessage = "Se requieren de minimo 3 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Falta campo por rellenar")]
        [MinLength(3, ErrorMessage = "Se requieren de minimo 3 caracteres")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Falta campo por rellenar")]
        [MinLength(3, ErrorMessage = "Se requieren de minimo 3 caracteres")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Falta campo por rellenar")]
        [MaxLength(9,ErrorMessage = "Tiene que tener maximo 9 caracteres")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Falta campo por rellenar")]
        [MinLength(3, ErrorMessage = "Se requieren de minimo 3 caracteres")]
        public string Observaciones { get; set; }
    }
}
