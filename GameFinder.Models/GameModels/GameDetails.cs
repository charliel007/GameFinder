using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



    public class GameDetails
    {

    public int Id { get; set; }
    
    public string Title { get; set; }

    public string Description { get; set; }

    public List<GenreEntity> Genre { get; set; }
    public List<GameSystemEntity> GameSystems { get; set; }

    }
