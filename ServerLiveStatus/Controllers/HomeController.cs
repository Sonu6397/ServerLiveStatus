using ServerLiveStatus.dbo_connt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServerLiveStatus.Controllers
{
    public class HomeController : Controller
    {
        PesDataEntities4 db = new PesDataEntities4();
        public ActionResult Index()
        {
            var res = db.ServersMonetories.ToList();
            Response.AddHeader("Refresh", "5");
            return View(res);
          
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}