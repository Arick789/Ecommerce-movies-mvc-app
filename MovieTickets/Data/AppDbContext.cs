using Microsoft.EntityFrameworkCore;
using MovieTickets.Models;

namespace MovieTickets.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Pelicula>().HasKey(am => new
            {
                am.ActorId,
                am.PeliculaId
            });

            modelBuilder.Entity<Actor_Pelicula>().HasOne(m => m.Pelicula).WithMany(am => am.Actores_Peliculas).HasForeignKey(m => m.PeliculaId);
            modelBuilder.Entity<Actor_Pelicula>().HasOne(m => m.Actor).WithMany(am => am.Actores_Peliculas).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actores { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Actor_Pelicula> Actores_Peliculas { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Productor> Productores { get; set; }
    }
}
