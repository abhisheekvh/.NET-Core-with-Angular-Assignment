using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB_API.Migrations
{ 
    public partial class newreason : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "reasondetails",
                columns: table => new
                {
                    id1 = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    startdate2 = table.Column<string>(type: "varchar(10)", nullable: false),
                    enddate2 = table.Column<string>(type: "varchar(10)", nullable: false),
                    process2 = table.Column<string>(type: "varchar(50)", nullable: false),
                    reason2 = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reasondetails", x => x.id1);
                });
        } 

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reasondetails");
        }
    }
}
