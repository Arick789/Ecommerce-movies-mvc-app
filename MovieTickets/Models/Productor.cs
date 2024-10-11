using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Productor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Foto")]
        public string FotoPerfilURL { get; set; }

        [Display(Name = "Nombre")]
        public string NombreCompleto { get; set; }

        [Display(Name = "Biografia")]
        public string Bio { get; set; }

        //Relaciones
        public List<Pelicula> Peliculas { get; set; }
    }
}
