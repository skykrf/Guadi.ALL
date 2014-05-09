using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Guadi.Web.Edit.Models;

namespace Guadi.Web.Edit.Controllers
{
    public class ProductManageController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(ProductAddModel model)
        {
            return View();
        }
    }
}
