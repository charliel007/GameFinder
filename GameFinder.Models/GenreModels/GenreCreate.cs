using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Models.GenreModels
{
    public class GenreCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "{0} must be at least {1} Characters long.")]
        [MaxLength(20, ErrorMessage = "{0} must contain no more than {1} characters.")]
        public string genreName { get; set; }
    }
}
