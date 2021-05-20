using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanSoftware.Models.LoanModel
{
    public class OtherBank
    {
        [Key]
        [JsonProperty("OID")]
        public int OID { get; set; }
        [JsonProperty("FormID")]
        public int FormID { get; set; }
        [JsonProperty("NameofOtherBank")]
        public string NameofOtherBank { get; set; }
        [JsonProperty("LoanAmount")]
        public decimal? LoanAmount { get; set; }
        [JsonProperty("ExceptLoanDate")]
        public DateTime? ExceptLoanDate { get; set; }
        [JsonProperty("ExpireLoanDate")]
        public DateTime? ExpireLoanDate { get; set; }
        [JsonProperty("PresentLoanAmount")]
        public decimal? PresentLoanAmount { get; set; }
        public List<MemberLoanInfo> MemberLoanInfo { get; set; }
    }
}