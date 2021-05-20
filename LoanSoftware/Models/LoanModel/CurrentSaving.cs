using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanSoftware.Models.LoanModel
{
    public class CurrentSaving
    {
        [Key]
        [JsonProperty("CUID")]
        public int CUID { get; set; }  
        [JsonProperty("FormID")]
        public int FormID { get; set; }
        [JsonProperty("TypesofSavings")]
        public string TypesofSavings { get; set; }
        [JsonProperty("AccountNo")]
        public string AccountNo { get; set; }
        [JsonProperty("AccountopenDate")]
        public DateTime? AccountopenDate { get; set; }
        [JsonProperty("InstallmentAmount")]
        public decimal? InstallmentAmount { get; set; }
        [JsonProperty("PresentAmount")]
        public decimal? PresentAmount { get; set; }
        [JsonProperty("Status")]
        public string Status { get; set; }
        public List<MemberLoanInfo> MemberLoanInfo { get; set; }
    }
}