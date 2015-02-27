using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeIsMoney.Controllers
{
    public class FireController : Controller
    {
        //
        // GET: /Fire/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Fire/Welcome/
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + ID);
        }
	}
}