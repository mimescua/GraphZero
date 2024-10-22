﻿using GraphZero.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphZero.API.Data
{
    public class LandDbContext: DbContext
    {
        public LandDbContext(DbContextOptions<LandDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<FeatureCollection> FeatureCollection { get; set; }
    }
}