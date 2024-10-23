using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeVault.Models;
public class Unit
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(255)]
    public string Name { get; set; }

    public ICollection<IngredientHasRecipe> IngredientHasRecipes { get; set; }
}