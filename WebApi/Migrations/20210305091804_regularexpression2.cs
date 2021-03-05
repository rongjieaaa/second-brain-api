using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class regularexpression2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RegularExpressionGroupId",
                table: "RegularExpressions",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RegularExpressions_RegularExpressionGroupId",
                table: "RegularExpressions",
                column: "RegularExpressionGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_RegularExpressions_RegularExpressionGroups_RegularExpression~",
                table: "RegularExpressions",
                column: "RegularExpressionGroupId",
                principalTable: "RegularExpressionGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegularExpressions_RegularExpressionGroups_RegularExpression~",
                table: "RegularExpressions");

            migrationBuilder.DropIndex(
                name: "IX_RegularExpressions_RegularExpressionGroupId",
                table: "RegularExpressions");

            migrationBuilder.DropColumn(
                name: "RegularExpressionGroupId",
                table: "RegularExpressions");
        }
    }
}
