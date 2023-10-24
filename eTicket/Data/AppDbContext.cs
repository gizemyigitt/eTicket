using eTicket.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Data
{
    public class AppDbContext:DbContext
    {
        //Verilerle  bağlantı kurduğumuz sınıf
        //base ile alt sınıfın üst sınıfın yapıcı metodunu da çağırmasını sağlar
        public AppDbContext(DbContextOptions<AppDbContext> options) :  base( options )
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//veritabanımızın modelini oluşturur
        {

            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            //ilişkileri belirledik
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
