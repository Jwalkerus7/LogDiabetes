using LogDiabetes.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogDiabetes.Controllers
{
    public class LogDiabetesController : Controller
    {
       Diabetes_Log DL = new Diabetes_Log();

        // GET: LogDiabetes
        public ActionResult Index()
        {
            return View();
        }


    }
}