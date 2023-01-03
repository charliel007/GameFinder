using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Models.GameModels;
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

        [HttpPost("CreateGame")]
        public async Task<IActionResult> GameCreate([FromBody] GameCreate model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createResult = await _gameService.CreateGameAsync(model);
            if (createResult)
            {
                return Ok("Game was created.");
            }
            return BadRequest("Game could not be created.");
        }

        [HttpPut]
        public async Task<IActionResult> EditGameById([FromBody] GameEdit request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            return await _gameService.EditGameAsync(request)
                ? Ok("Game updated successfully.")
                : BadRequest("Game could note be updated.");
        }

        [HttpDelete("{gameId:int}")]
        public async Task<IActionResult> DeleteGame([FromRoute] int gameId)
        {
            return await _gameService.DeleteGameAsync(gameId)
                ? Ok($"Note {gameId} was deleted successfully.")
                : BadRequest($"Note {gameId} could not be deleted.");
        }

        
    }

