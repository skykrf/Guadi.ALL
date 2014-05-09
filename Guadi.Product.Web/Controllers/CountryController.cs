using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Guadi.Common.Tools;
using Guadi.Product.Models.ContractModels.Area;
using Guadi.Product.BLL;

namespace Guadi.Product.Web.Controllers
{
    [Export]
    public class CountryController : Controller
    {
        #region 属性

        [Import]
        public IAreaContract AreaContract { get; set; }

        #endregion

        public ActionResult Index()
        {
            CountryEditModel model=new CountryEditModel()
                {
                    Latitude = 10.11,
                    Longitude = 11.1,
                    Name = "中国"
                };
            var result = AreaContract.AddNewCountry(model);
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CountryEditModel model)
        {
            var result = AreaContract.AddNewCountry(model);
            if(result.ResultType==OperationResultType.Success)
            return RedirectToAction("Index");
            else
            {
                return View();
            }
        }

    }
}
