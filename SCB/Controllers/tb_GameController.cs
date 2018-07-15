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
    public class tb_GameController : Controller
    {
        private ScriptsControlBackgroundContainer db = new ScriptsControlBackgroundContainer();

        // GET: tb_Game
        public ActionResult Index()
        {
            return View(db.tb_GameSet.ToList());
        }

        // GET: tb_Game/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Game tb_Game = db.tb_GameSet.Find(id);
            if (tb_Game == null)
            {
                return HttpNotFound();
            }
            return View(tb_Game);
        }

        // GET: tb_Game/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tb_Game/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,OSType")] tb_Game tb_Game)
        {
            if (ModelState.IsValid)
            {
                tb_Game.AddDate = DateTime.Now;
                db.tb_GameSet.Add(tb_Game);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Game);
        }

        // GET: tb_Game/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Game tb_Game = db.tb_GameSet.Find(id);
            if (tb_Game == null)
            {
                return HttpNotFound();
            }
            return View(tb_Game);
        }

        // POST: tb_Game/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,OSType")] tb_Game tb_GameI)
        {
            if (ModelState.IsValid)
            {
                tb_Game tb_GameTemp = db.tb_GameSet.Find(tb_GameI.Id);
                tb_GameTemp.Name = tb_GameI.Name;
                tb_GameTemp.OSType = tb_GameI.OSType;
                db.Entry(tb_GameTemp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: tb_Game/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Game tb_Game = db.tb_GameSet.Find(id);
            if (tb_Game == null)
            {
                return HttpNotFound();
            }
            return View(tb_Game);
        }

        // POST: tb_Game/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Game tb_Game = db.tb_GameSet.Find(id);
            db.tb_GameSet.Remove(tb_Game);
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
