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
    public Category Category { get; set; }

    public bool IsPublic { get; set; }

    public ICollection<IngredientHasRecipe> IngredientHasRecipes { get; set; }
    public ICollection<Instruction> Instructions { get; set; }
}