
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeVault.Data;
using RecipeVault.Models;

namespace RecipeVault.Controllers
{
   [Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase  // It's better to inherit from ControllerBase for API controllers
{
    private readonly ApplicationDbContext _context;

    public CategoriesController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/categories
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
    {
        return await _context.Category.ToListAsync();
    }
}


}
