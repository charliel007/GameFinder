using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Services.Game;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;
        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("gameId:int")]
        public async Task<IActionResult> GetById([FromRoute] int gameId)
        {
            // var gameService = await _gameService.(gameId);
            // if (gameService is null)
            // {
            //     return NotFound();
            // }
            return Ok();
        }
    }

