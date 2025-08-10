using System.ComponentModel.DataAnnotations;

namespace ContarlaParaVivir.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string NombreUsuario { get; set; }

        public string Comentario { get; set; }

        [Range(0, 10, ErrorMessage = "El puntaje debe estar entre 0 y 10.")]
        public int Puntaje { get; set; }
    }
}
