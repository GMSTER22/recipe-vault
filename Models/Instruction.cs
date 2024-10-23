using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeVault.Models;

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
