using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Nombre de usuario obligatorio")]
        public string Usuario { get; set; }
        [Required(ErrorMessage ="Password obligatorio")]
        public string Password { get; set; }

    }
}
