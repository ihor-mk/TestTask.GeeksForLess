using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GFL.TestTask.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Folders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Folders_Folders_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Folders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "Id", "ParentId", "Title" },
                values: new object[] { 1, null, "Creating Digital Images" });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "Id", "ParentId", "Title" },
                values: new object[] { 2, 1, "Resources" });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "Id", "ParentId", "Title" },
                values: new object[] { 3, 1, "Evidence" });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "Id", "ParentId", "Title" },
                values: new object[] { 4, 1, "Graphic Products" });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "Id", "ParentId", "Title" },
                values: new object[,]
                {
                    { 5, 2, "Primary Sources" },
                    { 6, 2, "Secondary Sources" },
                    { 7, 4, "Process" },
                    { 8, 4, "Final Producty" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Folders_ParentId",
                table: "Folders",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Folders");
        }
    }
}
