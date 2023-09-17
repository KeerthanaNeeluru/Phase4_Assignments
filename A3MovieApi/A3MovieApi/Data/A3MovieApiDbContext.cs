using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using A3MovieApi.Models;

namespace A3MovieApi.Data
{
    public class A3MovieApiDbContext : DbContext
    {
        public A3MovieApiDbContext (DbContextOptions<A3MovieApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<A3MovieApi.Models.Movie> Movies { get; set; } = default!;
    }
}
