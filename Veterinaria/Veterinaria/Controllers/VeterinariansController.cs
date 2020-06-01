using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Veterinaria.Models;
using Veterinaria.Clase;

namespace Veterinaria.Controllers
{
    public class VeterinariansController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Veterinarians
        public ActionResult Index()
        {
            return View(db.Veterinarians.ToList());
        }

        // GET: Veterinarians/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veterinarian veterinarian = db.Veterinarians.Find(id);
            if (veterinarian == null)
            {
                return HttpNotFound();
            }
            return View(veterinarian);
        }

        // GET: Veterinarians/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Veterinarians/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Veterinarian veterinarian)
        {
            if (ModelState.IsValid)
            {
                var vet = new ApplicationUser
                {
                    Name = veterinarian.ApplicationUser.Name
                };
                Utilities.CreateUserAsp(vet.Email, "123456", "Veterinarian");

                db.Veterinarians.Add(veterinarian);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(veterinarian);
        }

        // GET: Veterinarians/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veterinarian veterinarian = db.Veterinarians.Find(id);
            if (veterinarian == null)
            {
                return HttpNotFound();
            }
            return View(veterinarian);
        }

        // POST: Veterinarians/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,ImgUrl")] Veterinarian veterinarian)
        {
            if (ModelState.IsValid)
            {
                db.Entry(veterinarian).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(veterinarian);
        }

        // GET: Veterinarians/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veterinarian veterinarian = db.Veterinarians.Find(id);
            if (veterinarian == null)
            {
                return HttpNotFound();
            }
            return View(veterinarian);
        }

        // POST: Veterinarians/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Veterinarian veterinarian = db.Veterinarians.Find(id);
            db.Veterinarians.Remove(veterinarian);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
