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

        public Ingredient ingredient { get; set;}


        public RecipeUnit unit {get; set;} 

        public string amount {get; set;}        
                
    }
}
