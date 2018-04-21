using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashCollector.Controllers
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
            //dynamic object that passes information between controller and view, only available if you return a view at the end of the method
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us";

            return View();
        }

        //public ActionResult Schedule(string user)
        //{
        //    //var schedule = ;
        //    //return ContentResult; this could return user content that shows exact numbers
            //would you return a FIle Result? 
        //}

        //public ActionResult GoogleMap()
        //{
        //    //pass through google API, show a partial view
        //}
        ////partial result can view a part of a webpage


        //[HttpGet]

        //Need to create controllers
        //enter my info and sign up to receive a pickup

        //Registered user - change pickup to fit schedule
        //see how much you owe this month
        //specify a period of time you don't want a pickup

        //Trash worker - see customers on my route using google maps integration
        //see which customers in zip code are receiving a pickup today


        //Authorize Attribute - controller Level Filter
        [Authorize (Roles=Employee)]
        //create a table that shows employees
        //can show [HandleError which would allow you to give exceptions]

    }
}