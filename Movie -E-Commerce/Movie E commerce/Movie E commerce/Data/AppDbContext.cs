using Microsoft.EntityFrameworkCore;
using Movie_E_commerce.Models;

namespace Movie_E_commerce.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Actor_Movie is a Join relationship between actors and movies
            modelBuilder.Entity<Actor_Movie>().HasKey(am =>
            new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie)
                .WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Actor_Movie>().HasOne(a => a.Actor)
                .WithMany(am => am.Actors_Movies).HasForeignKey(a => a.ActorId).OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Movie> Movies{ get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }

    }
}
