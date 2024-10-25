using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeVault.Models;

public class Recipe
{
    [Key]
    public long Id { get; set; }

    [Required, MaxLength(255)]
    public string Name { get; set; }

    [Required, MaxLength(255)]
    public string Description { get; set; }

    public DateTime CreateTime { get; set; }

    [Required, MaxLength(450)]
    public string UserId { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set;}

    public bool IsPublic { get; set; }

    [Required, MaxLength(32768)]
    public string Instructions { get; set; }

    public ICollection<Ingredient> Ingredients { get; set;}
}
// dotnet ef migrations add refactorRecipeModelAgain -o ./Data/Migrations/
// dotnet ef database update

/* reset database
dotnet ef database drop -f -v
dotnet ef migrations add Initial
dotnet ef database update
*/