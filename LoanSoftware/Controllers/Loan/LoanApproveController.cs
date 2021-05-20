using LoanSoftware.Models;
using LoanSoftware.Models.LoanModel;
using LoanSoftware.Models.LoanModel.ViewModel;
using LoanSoftware.Models.VIEW;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoanSoftware.Controllers.Loan
{
    public class LoanApproveController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private LoanDBEntities dbViews = new LoanDBEntities();
        // GET: LoanApprove
        public ActionResult Index()
        {
            ViewBag.page = "pendingformlist";
            return View();
        }


        public ActionResult PendingFormList()
        {
            var UID = User.Identity.GetUserId();
            var branch = db.Users.Where(s => s.Id == UID).Select(s => s.BranchCode).FirstOrDefault();
            var lastformno = db.MemberLoanInfo.Count();
            var sno = branch + "-" + "01-" + (lastformno + 1).ToString();
            ViewBag.softwarenumber = sno;
            
            ViewBag.page = "pendingformlist";
            return View();
            



        }
        
        public ActionResult ForwardedPendingList()
        {
            var UID = User.Identity.GetUserId();
            var branch = db.Users.Where(s => s.Id == UID).Select(s => s.BranchCode).FirstOrDefault();
            var lastformno = db.MemberLoanInfo.Count();
            var sno = branch + "-" + "01-" + (lastformno + 1).ToString();
            ViewBag.softwarenumber = sno;
            ViewBag.page = "ForwardedPendingList";
            return View();
          

        }


        public ActionResult Approve(PendingListVM ApproveData)
        {
            try
            {
                var UID = User.Identity.GetUserId();
                var branch = db.Users.Where(s => s.Id == UID).Select(s => s.BranchCode).FirstOrDefault();

                var FormStatusForwardData = db.FormStatus.Where(s => s.FormID == ApproveData.FormID).FirstOrDefault();
                if (FormStatusForwardData==null)
                {
                    var FormStatusData = new FormStatus();
                    FormStatusData.FormID = ApproveData.FormID;
                    FormStatusData.BranchCode = branch;
                    FormStatusData.ApprovedDate = DateTime.Now.Date;
                    FormStatusData.ApprovedUser = UID;
                    FormStatusData.Status = "a";
                    db.FormStatus.Add(FormStatusData);
                }
                else
                {
                    FormStatusForwardData.BranchCode=branch;
                    FormStatusForwardData.ApprovedDate = DateTime.Now.Date;
                    FormStatusForwardData.ApprovedUser = UID;
                    FormStatusForwardData.Status = "a";
                    db.Entry(FormStatusForwardData).State = EntityState.Modified;
                }
                

                var memberinfdata = db.MemberLoanInfo.FirstOrDefault(s => s.FormID == ApproveData.FormID);
                if (memberinfdata != null)
                {
                    //db.MemberLoanInfo.Remove(memberinfdata);
                   // db.SaveChanges();
                    memberinfdata.LoanNo = ApproveData.LoanNo;
                    memberinfdata.ApprovalNo = ApproveData.ApprovalNo;
                    memberinfdata.SoftwareLoanNo = ApproveData.SoftwareLoanNo;
                }
                db.Entry(memberinfdata).State = EntityState.Modified;
                //db.MemberLoanInfo.Add(memberinfdata);
                
                db.SaveChanges();
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                return Json(0, JsonRequestBehavior.AllowGet);
            }
            
        }

        public ActionResult Forward(int id)
        {
            
      
                var FormStatusData = new FormStatus();
                FormStatusData.FormID = id;
                FormStatusData.Status = "f";
                FormStatusData.ForwardDate = DateTime.Now.Date;
                db.FormStatus.Add(FormStatusData);
                db.SaveChanges();
                return Json(1, JsonRequestBehavior.AllowGet);
            
            
        }
        
        public ActionResult Reject(int id)
        {
            var FormStatusData = new FormStatus();
            FormStatusData.FormID = id;
            FormStatusData.Status = "r";
            FormStatusData.ApprovedDate = DateTime.Now.Date;

            db.FormStatus.Add(FormStatusData);
            db.SaveChanges();
            return Json(1, JsonRequestBehavior.AllowGet);
        }
    }
}