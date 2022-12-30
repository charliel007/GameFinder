using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Data.Entities
{
    public class GameSystemEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey(nameof (Game))]
        public int GameId { get; set; }

        public GameEntity Game { get; set; }
    }
}