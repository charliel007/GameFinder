using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Models.GameModels;

namespace GameFinder.Services.Game
{
    public interface IGameService
    {
        Task<bool> CreateGameAsync(GameCreate model);
        Task<bool> EditGameAsync(GameEdit request);
        Task<bool> DeleteGameAsync(int gameId);
    }
}