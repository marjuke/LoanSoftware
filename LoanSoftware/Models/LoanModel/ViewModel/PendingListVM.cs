using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanSoftware.Models.LoanModel.ViewModel
{
    public class PendingListVM
    {
        public int FormID { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string ApprovedUser { get; set; }
        public string BranchCode { get; set; }
        public string Status { get; set; }




        public string ApprovalNo { get; set; }
        public string LoanNo { get; set; }
        public string SoftwareLoanNo { get; set; }
    }
}