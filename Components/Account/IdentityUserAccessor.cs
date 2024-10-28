using Microsoft.AspNetCore.Identity;
using RecipeVault.Data;

namespace RecipeVault.Components.Account;

internal sealed class IdentityUserAccessor(UserManager<ApplicationUser> userManager, IdentityRedirectManager redirectManager)
{

    // Make sure required user is logged in
    public async Task<ApplicationUser> GetRequiredUserAsync(HttpContext context)
    {
        var user = await userManager.GetUserAsync(context.User);

        if (user is null)
        {
            redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
        }

        return user;
    }

    // Gets logged in user, if no user is logged in allows null to be returned. Only use when user is not requred!
      public async Task<ApplicationUser?> GetUserAsync(HttpContext context)
    {
        var user = await userManager.GetUserAsync(context.User);

        return user;
    }
}
