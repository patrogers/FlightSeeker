using FlightSeeker.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlightSeeker.Controllers
{
    public class LookUpController : Controller
    {
        private ILookUp LookUp;
        // GET: LookUp
        public ActionResult Index()
        {
            var result = LookUp.GetData();
            return View(result);
        }

        public LookUpController ()
        {
            LookUp = new JetStarLookUp();
        }

    }
}