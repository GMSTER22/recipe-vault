using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeVault.Models;

// Represents a recipe in the RecipeVault application
public class Recipe
{
    // Primary key for the Recipe entity
    [Key]
    public long Id { get; set; }

    // Name of the recipe, required and with a maximum length of 255 characters
    [Required, MaxLength(255)]
    public string Name { get; set; }

    // Description of the recipe, required and with a maximum length of 255 characters
    [Required, MaxLength(255)]
    public string Description { get; set; }

    // Timestamp when the recipe was created
    public DateTime CreateTime { get; set; }

    // User ID of the recipe creator, required and with a maximum length of 450 characters
    [Required, MaxLength(450)]
    public string UserId { get; set; }

    // Foreign key to the Category entity
    public int CategoryId { get; set; }

    // Navigation property for the Category entity
    public Category Category { get; set;}

    // Indicates whether the recipe is public or private
    public bool IsPublic { get; set; }

    // Instructions for the recipe, required and with a maximum length of 32768 characters
    [Required, MaxLength(32768)]
    public string Instructions { get; set; }

    // Collection of ingredients associated with the recipe
    public ICollection<Ingredient> Ingredients { get; set;}
}