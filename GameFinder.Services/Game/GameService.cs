using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GameFinder.Services.Game
{
    public class GameService : IGameService
    {
        // 1. Bring in the database through dependency injection
        private ApplicationDbContext _context;

        public GameService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<GameDetails> GetGameByIdAsync(int gameId)
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

        public async Task<List<GameListItem>> GetGames()
        {
            return await _context.Games.Select(g => new GameListItem 
            {
                Id = g.Id,
                Title = g.Title
            }).ToListAsync();
        }
    }
}