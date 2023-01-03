using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameFinder.Data;
using GameFinder.Data.Entities;
using GameFinder.Models.GameModels;

namespace GameFinder.Services.Game
{
    
    public class GameService : IGameService
    {

        // 1. Bring in the database through dependency injection
        private ApplicationDbContext _context;

        private readonly ApplicationDbContext _context;

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

        public async Task<bool> CreateGameAsync(GameCreate model)
        {
            var entity = new GameEntity
            {
                Title = model.Title,
                Description = model.Description
            };

            _context.Games.Add(entity);
            var numberOfChanges = await _context.SaveChangesAsync();

            return numberOfChanges == 1;
        }

        public async Task<bool> EditGameAsync(GameEdit request)
        {
            var noteEntity = await _context.Games.FindAsync(request.Id);
            
            if (noteEntity == null)
                return false;

            noteEntity.Title = request.Title;
            noteEntity.Description = request.Description;

            var numberOfChanges = await _context.SaveChangesAsync();

            return numberOfChanges == 1;
        }

        public async Task<bool> DeleteGameAsync(int gameId)
        {
            // Find the note by the given Id
            var gameEntity = await _context.Games.FindAsync(gameId);

            // Validate the note exists and is owned by the user
            if (gameEntity == null)
                return false;

            // Remove the note from the DbContext and assert that the one change was saved
            _context.Games.Remove(gameEntity);
            return await _context.SaveChangesAsync() == 1;

        }
    }
}