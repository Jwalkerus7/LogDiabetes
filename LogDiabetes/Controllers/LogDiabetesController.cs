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
       private readonly Diabetes_LogEntities db = new Diabetes_LogEntities();

        // GET: LogDiabetes
        public ActionResult Index()
        {
            return View();
        }




    }
}