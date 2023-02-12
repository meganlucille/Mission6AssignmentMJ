using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6AssignmentMJ.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public DbSet<MovieEntry> movieEntries { get; set; }
    }
}
