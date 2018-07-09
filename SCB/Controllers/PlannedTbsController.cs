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
    public class PlannedTbsController : Controller
    {
        private ScriptsControlBackgroundContainer db = new ScriptsControlBackgroundContainer();

        // GET: PlannedTbs1
        public ActionResult Index()
        {
            var plannedTbSet = db.PlannedTbSet.Include(p => p.Priority).Include(p => p.Game).Include(p => p.User);
            return View(plannedTbSet.ToList());
        }

        // GET: PlannedTbs1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlannedTb plannedTb = db.PlannedTbSet.Find(id);
            if (plannedTb == null)
            {
                return HttpNotFound();
            }
            return View(plannedTb);
        }

        // GET: PlannedTbs1/Create
        public ActionResult Create()
        {
            ViewBag.PriorityId = new SelectList(db.PriorityTbSet, "Id", "ClassName");
            ViewBag.GameId = new SelectList(db.GameTbSet, "Id", "Name");
            ViewBag.UserId = new SelectList(db.UserTbSet, "Id", "Name");
            return View();
        }

        // POST: PlannedTbs1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,GameServer,State,CreateDate,TaskSum,TaskImmVpn,TaskWideVpn,RegisterArr,RemainArr,PriorityId,GameId,UserId,ModHard,ModVPN")] PlannedTb plannedTb)
        {
            if (ModelState.IsValid)
            {
                db.PlannedTbSet.Add(plannedTb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PriorityId = new SelectList(db.PriorityTbSet, "Id", "ClassName", plannedTb.PriorityId);
            ViewBag.GameId = new SelectList(db.GameTbSet, "Id", "Name", plannedTb.GameId);
            ViewBag.UserId = new SelectList(db.UserTbSet, "Id", "Name", plannedTb.UserId);
            return View(plannedTb);
        }

        // GET: PlannedTbs1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlannedTb plannedTb = db.PlannedTbSet.Find(id);
            if (plannedTb == null)
            {
                return HttpNotFound();
            }
            ViewBag.PriorityId = new SelectList(db.PriorityTbSet, "Id", "ClassName", plannedTb.PriorityId);
            ViewBag.GameId = new SelectList(db.GameTbSet, "Id", "Name", plannedTb.GameId);
            ViewBag.UserId = new SelectList(db.UserTbSet, "Id", "Name", plannedTb.UserId);
            return View(plannedTb);
        }

        // POST: PlannedTbs1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,GameServer,State,CreateDate,TaskSum,TaskImmVpn,TaskWideVpn,RegisterArr,RemainArr,PriorityId,GameId,UserId,ModHard,ModVPN")] PlannedTb plannedTb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(plannedTb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PriorityId = new SelectList(db.PriorityTbSet, "Id", "ClassName", plannedTb.PriorityId);
            ViewBag.GameId = new SelectList(db.GameTbSet, "Id", "Name", plannedTb.GameId);
            ViewBag.UserId = new SelectList(db.UserTbSet, "Id", "Name", plannedTb.UserId);
            return View(plannedTb);
        }

        // GET: PlannedTbs1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlannedTb plannedTb = db.PlannedTbSet.Find(id);
            if (plannedTb == null)
            {
                return HttpNotFound();
            }
            return View(plannedTb);
        }

        // POST: PlannedTbs1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlannedTb plannedTb = db.PlannedTbSet.Find(id);
            db.PlannedTbSet.Remove(plannedTb);
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
