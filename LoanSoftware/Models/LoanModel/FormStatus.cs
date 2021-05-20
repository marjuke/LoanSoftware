using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LoanSoftware.Models.LoanModel
{
    public class FormStatus
    {
        public int Id { get; set; }
        public int FormID { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? ForwardDate { get; set; }
        public string ApprovedUser { get; set; }
        [Column("ApprovedBranchCode")]
        public string BranchCode { get; set; }
        public string Status { get; set; }
        public string NotificationStatus { get; set; }
        public virtual Branch Branch { get; set; }



    }
}