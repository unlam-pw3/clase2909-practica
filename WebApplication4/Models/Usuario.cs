using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "Ingrese un E-Mail válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo Username es obligatorio.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "El campo Password es obligatorio.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "El campo Edad es obligatorio.")]
        [Range(18, int.MaxValue, ErrorMessage = "La edad debe ser mayor a 18 años.")]
        public int Edad { get; set; }

        //DataAnnotations
        //TODO: Todos los campos son requeridos.
        //TODO: La edad debe ser mayor a 18 años.
        //TODO: Validar el formato de email.
    }
}
