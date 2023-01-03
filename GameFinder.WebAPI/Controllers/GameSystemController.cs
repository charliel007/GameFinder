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

    }


