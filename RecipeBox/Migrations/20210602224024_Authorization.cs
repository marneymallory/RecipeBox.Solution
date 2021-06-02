using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeBox.Migrations
{
    public partial class Authorization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryRecipes_Categories_CategoryId",
                table: "CategoryRecipes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryRecipes_Recipes_RecipeId",
                table: "CategoryRecipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryRecipes",
                table: "CategoryRecipes");

            migrationBuilder.RenameTable(
                name: "CategoryRecipes",
                newName: "CategoryRecipe");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryRecipes_RecipeId_CategoryId",
                table: "CategoryRecipe",
                newName: "IX_CategoryRecipe_RecipeId_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryRecipes_CategoryId",
                table: "CategoryRecipe",
                newName: "IX_CategoryRecipe_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryRecipe",
                table: "CategoryRecipe",
                column: "CategoryRecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryRecipe_Categories_CategoryId",
                table: "CategoryRecipe",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryRecipe_Recipes_RecipeId",
                table: "CategoryRecipe",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "RecipeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryRecipe_Categories_CategoryId",
                table: "CategoryRecipe");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryRecipe_Recipes_RecipeId",
                table: "CategoryRecipe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryRecipe",
                table: "CategoryRecipe");

            migrationBuilder.RenameTable(
                name: "CategoryRecipe",
                newName: "CategoryRecipes");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryRecipe_RecipeId_CategoryId",
                table: "CategoryRecipes",
                newName: "IX_CategoryRecipes_RecipeId_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryRecipe_CategoryId",
                table: "CategoryRecipes",
                newName: "IX_CategoryRecipes_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryRecipes",
                table: "CategoryRecipes",
                column: "CategoryRecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryRecipes_Categories_CategoryId",
                table: "CategoryRecipes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryRecipes_Recipes_RecipeId",
                table: "CategoryRecipes",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "RecipeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
