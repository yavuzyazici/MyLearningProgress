using Microsoft.AspNetCore.Mvc;

namespace FirstProjectWithAPI.WebUI.ViewComponents.DefaultMenuViewComponents
{
    public class _DefatulMenuViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
