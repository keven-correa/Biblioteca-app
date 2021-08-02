using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibreriaControlMVC.Models
{
    public class Autor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(100, ErrorMessage = "No puede teber mas de {0} caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este es campo requerido")]
        [MaxLength(100, ErrorMessage = "No puede teber mas de {0} caracteres")]
        public string Apellido { get; set; }

        public string NombreCompleto
        {
            get
            {
                return $"{Nombre} {Apellido}";
            }
        }
        public List<LibroAutor> LibrosAutor { get; set; }
    }
}
