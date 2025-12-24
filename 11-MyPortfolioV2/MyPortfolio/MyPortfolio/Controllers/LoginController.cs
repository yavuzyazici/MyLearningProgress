using MyPortfolio.Context;
using MyPortfolio.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace MyPortfolio.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly PortfolioContext context;

        public LoginController(PortfolioContext portfolioContext)
        {
            this.context = portfolioContext;
        }


        [HttpGet]
        [Route("login")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email, string Password)
        {
            var users = context.Users.ToList();

            var myUser = users.FirstOrDefault(x=> x.Mail == email && x.Password == Password);

            if (myUser == null)
            {
                ModelState.AddModelError("", "Email or password is incorrect");
                return View("Index");
            }
            else
            {
                FormsAuthentication.SetAuthCookie(myUser.Mail, false);
                Session["UserId"] = myUser.Id;
                
                return RedirectToAction("Index", "Meta");
            }
        }
        [HttpGet]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();

            return RedirectToAction("Index", "Home");
        }
    }
}