using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



    public interface IGameService
    {
    Task<GameDetails> GetGameByIdAsync(int gameId);
    Task<List<GameListItem>> GetGames();

    }
