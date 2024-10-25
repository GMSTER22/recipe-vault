using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeVault.Models;

public class Ingredient
{
    [Key]
    public int IngredientId { get; set; }

    [Required, ForeignKey("Recipe")]
    public long RecipeId { get; set; }
    public Recipe Recipe { get; }

    [Required, MaxLength(255)]
    public string Name { get; set; }

    [Required, MaxLength(25)]
    public string Quantity { get; set; }

    [Required, MaxLength(25)]
    public string Units { get; set; }
}
