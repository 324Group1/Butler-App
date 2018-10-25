using System.Web.Mvc;

namespace TheButlerV3.Areas.RecipeViewModel
{
    public class RecipeViewModelAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "RecipeViewModel";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "RecipeViewModel_default",
                "RecipeViewModel/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}