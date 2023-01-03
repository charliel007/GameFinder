using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class GameSystemService: IGameSystemService
    {
        private ApplicationDbContext _context;

        public GameSystemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<GameSystemDetails> GetGameSystemById(int id)
        {
             var console = await _context.GameSystems.Include(s => s.Game).SingleOrDefaultAsync(x => x.Id == id);

            return new GameSystemDetails
            {
                Id = console.Id,
                Name = console.Name,                 
            };
        }

        public async Task<List<GameSystemListItem>> GetGameSystems()
        {
           var console = await _context.GameSystems.Select(s => new GameSystemListItem
        {
            Id = s.Id,
            Name = s.Name,
        }).ToListAsync();

        return console;
        }
    }
