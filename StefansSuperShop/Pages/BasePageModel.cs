using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StefansSuperShop.Pages;

public class BasePageModel : PageModel
{
    public bool IsAlreadySubscriber { get; set; }

    public BasePageModel()
    {
        
    }

    public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
    {
        // If logged in OCH redan subscriber - kolla mot dbContext
        IsAlreadySubscriber = true;
        base.OnPageHandlerExecuting(context);
    }
}