using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanSoftware.Models.LoanModel
{
    public class Guarantor
    {
        [JsonProperty("GID")]
        [Key]
        public int GID { get; set; }
        [JsonProperty("FormID")]
        public int FormID { get; set; }
        [JsonProperty("GuarantorName")]
        public string GuarantorName { get; set; }
        [JsonProperty("GuarantorDateofBirth")]
        public DateTime? GuarantorDateofBirth { get; set; }
        [JsonProperty("GuarantorFather")]
        public string GuarantorFather { get; set; }
        [JsonProperty("GuarantorMother")]
        public string GuarantorMother { get; set; }
        [JsonProperty("PermanentVillage")]
        public string PermanentVillage { get; set; }
        [JsonProperty("GuarantorPO")]
        public string GuarantorPO { get; set; }
        [JsonProperty("GuarantorPS")]
        public string GuarantorPS { get; set; }
        [JsonProperty("GuarantorPermanentDistrict")]
        public string GuarantorPermanentDistrict { get; set; }
        [JsonProperty("GuarantorPresentAddress")]
        public string GuarantorPresentAddress { get; set; }
        [JsonProperty("GuarantorBusinessAddress")]
        public string GuarantorBusinessAddress { get; set; }
        [JsonProperty("GuarantorNID")]
        public string GuarantorNID { get; set; }
        [JsonProperty("GuarantorPhone")]
        public string GuarantorPhone { get; set; }
        [JsonProperty("GuarantorRelation")]
        public string GuarantorRelation { get; set; }
        [JsonProperty("GuarantorOccupation")]
        public string GuarantorOccupation { get; set; }
        [JsonProperty("GuarantorDmcbSavingName")]
        public string GuarantorDmcbSavingName { get; set; }
        [JsonProperty("GuarantorDmcbSavingAmount")]
        public decimal? GuarantorDmcbSavingAmount { get; set; }
        [JsonProperty("GuarantorDmcbLoanName")]
        public string GuarantorDmcbLoanName { get; set; }
        [JsonProperty("GuarantorDmcbLoanAmount")]
        public decimal? GuarantorDmcbLoanAmount { get; set; }
        [JsonProperty("GuarantorInstallmentAmount")]
        public decimal? GuarantorInstallmentAmount { get; set; }
        [JsonProperty("GuarantorSignature")]
        public string GuarantorSignature { get; set; }
        [JsonProperty("FilePath")]

        public string FilePath { get; set; }
        public List<MemberLoanInfo> MemberLoanInfo { get; set; }
    }
}