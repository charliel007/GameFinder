using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


    [Route("api/[controller]")]
    [ApiController]
    public class GameSystemController : ControllerBase
    {
        private readonly IGameSystemService _gameSystemService;
        public GameSystemController(IGameSystemService gameSystemService)
        {
            _gameSystemService = gameSystemService;
        }

         [HttpGet]
        public async Task<IActionResult> GetGameSystems()
        {
            var console = await _gameSystemService.GetGameSystems();
            return Ok(console);
        }

        [HttpGet, Route("{id}")]
        public async Task<IActionResult> GetGameSystem(int id)
        {
            var console = await _gameSystemService.GetGameSystemById(id);
            if (console is null)
                return NotFound();
            else
                return Ok(console);
        }

    }


