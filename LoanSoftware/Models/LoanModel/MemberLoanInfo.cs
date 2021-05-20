using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LoanSoftware.Models.LoanModel
{
    public class MemberLoanInfo
    {
        [JsonProperty("MID")]
        [Key]
        public int MID { get; set; }
        [JsonProperty("FormID")]
        [Required]
        public int FormID { get; set; }
        [JsonProperty("ApprovalNo")]
        [MaxLength(50)]
        public string ApprovalNo { get; set; }
        [JsonProperty("Date")]
        public DateTime? Date { get; set; }
        [JsonProperty("MemberNo")]
        [MaxLength(50)]
        public string MemberNo { get; set; }
        [JsonProperty("ShareNumber")]
        [MaxLength(50)]
        public string ShareNumber { get; set; }
        [JsonProperty("ShareAmount")]
        public decimal? ShareAmount { get; set; }
        [JsonProperty("FieldNo")]
        public string FieldNo { get; set; }
        [JsonProperty("LoanNo")]
        public string LoanNo { get; set; }
        [JsonProperty("SoftwareLoanNo")]
        public string SoftwareLoanNo { get; set; }
        [JsonProperty("BranchCode")]
        public string BranchCode { get; set; }
        [JsonProperty("Amount")]
        public decimal? Amount { get; set; }
        [JsonProperty("InvestmentNo")]
        public string InvestmentNo { get; set; }
        [JsonProperty("AplicantName")]
        public string AplicantName { get; set; }
        [JsonProperty("DateofBirth")]
        public DateTime? DateofBirth { get; set; }
        [JsonProperty("FatherName")]
        public string FatherName { get; set; }
        [JsonProperty("MotherName")]
        public string MotherName { get; set; }
        [JsonProperty("NID")]
        [Required]
        public string NID { get; set; }
        [JsonProperty("Village")]
        [MaxLength(50)]
        public string Village { get; set; }
        [JsonProperty("PO")]
        [MaxLength(50)]
        public string PO { get; set; }
        [JsonProperty("PS")]
        [MaxLength(50)]
        public string PS { get; set; }
        [JsonProperty("District")]
        [MaxLength(50)]
        public string District { get; set; }
        [JsonProperty("PresentAddress")]
        [MaxLength(50)]
        public string PresentAddress { get; set; }
        [JsonProperty("BusinessAddress")]
        [MaxLength(50)]
        public string BusinessAddress { get; set; }
        [JsonProperty("PhoneNumber")]
        [MaxLength(50)]
        public string PhoneNumber { get; set; }
        [JsonProperty("MobileNumber")]
        [MaxLength(50)]
        public string MobileNumber { get; set; }
        [JsonProperty("Email")]
        [MaxLength(50)]
        public string Email { get; set; }
        [JsonProperty("BusinessNature")]
        [MaxLength(50)]
        public string BusinessNature { get; set; }
        [JsonProperty("BusinessType")]
        [MaxLength(50)]
        public string BusinessType { get; set; }
        [JsonProperty("MotiveofLoan")]
        [MaxLength(200)]
        public string MotiveofLoan { get; set; }
        [JsonProperty("DateOwn")]
        public DateTime? DateOwn { get; set; }
        [JsonProperty("DateRent")]
        public DateTime? DateRent { get; set; }
        [JsonProperty("AmountRent")]
        public decimal? AmountRent { get; set; }
        [JsonProperty("LastDate")]
        public DateTime? LastDate { get; set; }
        [JsonProperty("NameRent")]
        [MaxLength(100)]
        public string NameRent { get; set; }
        [JsonProperty("OwnAmount")]
        public decimal? OwnAmount { get; set; }
        [JsonProperty("MonthlyAvarageIncome")]
        public decimal? MonthlyAvarageIncome { get; set; }
        [JsonProperty("MLFile")]
        public string MLFile { get; set; }
        [JsonProperty("DailySaleAmount")]
        public decimal? DailySaleAmount { get; set; }
        [JsonProperty("DailyProfit")]
        public decimal? DailyProfit { get; set; }
        [JsonProperty("DailyIncome")]
        public decimal? DailyIncome { get; set; }
        [JsonProperty("MonthlySaleAmount")]
        public decimal? MonthlySaleAmount { get; set; }
        [JsonProperty("MonthlyProfit")]
        public decimal? MonthlyProfit { get; set; }
        [JsonProperty("MonthlyIncome")]
        public decimal? MonthlyIncome { get; set; }
        [JsonProperty("MAccountNo")]
        //14
        public string MAccountNo { get; set; }
        [JsonProperty("AmountInAccount")]
        public decimal? AmountInAccount { get; set; }
        [JsonProperty("LoanAmountTotal")]


        public decimal? LoanAmountTotal { get; set; }
        [JsonProperty("LoanInstallmentAmount")]
        public decimal? LoanInstallmentAmount { get; set; }
        [JsonProperty("LoanInstallment")]
        public string LoanInstallment { get; set; }
        [JsonProperty("LoanRecoveryDays")]
        public int? LoanRecoveryDays { get; set; }
        [JsonProperty("LoanProvideDate")]
        public DateTime? LoanProvideDate { get; set; }
        //new
        [JsonProperty("LoanType")]
        public string LoanType { get; set; }
        [JsonProperty("LoanSubType")]
        public string LoanSubType { get; set; }
        
        [JsonProperty("LoanInstallmentType")]
        public string LoanInstallmentType { get; set; }

        [JsonProperty("DailySavingType")]
        public string DailySavingType { get; set; }
        [JsonProperty("DefalterBokeya")]
        public decimal? DefalterBokeya { get; set; }
        [JsonProperty("DefalterStithi")]
        public decimal? DefalterStithi { get; set; }
        [JsonProperty("DailySaving")]
        public decimal? DailySaving { get; set; }
        [JsonProperty("DailySaving2")]
        public decimal? DailySaving2 { get; set; }
        [JsonProperty("DailySavingYear")]
        public int? DailySavingYear { get; set; }
        [JsonProperty("shikkhabibahDuration")]
        public int? shikkhabibahDuration { get; set; }
        [JsonProperty("MonthlySavingAmount")]
        public decimal? MonthlySavingAmount { get; set; }
        [JsonProperty("MonthlySavingAmountYear")]
        public int? MonthlySavingAmountYear { get; set; }







        
    }
}