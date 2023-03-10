// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6AssignmentMJ.Models;

namespace Mission6AssignmentMJ.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6AssignmentMJ.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "VHS"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Misc"
                        });
                });

            modelBuilder.Entity("Mission6AssignmentMJ.Models.MovieEntry", b =>
                {
                    b.Property<int>("EntryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<short>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("EntryID");

                    b.HasIndex("CategoryID");

                    b.ToTable("MovieEntries");

                    b.HasData(
                        new
                        {
                            EntryID = 1,
                            CategoryID = 1,
                            Director = "Tim Burton",
                            Edited = true,
                            LentTo = "Dave",
                            Notes = "BatMan is so cool",
                            Rating = "PG-13",
                            Title = "Batman",
                            Year = (short)1989
                        },
                        new
                        {
                            EntryID = 2,
                            CategoryID = 2,
                            Director = "Ron Clements",
                            Edited = false,
                            LentTo = "Molly",
                            Notes = "The ocean",
                            Rating = "PG",
                            Title = "Moana",
                            Year = (short)2016
                        },
                        new
                        {
                            EntryID = 3,
                            CategoryID = 3,
                            Director = "Ruben Fleischer",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "R",
                            Title = "Zombieland",
                            Year = (short)2009
                        });
                });

            modelBuilder.Entity("Mission6AssignmentMJ.Models.MovieEntry", b =>
                {
                    b.HasOne("Mission6AssignmentMJ.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
