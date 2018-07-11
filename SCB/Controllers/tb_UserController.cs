using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SCB.Models;

namespace SCB.Controllers
{
    public class tb_UserController : Controller
    {
        private ScriptsControlBackgroundContainer db = new ScriptsControlBackgroundContainer();

        // GET: tb_User
        public ActionResult Index()
        {
            return View(db.tb_UserSet.ToList());
        }

        // GET: tb_User/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_User tb_User = db.tb_UserSet.Find(id);
            if (tb_User == null)
            {
                return HttpNotFound();
            }
            return View(tb_User);
        }

        // GET: tb_User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tb_User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Age,Six,Role")] tb_User tb_User)
        {
            if (ModelState.IsValid)
            {
                db.tb_UserSet.Add(tb_User);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_User);
        }

        // GET: tb_User/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_User tb_User = db.tb_UserSet.Find(id);
            if (tb_User == null)
            {
                return HttpNotFound();
            }
            return View(tb_User);
        }

        // POST: tb_User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age,Six,Role")] tb_User tb_User)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_User).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_User);
        }

        // GET: tb_User/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_User tb_User = db.tb_UserSet.Find(id);
            if (tb_User == null)
            {
                return HttpNotFound();
            }
            return View(tb_User);
        }

        // POST: tb_User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_User tb_User = db.tb_UserSet.Find(id);
            db.tb_UserSet.Remove(tb_User);
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
