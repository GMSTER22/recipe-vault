using System.Collections.Generic;
using System.Linq;

namespace RecipeVault
{
    /// <summary>
    /// Represents a customized pizza as part of an order
    /// </summary>
    public class Instructions
    {

        public int Id { get; set; }

        public int Order { get; set;}

        public string Details {get; set;}                
                
    }
}
