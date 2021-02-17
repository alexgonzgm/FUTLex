using Microsoft.EntityFrameworkCore.Migrations;

namespace FUTLex.Data.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rating = table.Column<int>(nullable: false),
                    position = table.Column<string>(nullable: true),
                    club_image = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    rare_type = table.Column<int>(nullable: false),
                    full_name = table.Column<string>(nullable: true),
                    url_name = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    nation_image = table.Column<string>(nullable: true),
                    rare = table.Column<int>(nullable: false),
                    version = table.Column<string>(nullable: true),
                    Pace = table.Column<int>(nullable: false),
                    Acceleration = table.Column<int>(nullable: false),
                    SprintSpeed = table.Column<int>(nullable: false),
                    Shooting = table.Column<int>(nullable: false),
                    Positioning = table.Column<int>(nullable: false),
                    Finishing = table.Column<int>(nullable: false),
                    ShotPower = table.Column<int>(nullable: false),
                    LongShots = table.Column<int>(nullable: false),
                    Volleys = table.Column<int>(nullable: false),
                    Penalties = table.Column<int>(nullable: false),
                    Passing = table.Column<int>(nullable: false),
                    Visiion = table.Column<int>(nullable: false),
                    Crossing = table.Column<int>(nullable: false),
                    FkAccuaracy = table.Column<int>(nullable: false),
                    ShortPassing = table.Column<int>(nullable: false),
                    LongPassing = table.Column<int>(nullable: false),
                    Curve = table.Column<int>(nullable: false),
                    DribblingTotal = table.Column<int>(nullable: false),
                    Agility = table.Column<int>(nullable: false),
                    Balance = table.Column<int>(nullable: false),
                    Reactions = table.Column<int>(nullable: false),
                    BallControl = table.Column<int>(nullable: false),
                    Dribbling = table.Column<int>(nullable: false),
                    Composturte = table.Column<int>(nullable: false),
                    Defending = table.Column<int>(nullable: false),
                    Interceptions = table.Column<int>(nullable: false),
                    HeadingAcuaricy = table.Column<int>(nullable: false),
                    Marking = table.Column<int>(nullable: false),
                    StandingTackle = table.Column<int>(nullable: false),
                    SlindingTackle = table.Column<int>(nullable: false),
                    PHYSICALITY = table.Column<int>(nullable: false),
                    Jumping = table.Column<int>(nullable: false),
                    Stamina = table.Column<int>(nullable: false),
                    Strength = table.Column<int>(nullable: false),
                    Agression = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
