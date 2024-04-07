using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCstok.Models.Entity;

namespace MVCstok.Controllers
{
    public class VitrinController : Controller
    {
        // GET: Vitrin
        MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLURUNLER.ToList();
            return View(degerler);
        }
    }
}