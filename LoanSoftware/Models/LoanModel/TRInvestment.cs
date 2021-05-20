using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanSoftware.Models.LoanModel
{
    public class TRInvestment
    {
        [Key]
        [JsonProperty("TID")]
        public int TID { get; set; }
        [JsonProperty("FormID")]
        public int FormID { get; set; }
        [JsonProperty("TRDate")]
        public DateTime? TRDate { get; set; }
        [JsonProperty("SlNo")]
        public string SlNo { get; set; }
        [JsonProperty("ProductDescription")]
        public string ProductDescription { get; set; }
        [JsonProperty("QTY")]
        public string QTY { get; set; }
        [JsonProperty("Buyamount")]
        public decimal? Buyamount { get; set; }
        [JsonProperty("TRSalesAmount")]
        public decimal? TRSalesAmount { get; set; }
        [JsonProperty("MinimumProfit")]
        public string MinimumProfit { get; set; }
        public List<MemberLoanInfo> MemberLoanInfo { get; set; }
    }
}