using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Guadi.Web.Edit.Models;

namespace Guadi.Web.Edit.Controllers
{
    public class UserManageController : Controller
    {

        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Add(UserModel model)
        {
            return View();
        }


        [HttpGet]
        public JsonResult GetUserList(int rows = 10, int page = 1)
        {

            Dictionary<object, object> data = new Dictionary<object, object>();
            data.Add("total",200);
            var list = new List<UserModel>();
            UserModel p = new UserModel()
                {
                    ContractEmail = "sunkai@idx.com.cn",
                    ContractNumber = "18721856450",
                    Id = 1000,
                    Level = "金牌会员",
                    NickName = "水帘洞行者孙",
                    Status = "正常"
                };

            list.Add(p);
            list.Add(p);
            list.Add(p);
            list.Add(p);
            list.Add(p);
            list.Add(p);
            list.Add(p);
            list.Add(p);
            list.Add(p);
            list.Add(p);
            list.Add(p);
            list.Add(p);
            data.Add("rows",list);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}
