using MovieTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTickets.Models
{
    public class Pelicula
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string ImagenURL { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public CategoriaPelicula CategoriaPelicula { get; set; }

        //Relaciones
        public List<Actor_Pelicula> Actores_Peliculas { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Productor
        public int ProductorId { get; set; }
        [ForeignKey("ProductorId")]
        public Productor Productor { get; set; }
    }
}
