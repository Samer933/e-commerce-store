using e_commerce_store.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace e_commerce_store.Controllers
{
    public class HomeController : Controller
    {

        //  private readonly UserManager<ApplicationUser> _userManager;
        public HomeController()
        {



        }




        public ActionResult Index()
        {


            // ... your other code

            return View();
        }

        public ActionResult About()
        {

            if (User.Identity.IsAuthenticated)
            {
                var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var user = userManager.FindByName(User.Identity.Name);
                if (user != null)
                {
                    string userEmail = user.Email;
                    ViewBag.MM = userEmail;
                    // Use the userEmail as needed
                }
            }
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}