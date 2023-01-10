using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Granota.Models;

namespace Granota.Data
{
    public class GranotaContext : DbContext
    {
        public GranotaContext (DbContextOptions<GranotaContext> options)
            : base(options)
        {
        }

        public DbSet<Granota.Models.Products> Products { get; set; } = default!;

        public DbSet<Granota.Models.Buyer> Buyer { get; set; }

        public DbSet<Granota.Models.Owner> Owner { get; set; }

        public DbSet<Granota.Models.Restaurant> Restaurant { get; set; }
    }
}
