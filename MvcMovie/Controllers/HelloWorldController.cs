using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public string Index()
        //{
        //    return "This is my <b>default</b> action...";
        //}
        public ActionResult Index()
        {
            return View();
        }

        //public string Welcome(string name, int ID = -1)
        //{
        //    //return "This is the Welcome action method!";
        //    //return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        //    return "hello " + name + ", id = " + ID;
        //}

        public ActionResult Welcome(string name, int NumTimes = -1)
        {
            this.ViewBag.Message = "hello " + name;
            this.ViewBag.NumTimes = NumTimes;

            return View();
        }
    }
}