using System.Collections.Generic;
using System.Linq;

namespace RecipeVault
{
    /// <summary>
    /// Represents a customized pizza as part of an order
    /// </summary>
    public class RecipeIngredients
    {

        public int Id { get; set; }

        public Ingredient Ingredient { get; set;}


        public RecipeUnit Unit {get; set;} 

        public string Amount {get; set;}        
                
    }
}
