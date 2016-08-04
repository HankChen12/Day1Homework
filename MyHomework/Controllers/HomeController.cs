using System;
using System.Web.Mvc;

namespace Session01_Homework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Account()
        {
            return View();
        }

        public ActionResult ForAccount(int i, int a)
        {
            ViewData.Model = string.Format("{0},{1},{2},{3}", i, i % 2 == 0 ? "收入" : "支出", DateTime.Now.AddDays(i - 1).ToString("yyyy-MM-dd"), string.Format("${0}", a));
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "你好,我是陳漢克";

            return View();
        }
    }
}