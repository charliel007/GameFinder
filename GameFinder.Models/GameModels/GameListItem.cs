using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Models.GameModels
{
    public class GameListItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}