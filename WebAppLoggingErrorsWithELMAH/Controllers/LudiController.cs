using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppLoggingErrorsWithELMAH.DAL;
using WebAppLoggingErrorsWithELMAH.Models;
using System.Diagnostics;

namespace WebAppLoggingErrorsWithELMAH.Controllers
{
    public class LudiController : Controller
    {
        private LifelongLearningContext db = new LifelongLearningContext();


        public ActionResult Test()
        {
            var ludi = db.Ludi;
            Debug.Write(ludi.Count());

            //throw new Exception("Test exception");

            return View(ludi);
        }

        // GET: Ludi
        public async Task<ActionResult> Index()
        {
            return View(await db.Ludi.ToListAsync());
        }

        // GET: Ludi/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ludi ludi = await db.Ludi.FindAsync(id);
            if (ludi == null)
            {
                return HttpNotFound();
            }
            return View(ludi);
        }

        // GET: Ludi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ludi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "PersonID,Name,PhoneID")] Ludi ludi)
        {
            if (ModelState.IsValid)
            {
                db.Ludi.Add(ludi);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(ludi);
        }

        // GET: Ludi/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ludi ludi = await db.Ludi.FindAsync(id);
            if (ludi == null)
            {
                return HttpNotFound();
            }
            return View(ludi);
        }

        // POST: Ludi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "PersonID,Name,PhoneID")] Ludi ludi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ludi).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ludi);
        }

        // GET: Ludi/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ludi ludi = await db.Ludi.FindAsync(id);
            if (ludi == null)
            {
                return HttpNotFound();
            }
            return View(ludi);
        }

        // POST: Ludi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Ludi ludi = await db.Ludi.FindAsync(id);
            db.Ludi.Remove(ludi);
            await db.SaveChangesAsync();
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
