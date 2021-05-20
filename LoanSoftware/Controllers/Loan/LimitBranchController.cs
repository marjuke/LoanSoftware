using LoanSoftware.Models;
using LoanSoftware.Models.CommonInformation;
using LoanSoftware.Models.LoanModel;
using LoanSoftware.Models.VIEW;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoanSoftware.Controllers.Loan
{
    public class LimitBranchController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private LoanDBEntities dbViews = new LoanDBEntities();
        // GET: LimitBranch
        public ActionResult LimitBranch()
        {
            ViewBag.BranchCode = LoadComboBox.LoadAllBranch();
            //ViewBag.BranchCode = new SelectList(db.Branches, "BranchCode", "BranchName");

            ViewBag.BranchLimitList = dbViews.VBranchLimits.OrderBy(s=>s.BranchCode).ToList(); 
            return View();
        }
        public ActionResult SearchByLimitBranchID(int LimitID)
        {
            var data = db.BranchLimits.FirstOrDefault(x => x.LimitID == LimitID);

            return Json(data, JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult SearchByBranchCode(string brnachCode)
        {
            var data = db.BranchLimits.FirstOrDefault(x => x.BranchCode == brnachCode);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SaveUpdate(BranchLimit BranchLimitData)
        {
            if (BranchLimitData.LimitID!=0)
            {
                db.Entry(BranchLimitData).State = EntityState.Modified;
                db.SaveChanges();
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            db.BranchLimits.Add(BranchLimitData);
            db.SaveChanges();
            return Json(0, JsonRequestBehavior.AllowGet);
        }


        public ActionResult DeleteByLimitID(int limitID)
        {
            var data = db.BranchLimits.FirstOrDefault(s => s.LimitID == limitID);
            if (data!=null)
            {
                db.BranchLimits.Remove(data);
                db.SaveChanges();
                return Json(0, JsonRequestBehavior.AllowGet);
            }
            return Json(1, JsonRequestBehavior.AllowGet);
        }
    }
}