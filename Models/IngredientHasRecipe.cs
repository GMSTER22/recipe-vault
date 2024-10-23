using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeVault.Models;
public class IngredientHasRecipe
{
    [Key]
    public int Id { get; set; }

    public int IngredientId { get; set; }
    public Ingredient Ingredient { get; set; }

    public long RecipeId { get; set; }
    public Recipe Recipe { get; set; }

    public int UnitId { get; set; }
    public Unit Unit { get; set; }

    [Required, MaxLength(45)]
    public string Amount { get; set; }
}