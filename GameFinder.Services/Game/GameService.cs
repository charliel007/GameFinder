using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Data;
using GameFinder.Data.Entities;
using GameFinder.Models.GameModels;

namespace GameFinder.Services.Game
{
    
    public class GameService : IGameService
    {
        private readonly ApplicationDbContext _context;
        public GameService(ApplicationDbContext context)
        {
            _context = context;
        }

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