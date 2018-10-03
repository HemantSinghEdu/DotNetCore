using Microsoft.EntityFrameworkCore;
namespace testproject01.Models
{
   public class MoviesDbContext : DbContext
   {
       public MoviesDbContext(DbContextOptions<MoviesDbContext> options)
              :base(options)
       {
           
       }
       
       public DbSet<Movie> Movies { get; set; }
   }
}