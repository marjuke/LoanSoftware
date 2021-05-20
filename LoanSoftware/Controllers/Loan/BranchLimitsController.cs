using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LoanSoftware.Models;
using LoanSoftware.Models.LoanModel;
using LoanSoftware.Models.VIEW;

namespace LoanSoftware.Controllers.Loan
{
    public class BranchLimitsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private LoanDBEntities dbViews = new LoanDBEntities();

        // GET: BranchLimits
        public ActionResult Index()
        {
            var BrLimitData = dbViews.VBranchLimits.ToList();
           return View(BrLimitData);
        }

        // GET: BranchLimits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BranchLimit branchLimit = db.BranchLimits.Find(id);
            if (branchLimit == null)
            {
                return HttpNotFound();
            }

            ViewBag.BranchCode = new SelectList(db.Branches, "BranchCode", "BranchName");
            return View(branchLimit);
        }

        // GET: BranchLimits/Create
        public ActionResult Create()
        {
            ViewBag.BranchCode = new SelectList(db.Branches, "BranchCode", "BranchName");
            return View();
        }

        // POST: BranchLimits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LimitID,BranchCode,BrLimit")] BranchLimit branchLimit)
        {
            if (ModelState.IsValid)
            {
                db.BranchLimits.Add(branchLimit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BranchCode = new SelectList(db.Branches, "BranchCode", "BranchName", branchLimit.BranchCode);
            return View(branchLimit);
        }

        // GET: BranchLimits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BranchLimit branchLimit = db.BranchLimits.Find(id);
            if (branchLimit == null)
            {
                return HttpNotFound();
            }
            ViewBag.BranchCode = new SelectList(db.Branches, "BranchCode", "BranchName");
            return View(branchLimit);
        }

        // POST: BranchLimits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LimitID,BranchCode,BrLimit")] BranchLimit branchLimit)
        {

            ViewBag.BranchCode = new SelectList(db.Branches, "BranchCode", "BranchName", branchLimit.BranchCode);

            if (ModelState.IsValid)
            {
                db.Entry(branchLimit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(branchLimit);
        }

        // GET: BranchLimits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BranchLimit branchLimit = db.BranchLimits.Find(id);
            if (branchLimit == null)
            {
                return HttpNotFound();
            }
            return View(branchLimit);
        }

        // POST: BranchLimits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BranchLimit branchLimit = db.BranchLimits.Find(id);
            db.BranchLimits.Remove(branchLimit);
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
