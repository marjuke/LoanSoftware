using LoanSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoanSoftware.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            ViewBag.page = "Dashboard";
            ViewBag.BranchList = db.Branches.Count();
            ViewBag.TotalLoanReg = db.MemberLoanInfo.Count();

            ViewData["TotalLoanAmount"] = db.MemberLoanInfo.Sum(s => s.LoanAmountTotal);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}