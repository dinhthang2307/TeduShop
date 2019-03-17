using System.Web.Mvc;

namespace TeduShop.Web.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// About
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        /// <summary>
        /// Contact
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        /// <summary>
        /// Footer
        /// </summary>
        /// <returns></returns>
        [ChildActionOnly]
        public ActionResult Footer()
        {
            return PartialView();
        }

        /// <summary>
        /// Header
        /// </summary>
        /// <returns></returns>
        [ChildActionOnly]
        public ActionResult Header()
        {
            return PartialView();
        }

        /// <summary>
        /// Category
        /// </summary>
        /// <returns></returns>
        [ChildActionOnly]
        public ActionResult Category()
        {
            return PartialView();
        }
    }
}