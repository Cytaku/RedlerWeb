using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedlerWeb.Controllers
{
    public class HolaController : Controller
    {
        // GET: Hola
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HolaMundo()
        {

            return View();
        }
    }
}