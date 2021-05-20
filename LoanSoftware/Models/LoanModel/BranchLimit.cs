using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanSoftware.Models.LoanModel
{
    public class BranchLimit
    {
        [Key]
        public int LimitID { get; set; }
        public string BranchCode { get; set; }
        public decimal BrLimit { get; set; }
     //   public List<Branch> Branches { get; set; }

    }
}