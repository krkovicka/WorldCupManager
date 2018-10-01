using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Reflection.Emit;

namespace WorldCup.Models
{
    public class WorldCupDbContext : DbContext
    {
        public WorldCupDbContext() : base("WorldCup1")
        {

        }

        public DbSet<Match> Matches { get; set; }
        public DbSet<NationalTeam> NationalTeams { get; set; }
        public DbSet<Player> Players { get; set; }

    }
}