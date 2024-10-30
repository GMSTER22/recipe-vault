using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeVault.Models;
/// <summary>
/// Represents a category of recipes in the RecipeVault application.
/// </summary>
public class Category
{
    /// <summary>
    /// Gets or sets the unique identifier for the category.
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the category.
    /// </summary>
    [Required, MaxLength(255)]
    public string Name { get; set; }

    /// <summary>
    /// Gets the collection of recipes associated with this category.
    /// </summary>
    public ICollection<Recipe> Recipes { get; }
}
