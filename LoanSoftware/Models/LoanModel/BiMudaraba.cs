using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanSoftware.Models.LoanModel
{
    public class BiMudaraba
    {
        [JsonProperty("BIID")]
        [Key]
        public int BIID { get; set; }
        [JsonProperty("FormID")]
        public int FormID { get; set; }
        [JsonProperty("TypeofInvestment")]
        [MaxLength(30)]
        public string TypeofInvestment { get; set; }
        [JsonProperty("DescriptionofInvestment")]
        [MaxLength(200)]
        public string DescriptionofInvestment { get; set; }
        [JsonProperty("InvestmentAmount")]
        public decimal? InvestmentAmount { get; set; }
        [JsonProperty("ExecptDate")]
        public DateTime? ExecptDate { get; set; }
        [JsonProperty("ExpireDate")]
        public DateTime? ExpireDate { get; set; }
        [JsonProperty("PresentStatus")]
        [MaxLength(200)]
        public string PresentStatus { get; set; }
        [JsonProperty("OwnBussinessAsset")]
        public decimal? OwnBussinessAsset { get; set; }
        [JsonProperty("GodownStock")]
        public decimal? GodownStock { get; set; }
        [JsonProperty("AverageSales")]
        public decimal? AverageSales { get; set; }
        [JsonProperty("AverageIncome")]
        public decimal? AverageIncome { get; set; }

        public List<MemberLoanInfo> MemberLoanInfo { get; set; }
    }
}