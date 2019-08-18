using Microsoft.EntityFrameworkCore.Migrations;

namespace JobbyGarden.Migrations
{
    public partial class fufu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Blogs",
                maxLength: 800,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Blogs",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 800);
        }
    }
}
