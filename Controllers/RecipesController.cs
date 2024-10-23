using System.Linq.Expressions;
using System.Numerics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeVault.Data;
using RecipeVault.Models;

namespace RecipeVault.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecipesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Recipes/5
        [HttpGet]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Get([FromQuery] BigInteger recipeId)
        {
            if (recipeId == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipe
                .FirstOrDefaultAsync(r => r.Id == recipeId);
            if(recipe == null || !RecipeOwnedByUserOrPublic(recipeId))
            {
                return NotFound();
            }

            return View(recipe);
        }

         // POST: Recipes
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<Recipe>> Create([FromBody] Recipe recipe)
        {
            if (User.Identity.Name == null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            recipe.UserId = User.Identity.Name;
            var createdRecipe = _context.Add(recipe);
            await _context.SaveChangesAsync();
            return createdRecipe.Entity;
        }

        // PUT: Recipes/5
        [HttpPut("{id}")]
        [ValidateAntiForgeryToken]
        public async  Task<ActionResult<Recipe>> Edit([FromRoute]BigInteger id, [FromBody] Recipe recipe)
        {
            if (id != recipe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var updatedRecipe = _context.Update(recipe);
                    await _context.SaveChangesAsync();
                    return updatedRecipe.Entity;
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipeOwnedByUser(recipe.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return BadRequest();
        }

        // GET: Recipes/Delete/5
        [HttpDelete("{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute]BigInteger Id)
        {
            var recipe = await _context.Recipe.FindAsync(Id);
            if (recipe != null)
            {
                _context.Recipe.Remove(recipe);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return NotFound();

        }

        private bool RecipeOwnedByUser(BigInteger id)
        {
            return _context.Recipe.Any(r => r.Id == id && r.UserId == User.Identity.Name);
        }

        private bool RecipeOwnedByUserOrPublic(BigInteger id)
        {
            return _context.Recipe.Any(r => r.Id == id && (r.UserId == User.Identity.Name || r.IsPublic));
        }
    }
}

