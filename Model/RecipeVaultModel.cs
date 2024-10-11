using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Unit
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(255)]
    public string Name { get; set; }

    public ICollection<IngredientHasRecipe> IngredientHasRecipes { get; set; }
}

public class Ingredient
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(255)]
    public string Name { get; set; }

    public ICollection<IngredientHasRecipe> IngredientHasRecipes { get; set; }
}

public class Category
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(255)]
    public string Name { get; set; }

    public ICollection<Recipe> Recipes { get; set; }
}

public class User
{
    [Key]
    public long Id { get; set; }

    [Required, MaxLength(16)]
    public string Username { get; set; }

    [Required, MaxLength(255)]
    public string Email { get; set; }

    [Required, MaxLength(32)]
    public string Password { get; set; }

    public DateTime CreateTime { get; set; }

    public ICollection<Recipe> Recipes { get; set; }
}

public class Recipe
{
    [Key]
    public long Id { get; set; }

    [Required, MaxLength(255)]
    public string Name { get; set; }

    [Required, MaxLength(255)]
    public string Description { get; set; }

    public DateTime CreateTime { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public bool Public { get; set; }

    public ICollection<IngredientHasRecipe> IngredientHasRecipes { get; set; }
    public ICollection<Instruction> Instructions { get; set; }
}

public class Instruction
{
    [Key]
    public int Id { get; set; }

    public int Order { get; set; }

    [Required, MaxLength(45)]
    public string Details { get; set; }

    public long RecipeId { get; set; }
    public Recipe Recipe { get; set; }
}

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