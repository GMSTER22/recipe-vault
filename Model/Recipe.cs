using System.Collections.Generic;
using System.Linq;

namespace RecipeVault
{
    /// <summary>
    /// Represents a customized pizza as part of an order
    /// </summary>
    public class Recipe
    {

        public int Id { get; set; }

        public string Name { get; set;}

        public string Description { get; set;}

        public RecipeCategory Category {get; set;}

        public Boolean IsPublic {get; set;}

        public List<RecipeIngredients> Ingredients { get; set; } 

        public List<Instructions> Instructions { get; set; } 

        public DateTime CreateTime { get; set;}

        public User createdBy {get; }



    }
}
