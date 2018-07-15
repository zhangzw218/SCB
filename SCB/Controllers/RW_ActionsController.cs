using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCB.Controllers
{
    public class RW_ActionsController : Controller
    {
        // GET: RW_Actions
        public ActionResult Index()
        {
            return View();
        }

        // GET: RW_Actions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RW_Actions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RW_Actions/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RW_Actions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RW_Actions/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RW_Actions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RW_Actions/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
