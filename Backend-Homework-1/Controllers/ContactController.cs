using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Homework_1.Controllers
{
    public class ContactController:Controller
    {
        public ActionResult Form(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            //return Content(id.ToString());
            return View();
        }

        public ContentResult Faq()
        {
            return Content("P127");
        }
    }
}
