using SistemaWebTransporteMVC.Data;
using SistemaWebTransporteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaWebTransporteMVC.Controllers
{
    public class AutoController : Controller
    {
        private DbContextTransporte context = new DbContextTransporte();
        // GET: Auto
        public ActionResult Index()
        {

            return View("Index",context.Autos.ToList());
        }

         public ActionResult Create()
        {
            Auto auto = new Auto();
            return View("Create", auto);

        }

        [HttpPost]

        public ActionResult Create(Auto auto)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", auto);
            }
            else
            {
                context.Autos.Add(auto);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        [ActionName("Detalle")]
        public ActionResult Detalle(int id)
        {
            Auto auto = context.Autos.Find(id);

            if (auto != null)
            {
                return View("Detalle", auto);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {

            Auto auto  = context.Autos.Find(id);

            if (auto == null)
            {
                return HttpNotFound();

            }

            return View("Delete", auto);

        }



        [HttpPost]
        [ActionName("Delete")]

        //POST: /auto/Delete

        public ActionResult DeleteConfirmed(int id)
        {
            Auto auto = context.Autos.Find(id);

            if (auto != null)
            {
                context.Autos.Remove(auto);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}