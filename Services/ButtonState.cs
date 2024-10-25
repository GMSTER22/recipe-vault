using RecipeVault.Models;
using RecipeVault.Data;

namespace RecipeVault.Services;


public class ButtonState 
{
    public enum ConfirmationType { Create, Update, Delete }
    public bool ShowingConfirmationDialog { get; set; }
    public Recipe? RecipeTarget { get; set; }
    public ApplicationDbContext Context { get; set; }
    public ButtonState(ApplicationDbContext context)
    {
        Context = context;
    }

    public void ShowConfirmationDialog(Recipe recipe) {

        RecipeTarget = recipe;
        ShowingConfirmationDialog = true;
    }
    
    public void CancelConfirmationDialog()
    {
        RecipeTarget = null;

        ShowingConfirmationDialog = false;
    }

    public async Task ConfirmConfirmationDialog(ConfirmationType confirmationType)
    {
        if (RecipeTarget == null) return;
        confirmationType switch 
        {
            ConfirmationType.Create => 
            {
                Context.Recipes.Add(RecipeTarget);
            }
            ConfirmationType.Update => 
            {
                Context.Recipes.Update(RecipeTarget);
            }
            ConfirmationType.Delete =>
            {
                Context.Recipes.Delete(RecipeTarget);
            }
        }

        await Context.SaveChangesAsync();
        RecipeTarget = null;

        ShowingConfirmationDialog = false;
    }
}