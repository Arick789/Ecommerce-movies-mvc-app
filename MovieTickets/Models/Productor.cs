using MovieTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Productor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Foto")]
        [Required (ErrorMessage = "La foto de perfil es obligatoria")]
        public string FotoPerfilURL { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string NombreCompleto { get; set; }

        [Display(Name = "Biografia")]
        public string Bio { get; set; }

        //Relaciones
        public List<Pelicula> Peliculas { get; set; }
    }
}
