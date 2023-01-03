using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



    public interface IGameSystemService
    {
        Task<GameSystemDetails> GetGameSystemById(int id);
        Task<List<GameSystemListItem>> GetGameSystems();

    }
