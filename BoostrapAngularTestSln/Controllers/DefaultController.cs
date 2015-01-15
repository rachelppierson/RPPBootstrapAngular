using AttributeRouting.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoostrapAngularTestSln.Controllers
{
    public class DefaultController : Controller
    {
        public DefaultController()
        {

        }

        [GET("RPPTest")]
        public ActionResult GetRPPTest()
        {
            return View();
        }
	}
}