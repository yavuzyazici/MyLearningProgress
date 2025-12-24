using MyPortfolio.Context;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class AdminLayoutController : Controller
    {
        private readonly PortfolioContext context;

        public AdminLayoutController(PortfolioContext portfolioContext)
        {
            this.context = portfolioContext;
        }
        public ActionResult Layout()
        {
            return View();
        }
        public ActionResult AdminLayoutHead()
        {
            Session["NonReadedMessagesCount"] = context.Messages.Count();
            return PartialView();
        }
        public ActionResult AdminLayoutNavbar()
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            var user = context.Users.FirstOrDefault(x => x.Id == userId);

            var messages = context.Messages.ToList();
            Session["Messages"] = messages;
            return PartialView(user);
        }
        public ActionResult AdminLayoutErrors()
        {
            return PartialView();
        }
        public ActionResult AdminLayoutFooter()
        {
            return PartialView();
        }
        public ActionResult AdminLayoutScripts()
        {
            return PartialView();
        }
    }
}