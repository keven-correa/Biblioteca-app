using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibreriaControlMVC.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(100, ErrorMessage ="No puede tener mas de {0} caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.Date)]
        public DateTime Publicacion { get; set; }

        [Required(ErrorMessage ="Debe especificar la cantidad de libros")]
        public int Stock { get; set; }
        public int EditorialId { get; set; }
        public Editorial Editorial { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }

        public List<LibroAutor> Autores { get; set; }
    }
}
