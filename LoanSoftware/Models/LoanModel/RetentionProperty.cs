using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanSoftware.Models.LoanModel
{
    public class RetentionProperty
    {
        [Key]
        [JsonProperty("JID")]
        public int JID { get; set; }
        [JsonProperty("FormID")]
        public int FormID { get; set; }
        [JsonProperty("RetentionDescription")]
        public string RetentionDescription { get; set; }
        [JsonProperty("MoujaName")]
        public string MoujaName { get; set; }
        [JsonProperty("DocumentNo")]
        public string DocumentNo { get; set; }
        [JsonProperty("LedgerNo")]
        public string LedgerNo { get; set; }
        [JsonProperty("StainsNo")]
        public string StainsNo { get; set; }
        [JsonProperty("LandAmount")]
        public string LandAmount { get; set; }
        [JsonProperty("MinimumPrice")]
        public decimal? MinimumPrice { get; set; }
        public List<MemberLoanInfo> MemberLoanInfo { get; set; }
    }
}