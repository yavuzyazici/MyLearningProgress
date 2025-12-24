using MyPortfolio.Context;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class MetaController : Controller
    {
        private readonly PortfolioContext context;

        public MetaController(PortfolioContext portfolioContext)
        {
            this.context = portfolioContext;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var meta = context.Metas.FirstOrDefault();
            return View(meta);
        }
        [HttpPost]
        public ActionResult Index(Meta metaData)
        {
            var meta = context.Metas.FirstOrDefault();
            if (!ModelState.IsValid)
            {
                TempData["Errors"] = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                return RedirectToAction("Index", "Meta");
            }
            if (metaData.ogImage != null)
            {
                var saveLocation = "https://www.yavuzyazici.com/wwwroot/assets/img/og/";
                var fileName = Path.Combine(saveLocation, metaData.ogImage.FileName);
                metaData.ogImage.SaveAs(fileName);
                metaData.OgUrl = "/wwwroot/assets/img/og/" + metaData.ogImage.FileName;
            }
            meta.Title = metaData.Title;
            meta.Description = metaData.Description;
            meta.OgUrl = metaData.OgUrl;
            context.SaveChanges();
            return View(meta);
        }
    }
}