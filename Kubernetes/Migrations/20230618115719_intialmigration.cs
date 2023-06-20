using Microsoft.EntityFrameworkCore.Migrations;

namespace Kubernetes.Migrations
{
    public partial class intialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Phone", "Title" },
                values: new object[,]
                {
                    { 1, "Shaveta", "Girdhar", "4738748374", "Mrs." },
                    { 2, "Aarav", "Gupta", "545474", "Mr." },
                    { 3, "Anu", "Girdhar", "432111111", "Mrs." },
                    { 4, "Tushar", "Tuteja", "13242455", "Mr." },
                    { 5, "Anish", "Gupta", "876589039", "Mr." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
