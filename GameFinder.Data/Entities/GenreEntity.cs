using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Data.Entities
{
    public class GenreEntity
    {
        [Key]
        public int Id { get; set; }
    }
}