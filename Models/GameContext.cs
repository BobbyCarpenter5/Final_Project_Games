using Microsoft.EntityFrameworkCore;

namespace Final_Project_Games.Models
{
    public class GameContext : DbContext
    {
        public GameContext (DbContextOptions<GameContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games {get; set;}
    }
}