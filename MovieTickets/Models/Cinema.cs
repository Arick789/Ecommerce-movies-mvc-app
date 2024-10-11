using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display (Name ="Logo")]
        public string Logo { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        //Relaciones
        public List<Pelicula> Peliculas { get; set; }
    }
}
