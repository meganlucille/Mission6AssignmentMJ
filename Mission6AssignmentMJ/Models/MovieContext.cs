using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6AssignmentMJ.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {

        }

        public DbSet<MovieEntry> MovieEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieEntry>().HasData(

                new MovieEntry
                {
                    EntryID = 1,
                    Category = "Action/Adventure",
                    Title = "Batman",
                    Year = 1989,
                    Director = "Tim Burton",
                    Rating = "PG-13",
                    Edited = true,
                    LentTo = "Dave",
                    Notes = "BatMan is so cool",
                },

                 new MovieEntry
                 {
                     EntryID = 2,
                     Category = "Family",
                     Title = "Moana",
                     Year = 2016,
                     Director = "Ron Clements",
                     Rating = "PG",
                     Edited = false,
                     LentTo = "Molly",
                     Notes = "The ocean",
                 },

                  new MovieEntry
                  {
                      EntryID = 3,
                      Category = "Horror",
                      Title = "Zombieland",
                      Year = 2009,
                      Director = "Ruben Fleischer",
                      Rating = "R",
                      Edited = false,
                      LentTo = "",
                      Notes = "",
                  }
            );
        }
    }
}
