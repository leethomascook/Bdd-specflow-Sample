using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bdd_specflow_Sample.Web.Models.Rating;

namespace Bdd_specflow_Sample.Web.Controllers
{
    public class RatingController : Controller
    {
        //
        // GET: /Rating/

        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs, HttpGet]
        public JsonResult Rate(string userToken, int rating, Guid actionId)
        {
            var resultModel = new RateActionModel();

            return new JsonResult() { Data = resultModel };
        }

        [AcceptVerbs, HttpPost]
        public JsonResult Rate(string userToken, int rating, Guid actionId)
        {
            var resultModel = new RateActionModel();

            return new JsonResult() { Data = resultModel };
        }

    }
}
