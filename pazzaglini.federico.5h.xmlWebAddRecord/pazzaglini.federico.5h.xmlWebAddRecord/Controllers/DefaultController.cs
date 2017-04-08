using pazzaglini.federico._5h.xmlWebAddRecord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Web.Hosting;

namespace pazzaglini.federico._5h.xmlWebAddRecord.Controllers
{
    public class DefaultController : Controller
    {
        private object hostingEnvironment;

        // GET: Default
        public ActionResult Index()
        {
           // List<persona> persone = new List<persona>();
            string nomeFile = HostingEnvironment.MapPath(@"~/App_Data/Dati.xml");
            XElement data = XElement.Load(nomeFile);

            var persone = from p in data.Element("persone").Elements("persona")
                                select new persona(p);

            return View(persone);
        }
    }
}