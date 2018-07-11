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
    public class tb_PlanController : Controller
    {
        private ScriptsControlBackgroundContainer db = new ScriptsControlBackgroundContainer();

        // GET: tb_Plan
        public ActionResult Index()
        {
            return View(db.tb_PlanSet.ToList());
        }

        // GET: tb_Plan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Plan tb_Plan = db.tb_PlanSet.Find(id);
            if (tb_Plan == null)
            {
                return HttpNotFound();
            }
            return View(tb_Plan);
        }

        // GET: tb_Plan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tb_Plan/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,CreateDate,ModHard,ModVpn,TaskNewArr,TaskKeepArr")] tb_Plan tb_Plan)
        {
            if (ModelState.IsValid)
            {
                db.tb_PlanSet.Add(tb_Plan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Plan);
        }

        // GET: tb_Plan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Plan tb_Plan = db.tb_PlanSet.Find(id);
            if (tb_Plan == null)
            {
                return HttpNotFound();
            }
            return View(tb_Plan);
        }

        // POST: tb_Plan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,CreateDate,ModHard,ModVpn,TaskNewArr,TaskKeepArr")] tb_Plan tb_Plan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Plan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Plan);
        }

        // GET: tb_Plan/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Plan tb_Plan = db.tb_PlanSet.Find(id);
            if (tb_Plan == null)
            {
                return HttpNotFound();
            }
            return View(tb_Plan);
        }

        // POST: tb_Plan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Plan tb_Plan = db.tb_PlanSet.Find(id);
            db.tb_PlanSet.Remove(tb_Plan);
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
