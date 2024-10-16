using MovieTickets.Models;

namespace MovieTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
            {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Nombre = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Descripcion = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Nombre = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Descripcion = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Nombre = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Descripcion = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Nombre = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Descripcion = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Nombre = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Descripcion = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }

                //Actores
                if (!context.Actores.Any())
                {
                    context.Actores.AddRange(new List<Actor>()
                    {
                    new Actor()
                    {
                        NombreCompleto = "Actor 1",
                        Bio = "This is the Bio of the first actor",
                        FotoPerfilURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                    },
                        new Actor()
                        {
                            NombreCompleto = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            FotoPerfilURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            NombreCompleto = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            FotoPerfilURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            NombreCompleto = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            FotoPerfilURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            NombreCompleto = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            FotoPerfilURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();

                }

                //Productores
                if (!context.Productores.Any())
                {
                    context.Productores.AddRange(new List<Productor>()
                    {
                        new Productor()
                        {
                            NombreCompleto = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            FotoPerfilURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Productor()
                        {
                            NombreCompleto = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            FotoPerfilURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Productor()
                        {
                            NombreCompleto = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            FotoPerfilURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Productor()
                        {
                            NombreCompleto = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            FotoPerfilURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Productor()
                        {
                            NombreCompleto = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            FotoPerfilURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();

                }

                //Peliculas
                if (!context.Peliculas.Any())
                {
                    context.Peliculas.AddRange(new List<Pelicula>()
                    {
                        new Pelicula()
                        {
                            Nombre = "Life",
                            Descripcion = "This is the Life movie description",
                            Precio = 39.50,
                            ImagenURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            FechaInicio = DateTime.Now.AddDays(-10),
                            FechaFinal = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProductorId = 3,
                            CategoriaPelicula = Enums.CategoriaPelicula.Documental
                        },
                        new Pelicula()
                        {
                            Nombre = "The Shawshank Redemption",
                            Descripcion = "This is the Shawshank Redemption description",
                            Precio = 29.50,
                            ImagenURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            FechaInicio = DateTime.Now,
                            FechaFinal = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProductorId = 1,
                            CategoriaPelicula = Enums.CategoriaPelicula.Accion
                        },
                        new Pelicula()
                        {
                            Nombre = "Ghost",
                            Descripcion = "This is the Ghost movie description",
                            Precio = 39.50,
                            ImagenURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            FechaInicio = DateTime.Now,
                            FechaFinal = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProductorId = 4,
                            CategoriaPelicula = Enums.CategoriaPelicula.Terror
                        },
                        new Pelicula()
                        {
                            Nombre = "Race",
                            Descripcion = "This is the Race movie description",
                            Precio = 39.50,
                            ImagenURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            FechaInicio = DateTime.Now.AddDays(-10),
                            FechaFinal = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProductorId = 2,
                            CategoriaPelicula = Enums.CategoriaPelicula.Documental
                        },
                        new Pelicula()
                        {
                            Nombre = "Scoob",
                            Descripcion = "This is the Scoob movie description",
                            Precio = 39.50,
                            ImagenURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            FechaInicio = new DateTime(2024, 10, 10),
                            FechaFinal = DateTime.Now.AddDays(15),
                            CinemaId = 1,
                            ProductorId = 3,
                            CategoriaPelicula = Enums.CategoriaPelicula.Animada
                        },
                        new Pelicula()
                        {
                            Nombre = "Cold Soles",
                            Descripcion = "This is the Cold Soles movie description",
                            Precio = 39.50,
                            ImagenURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            FechaInicio = DateTime.Now.AddDays(3),
                            FechaFinal = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProductorId = 5,
                            CategoriaPelicula = Enums.CategoriaPelicula.Drama
                        },
                        new Pelicula()
                        {
                            Nombre = "Robot Salvaje",
                            Descripcion = "Un robot llamado Roz naufraga en una isla, donde debe aprender a adaptarse a su nuevo entorno, " +
                            "al establecer relaciones con los animales del lugar, pronto desarrolla un vínculo paternal con un ganso huérfano.",
                            Precio = 39.50,
                            ImagenURL = "https://drive.google.com/file/d/1hI5wWzH-qKoKFn3bI0OOk3RTtf1tLFJF/view?usp=drive_link",
                            FechaInicio = new DateTime(2024, 10, 10),
                            FechaFinal = new DateTime(2024, 10, 10).AddDays(30),
                            CinemaId = 1,
                            ProductorId = 5,
                            CategoriaPelicula = Enums.CategoriaPelicula.Drama
                        }
                    });
                    context.SaveChanges();

                }

                //Actores & Peliculas
                if (!context.Actores_Peliculas.Any())
                {
                    context.Actores_Peliculas.AddRange(new List<Actor_Pelicula>()
                    {
                        new Actor_Pelicula()
                        {
                            ActorId = 1,
                            PeliculaId = 1
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 3,
                            PeliculaId = 1
                        },

                         new Actor_Pelicula()
                        {
                            ActorId = 1,
                            PeliculaId = 2
                        },
                         new Actor_Pelicula()
                        {
                            ActorId = 4,
                            PeliculaId = 2
                        },

                        new Actor_Pelicula()
                        {
                            ActorId = 1,
                            PeliculaId = 3
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 2,
                            PeliculaId = 3
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 5,
                            PeliculaId = 3
                        },


                        new Actor_Pelicula()
                        {
                            ActorId = 2,
                            PeliculaId = 4
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 3,
                            PeliculaId = 4
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 4,
                            PeliculaId = 4
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 2,
                            PeliculaId = 5
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 3,
                            PeliculaId = 5
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 4,
                            PeliculaId = 5
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 5,
                            PeliculaId = 5
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 3,
                            PeliculaId = 6
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 4,
                            PeliculaId = 6
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 5,
                            PeliculaId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
