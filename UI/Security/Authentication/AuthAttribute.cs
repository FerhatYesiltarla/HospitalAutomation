using System.Web;
using System.Web.Mvc;

namespace UI.Security.Authentication
{
    public class AuthAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!HttpContext.Current.User.Identity.IsAuthenticated)            
                filterContext.Result = new RedirectResult("/account/login");
            
        }
    }
}