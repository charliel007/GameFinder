using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Models.GameModels;



    public interface IGameService
    {

    Task<GameDetails> GetGameByIdAsync(int gameId);
    Task<List<GameListItem>> GetGames();

        Task<bool> CreateGameAsync(GameCreate model);
        Task<bool> EditGameAsync(GameEdit request);
        Task<bool> DeleteGameAsync(int gameId);

    }
