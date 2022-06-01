using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Homework_1.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            //ViewResult view = new ViewResult { ViewName = "HomePage" };
            //return View();
            return new ViewResult { ViewName = "HomePage" };
        }
        public ActionResult About()
        {
            return View();
        }

    }
}
