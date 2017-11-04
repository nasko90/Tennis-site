using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TennisMVC.Controllers
{
    public class AddMatchController : Controller
    {
        private readonly ITennisRepository _tennisRepository;
        public AddMatchController()
        {
            _tennisRepository = new TennisRepository();
        }

        // GET: AddMatch
        public ActionResult Index()
        {
            GetSurfaceTypes();
            return View();
        }

        public JsonResult GetSurfaceTypes()
        {
            var surfaces = _tennisRepository.GetSurfaceTypes();
            return Json(surfaces, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetPlayersNames()
        {
            var playersNames = _tennisRepository.GetPlayersNames();
            return Json(playersNames, JsonRequestBehavior.AllowGet);
        }
    }
}