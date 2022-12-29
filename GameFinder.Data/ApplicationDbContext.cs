using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameFinder.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<GameEntity> Games { get; set; }
        public DbSet<GameSystemEntity> GameSystems { get; set; }
        public DbSet<GenreEntity> Genres { get; set; }
    }
}