using System.Web.Mvc;

namespace BootstrapExamples.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Event(int id)
        {
            return View();
        }
    }
}