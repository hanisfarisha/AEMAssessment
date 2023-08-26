using AEMTest.Services;
using Microsoft.EntityFrameworkCore;
using System;

namespace AEMTest.Models
{

    public class PlatformWellContext : DbContext
    {
        public PlatformWellContext(DbContextOptions options) : base(options) { }
        DbSet<Platform> Platforms { get; set; }
        DbSet<Well> Wells { get; set; }

    }
}
