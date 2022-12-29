using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Data.Entities
{
    public class GameEntity
    {
        [Key]
        public int Id { get; set; }
    }
}