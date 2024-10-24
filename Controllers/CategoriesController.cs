using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeVault.Data;
using RecipeVault.Models;
namespace RecipeVault.Controllers
{
    [Route("/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase  // It's better to inherit from ControllerBase for API controllers
    {
         private readonly ApplicationDbContext _dbContext;
        

        public CategoriesController(IDbContextFactory<ApplicationDbContext> dbContext)
        {
            _dbContext = dbContext.CreateDbContext();
        }

        // GET: api/categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return  await _dbContext.Category.ToListAsync();
        }
    }


}
