using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Guadi.Product.Web.Controllers
{
    public class PartialController : Controller
    {
        public ActionResult Head()
        {
            return PartialView();
        }

        public ActionResult Left()
        {
            return PartialView();
        }

        public ActionResult Foot()
        {
            return PartialView();
        }

    }
}
