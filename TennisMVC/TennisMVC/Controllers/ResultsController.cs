using System.Web.Mvc;

namespace TennisMVC.Controllers
{
    public class ResultsController : Controller
    {
        public ResultsController()
        {

        }
        // GET: Results
        public ActionResult Index()
        {
            return View();
        }
    }
}