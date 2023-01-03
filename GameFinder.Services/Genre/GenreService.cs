using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Services.Genre
{
    public class GenreService : IGenreService
    {
        // 1. Bring in the database through dependency injection
        private ApplicationDbContext _context;

        // private readonly ApplicationDbContext _context;

        public GenreService(ApplicationDbContext context)
        {
            _context = context;
        }
    }

    public async Task<GameDetails> GetGenreByIdAsync(int gameId)
    {
        GameEntity game = await _context.Games.FindAsync(gameId);
        if (game is null)
        {
            return null;
        }
        // manuly mapping a GameEntity Object to a GameDetails Object
        return new GameDetails
        {
            Id = game.Id,
            Title = game.Title,
            Genre = game.Genre,
            Description = game.Description,
            GameSystems = game.GameSystems
        };

    }
}