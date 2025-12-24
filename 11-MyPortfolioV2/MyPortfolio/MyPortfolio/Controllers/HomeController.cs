using MyPortfolio.Context;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly PortfolioContext context;

        public HomeController(PortfolioContext portfolioContext)
        {
            this.context = portfolioContext;
        }

        [Route("")]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult MetaPartial()
        {
            return PartialView(context.Metas.First());
        }

        public PartialViewResult AboutPartial()
        {
            return PartialView(context.Abouts.First());
        }

        public PartialViewResult SkillsPartial()
        {
            return PartialView(context.Skills.ToList());
        }

        public PartialViewResult ProjectsPartial()
        {
            return PartialView(context.Projects.ToList());
        }

        public PartialViewResult BannerPartial()
        {
            return PartialView(context.Banners.First());
        }

        public PartialViewResult BannerSocialPartial()
        {
            return PartialView(context.SocialMedias.First());
        }

        [HttpGet]
        public PartialViewResult ContactPartial()
        {
            return PartialView(context.Contacts.First());
        }

        [HttpPost]
        public JsonResult ContactPartial(Message message)
        {
            if (ModelState.IsValid)
            {
                context.Messages.Add(message);
                context.SaveChanges();
                return Json(new { success = true, message = "Mesajınız başarıyla alındı." });
            }

            return Json(new { success = false, message = "Form bilgileri eksik veya hatalı." });
        }

        public PartialViewResult FooterPartial()
        {
            return PartialView(context.Footers.First());
        }

        public PartialViewResult FooterSocialPartial()
        {
            return PartialView(context.SocialMedias.First());
        }
    }
}