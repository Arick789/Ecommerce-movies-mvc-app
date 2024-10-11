using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Foto")]
        [Required(ErrorMessage ="La foto de perfil es requerida.")]
        public string FotoPerfilURL { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es requerido.")]
        public string NombreCompleto { get; set; }

        [Display(Name = "Biografia")]
        [Required(ErrorMessage = "La biografia es requerida.")]
        public string Bio { get; set; }

        //Relaciones
        public List<Actor_Pelicula>? Actores_Peliculas { get; set; }
    }
}
