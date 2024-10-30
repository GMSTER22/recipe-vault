using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeVault.Models;

/// <summary>
/// Represents an ingredient used in a recipe.
/// </summary>
public class Ingredient
{
    /// <summary>
    /// Gets or sets the unique identifier for the ingredient.
    /// </summary>
    [Key]
    public int IngredientId { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the associated recipe.
    /// </summary>
    [Required, ForeignKey("Recipe")]
    public long RecipeId { get; set; }

    /// <summary>
    /// Gets the associated recipe.
    /// </summary>
    public Recipe Recipe { get; }

    /// <summary>
    /// Gets or sets the name of the ingredient.
    /// </summary>
    [Required, MaxLength(255)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the ingredient.
    /// </summary>
    [Required, MaxLength(25)]
    public string Quantity { get; set; }

    /// <summary>
    /// Gets or sets the units of the ingredient quantity.
    /// </summary>
    [Required, MaxLength(25)]
    public string Units { get; set; }
}
