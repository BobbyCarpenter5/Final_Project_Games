using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Final_Project_Games.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var db = new GameContext(serviceProvider.GetRequiredService<DbContextOptions<GameContext>>()))
            {
                if (db.Games.Any())
                {
                    return;
                }

                db.Games.AddRange(
                    new Game
                    {
                        GameName = "Call of Duty Modern Warfare 2",
                        ReleaseDate = DateTime.Parse("2009-11-10"),
                        Rating = "M"
                    },

                    new Game
                    {
                        GameName = "Minecraft",
                        ReleaseDate = DateTime.Parse("2011-11-18"),
                        Rating = "E",
                    },

                    new Game
                    {
                        GameName = "Call of Duty World at War",
                        ReleaseDate = DateTime.Parse("2008-11-11"),
                        Rating = "M"
                    },

                    new Game
                    {
                        GameName = "Battlefield 3",
                        ReleaseDate = DateTime.Parse("2011-10-25"),
                        Rating = "M"
                    },
                    new Game
                    {
                        GameName = "Battlefield 4",
                        ReleaseDate = DateTime.Parse("2013-10-29"),
                        Rating = "M"
                    }
                );
                db.SaveChanges();
            }
        }
    }
}