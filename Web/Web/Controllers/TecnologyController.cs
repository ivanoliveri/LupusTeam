using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class TecnologyController : Controller
    {
        //
        // GET: /Tecnology/

        public ActionResult IndexFrontend()
        {
            return View("Frontend");
        }

        public ActionResult IndexBackend()
        {
            return View("Backend");
        }

        public ActionResult IndexDatabase()
        {
            return View("Database");
        }

    }
}
