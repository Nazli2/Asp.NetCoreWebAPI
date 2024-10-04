using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class createRelationBetweenBookAndCategoryMtoOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c70ff7c-a2ad-4c67-abf7-79f2f624c70d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8933508b-bff4-4c2e-8b8e-4c567633ceab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0a25ef2-eb7c-492a-9ff1-6c099d211dbf");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aa473368-e4e2-469d-a562-e1d9d0857ecf", "705d484e-e10c-4335-a828-1665dafe84e0", "Admin", "ADMIN" },
                    { "c892548a-5d6a-4e77-adc3-51204b716ad6", "e9b35a1c-41eb-402d-ae74-ef9645e3e060", "Editor", "EDITOR" },
                    { "e68a77fe-51fd-43c6-ba47-90a4511322bd", "9bd5b8cf-38e0-457a-9898-0bb8a45bff76", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CategoryName",
                value: "Database Management Systems");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CategoryId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa473368-e4e2-469d-a562-e1d9d0857ecf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c892548a-5d6a-4e77-adc3-51204b716ad6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e68a77fe-51fd-43c6-ba47-90a4511322bd");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Books");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c70ff7c-a2ad-4c67-abf7-79f2f624c70d", "d3785395-57d7-43b7-8274-26fffb865995", "Admin", "ADMIN" },
                    { "8933508b-bff4-4c2e-8b8e-4c567633ceab", "72ba60b3-08ad-4256-bd55-9ffb2e108f71", "User", "USER" },
                    { "c0a25ef2-eb7c-492a-9ff1-6c099d211dbf", "1e5abcba-dd0c-454e-bda5-57c27362804f", "Editor", "EDITOR" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CategoryName",
                value: "Database Manangment Systems");
        }
    }
}
