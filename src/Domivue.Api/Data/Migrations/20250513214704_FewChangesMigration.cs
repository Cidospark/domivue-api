using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domivue.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class FewChangesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Subscriptions_SubscriberId",
                table: "Sellers");

            migrationBuilder.AlterColumn<string>(
                name: "SubscriberId",
                table: "Sellers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "PublicId",
                table: "GalleryImages",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Subscriptions_SubscriberId",
                table: "Sellers",
                column: "SubscriberId",
                principalTable: "Subscriptions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Subscriptions_SubscriberId",
                table: "Sellers");

            migrationBuilder.AlterColumn<string>(
                name: "SubscriberId",
                table: "Sellers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PublicId",
                table: "GalleryImages",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Subscriptions_SubscriberId",
                table: "Sellers",
                column: "SubscriberId",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
