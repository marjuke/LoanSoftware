using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanSoftware.Models
{
    public class Branch
    {
        public DateTime? OppeningDate { get; set; }
        public string ZoneCode { get; set; }
        [Key]
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string BrManager { get; set; }
        public string Comments { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
    }
}