using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace monslay_back.Models
{
    public class MonSlayDbContext : DbContext
    {
        public MonSlayDbContext(DbContextOptions<MonSlayDbContext> options) : base(options){ }

        public DbSet<Player> Players { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        
    }
}
