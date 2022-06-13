using Microsoft.EntityFrameworkCore.Migrations;

namespace Bootstrap_Rent_a_Car.Migrations
{
    public partial class CreateCartable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Seats = table.Column<int>(nullable: false),
                    CarDoor = table.Column<int>(nullable: false),
                    Luggage = table.Column<int>(nullable: false),
                    Transmission = table.Column<bool>(nullable: false),
                    MinimumAge = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
