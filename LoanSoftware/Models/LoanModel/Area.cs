using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanSoftware.Models.LoanModel
{
    public class Area
    {
        [Key]
        public int AreaID { get; set; }
        public string AreaName { get; set; }
        public string Comments { get; set; }
    }
}