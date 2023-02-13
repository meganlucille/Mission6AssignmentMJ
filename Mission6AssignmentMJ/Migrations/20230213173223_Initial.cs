using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6AssignmentMJ.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieEntries",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<short>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieEntries", x => x.EntryID);
                });

            migrationBuilder.InsertData(
                table: "MovieEntries",
                columns: new[] { "EntryID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "Tim Burton", true, "Dave", "BatMan is so cool", "PG-13", "Batman", (short)1989 });

            migrationBuilder.InsertData(
                table: "MovieEntries",
                columns: new[] { "EntryID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Family", "Ron Clements", false, "Molly", "The ocean", "PG", "Moana", (short)2016 });

            migrationBuilder.InsertData(
                table: "MovieEntries",
                columns: new[] { "EntryID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Horror", "Ruben Fleischer", false, "", "", "R", "Zombieland", (short)2009 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieEntries");
        }
    }
}
