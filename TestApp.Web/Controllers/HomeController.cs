using System.Web.Mvc;

namespace TestApp.Web.Controllers
{
    public class HomeController : TestAppControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}