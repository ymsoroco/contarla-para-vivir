using System.ComponentModel.DataAnnotations;

namespace Contarla_Para_Vivir_PNT.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "Debe ingresar un email válido.")]
        public string Email { get; set; } = string.Empty;
    }
}

