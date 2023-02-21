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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category { CategoryID = 1, CategoryName = "Action/Adventure"},
                    new Category { CategoryID = 2, CategoryName = "Family" },
                    new Category { CategoryID = 3, CategoryName = "Horror" },
                    new Category { CategoryID = 4, CategoryName = "Comedy" },
                    new Category { CategoryID = 5, CategoryName = "Drama" },
                    new Category { CategoryID = 6, CategoryName = "Television" },
                    new Category { CategoryID = 7, CategoryName = "VHS" },
                    new Category { CategoryID = 8, CategoryName = "Misc" }
                );

            mb.Entity<MovieEntry>().HasData(

                new MovieEntry
                {
                    EntryID = 1,
                    CategoryID = 1,
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
                     CategoryID = 2,
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
                      CategoryID = 3,
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
