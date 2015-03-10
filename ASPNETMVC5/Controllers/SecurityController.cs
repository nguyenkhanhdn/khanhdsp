using ASPNETMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC5.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet()]
        public ActionResult Login()
        {
            return View();
        }
        //[HttpPost]
        //public string Login(FormCollection fields)
        //{
        //    string loginId = fields["LoginID"];
        //    string password = fields["Password"];
        //    return string.Format("Your id: {0} and password is {1}", loginId, password);
        //}

        //[HttpPost]
        //public string Login(string LoginID, string Password)
        //{
        //    string loginId = LoginID;
        //    string password = Password;
        //    return string.Format("Your id: {0} and password is {1}", loginId, password);
        //}

        //[HttpPost]
        //public string Login(string lid, string pwd)
        //{
        //    string loginId = Request.Form["LoginID"];
        //    string password = Request.Form["Password"]; ;
        //    return string.Format("Your id: <b>{0}</b> and password is <b>{1}</b>", lid, pwd);
        //}
        [HttpPost]
        public ActionResult Login(LoginInfo info)
        {
            string loginId = info.LoginID;
            string password = info.Password;
            return View(info);
        }
    }
}