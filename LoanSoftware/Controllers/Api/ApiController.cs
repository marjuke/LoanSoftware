using LoanSoftware.Models;
using LoanSoftware.Models.VIEW;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoanSoftware.Controllers.Api
{
    public class ApiController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private LoanDBEntities dbViews = new LoanDBEntities();



        [HttpPost]
        public async Task<ActionResult> GetLoanWithLimitAjax()
        {
            var query = Request.Form.GetValues("search[value]").FirstOrDefault();
            int len = Convert.ToInt32(Request.Form.GetValues("length").FirstOrDefault());
            int page = Convert.ToInt32(Request.Form.GetValues("start").FirstOrDefault());
            var draw = Convert.ToInt32(Request.Form.GetValues("draw").FirstOrDefault());
            int skip = page;

            var data = await dbViews.VPendingLists.ToListAsync();
            var recordsFiltered = data.Count();
            var recordsTotal = data.Count();
            return Json(new
            {
                data,
                draw,
                recordsTotal,
                recordsFiltered
            }, JsonRequestBehavior.AllowGet);


        }
        
        
        [HttpPost]
        public async Task<ActionResult> GetForwardedLoanWithLimitAjax()
        {
            var query = Request.Form.GetValues("search[value]").FirstOrDefault();
            int len = Convert.ToInt32(Request.Form.GetValues("length").FirstOrDefault());
            int page = Convert.ToInt32(Request.Form.GetValues("start").FirstOrDefault());
            var draw = Convert.ToInt32(Request.Form.GetValues("draw").FirstOrDefault());
            int skip = page;

            var data = await dbViews.VForwardPendingLists.ToListAsync();
            var recordsFiltered = data.Count();
            var recordsTotal = data.Count();
            return Json(new
            {
                data,
                draw,
                recordsTotal,
                recordsFiltered
            }, JsonRequestBehavior.AllowGet);


        }
    }
}