using Microsoft.AspNetCore.Mvc;

namespace FirstProjectWithAPI.WebUI.ViewComponents
{
    public class _HeadDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

