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

        public RecipeCategory category {get; set;}

        public Boolean isPublic {get; set;}

        public List<RecipeIngredients> ingredients { get; set; } 

        public List<Instructions> instructions { get; set; } 

        public DateTime create_time { get; set;}

        public User createdBy {get; }



    }
}
