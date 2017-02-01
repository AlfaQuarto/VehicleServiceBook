using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VSB.Services.Interfaces;
using VSB.Services.Interfaces.Dictionary;

namespace VSB.Web.App.Controllers
{
    public class CarController : Controller
    {
        public ICarService Service { get; set; }

        //
        // GET: /Car/
        public ActionResult Index()
        {
            var item = this.Service.GetItem();
            return View();
        }
	}
}