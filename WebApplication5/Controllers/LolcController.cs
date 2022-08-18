using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class LolcController : Controller
    {
        lolschoolEntities db = new lolschoolEntities();
        public ActionResult Index()
        {
            var data=db.Records.ToList();
            return View(data);
        }
        [HttpPost]
        public ActionResult Add(Record rec)
        {
            db.Records.Add(rec);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(Record rec)
        {
            db.Records.Add(rec);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}