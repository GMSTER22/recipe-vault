using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeVault.Data.Migrations
{
    /// <inheritdoc />
    public partial class refactorRecipeModelAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Instruction",
                table: "Instruction");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Instruction");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ingredient",
                newName: "IngredientId");

            migrationBuilder.AddColumn<long>(
                name: "InstructionId",
                table: "Instruction",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instruction",
                table: "Instruction",
                column: "InstructionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Instruction",
                table: "Instruction");

            migrationBuilder.DropColumn(
                name: "InstructionId",
                table: "Instruction");

            migrationBuilder.RenameColumn(
                name: "IngredientId",
                table: "Ingredient",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Instruction",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instruction",
                table: "Instruction",
                column: "Id");
        }
    }
}
