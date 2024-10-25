using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace RecipeVault.Models;

public class Recipe
{
    public BigInteger Id { get; set; }

    [StringLength(255)]
    [Required]
    public string? Name { get; set; }

     [StringLength(500)]
    public string? Description { get; set; }

    [Display(Name = "Create Time")]
    [DataType(DataType.Date)]
    public DateTime create_time { get; set; }

    [Display(Name = "User ID")]
    public BigInteger user_id { get; set; }

    [Display(Name = "Category ID")]
    public int category_category_id { get; set; }

    [Display(Name = "Is Public")]
    public bool is_public { get; set; }

}