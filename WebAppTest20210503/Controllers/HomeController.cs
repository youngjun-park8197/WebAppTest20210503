using jsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppTest20210503.Controllers
{
    public class HomeController : Controller
    {
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
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your Login Page";

            string uid = Request.QueryString["UID"];
            string pwd = Request.QueryString["PWD"];

            if(uid != null) // id 검증 
            {
                SQLDB db = new SQLDB(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KOSTA\source\repos\MyDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                if(db.Get($"select password from users where uid='{uid}'").ToString().Trim() == jslib.GetEncrypt(pwd))
                {
                    return RedirectToAction("Index");
                }

            }

            return View();
        }
    }
}