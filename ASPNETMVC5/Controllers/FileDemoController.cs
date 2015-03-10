using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC5.Controllers
{
    public class FileDemoController : Controller
    {
        // GET: FileDemo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Save(string sname, string saddress, string sphone)
        {
            string filename = Server.MapPath("~/students.txt");
            string [] info = {sname,saddress,sphone};
            System.IO.File.WriteAllLines(filename,info);
            ViewBag.Name = sname;
            ViewBag.Address = saddress;
            ViewBag.Phone = sphone;
            return View("Index");
        }
        public ActionResult Open()
        {
            string[] lines = System.IO.File.ReadAllLines(Server.MapPath("~/students.txt"));
            ViewBag.Name = lines[0];
            ViewBag.Address = lines[1];
            ViewBag.Phone = lines[2];
            return View("Index");
        }
    }
}