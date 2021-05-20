using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanSoftware.Models.LoanModel.ViewModel
{
    public class MemberLoanInfoVM
    {
        #region MemberLoanFrom
        public int MID { get; set; }
        public int FormID { get; set; }
        public string ApprovalNo { get; set; }
        public DateTime Date { get; set; }
        public string MemberNo { get; set; }
        public string ShareNumber { get; set; }
        public string ShareAmount { get; set; }
        public string MRecentCalculationNo { get; set; }
        public string FieldNo { get; set; }
        public string LoanNo { get; set; }
        public string SoftwareLoanNo { get; set; }
        public string InvestmentNo { get; set; }
        public string BranchCode { get; set; }
        public decimal Amount { get; set; }
        public DateTime ContractualDate { get; set; }
        public string AplicantName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string NID { get; set; }
        public string Village { get; set; }
        public string PO { get; set; }
        public string PS { get; set; }
        public string District { get; set; }
        public string PresentAddress { get; set; }
        public string BusinessAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string BusinessNature { get; set; }
        public string BusinessType { get; set; }
        public string MotiveofLoan { get; set; }
        public DateTime DateOwn { get; set; }
        public DateTime DateRent { get; set; }
        public DateTime LastDate { get; set; }
        public DateTime LastDate2 { get; set; }
        public decimal AmountRent { get; set; }
        public string NameRent { get; set; }
        public string NameRent2 { get; set; }
        public decimal StockAmount { get; set; }
        public decimal OwnAmount { get; set; }
        public decimal MonthlyAvarageIncome { get; set; }
        public string MLFile { get; set; }
        public decimal DailySaleAmount { get; set; }
        public decimal DailyProfit { get; set; }
        public decimal DailyIncome { get; set; }
        public decimal MonthlySaleAmount { get; set; }
        public decimal MonthlyProfit { get; set; }
        public decimal MonthlyIncome { get; set; }
        public decimal AmountInAccount { get; set; }
        public decimal MAccountNo { get; set; }


        public decimal LoanAmountTotal { get; set; }
        public decimal LoanInstallmentAmount { get; set; }
        public string Installment { get; set; }
        public string LoanInstallment { get; set; }
        public int LoanRecoveryDays { get; set; }
        public DateTime LoanProvideDate { get; set; }
        //new
        public string LoanType { get; set; }
        public string LoanSubType { get; set; }
        public string TRIBranchCode { get; set; }
        public string TRIApplicantName { get; set; }
        public string TRIMemberNo { get; set; }
        public decimal TRILoanAmount { get; set; }
        public string LoanInstallmentType { get; set; }
        public string DailySavingType { get; set; }
        public decimal DefalterBokeya { get; set; }
        public decimal DefalterStithi { get; set; }

        #endregion

        #region Bimudaraba       
        public string TypeofInvestment { get; set; }
        public string DescriptionofInvestment { get; set; }
        public decimal InvestmentAmount { get; set; }
        public DateTime ExecptDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string PresentStatus { get; set; }
        public decimal OwnBussinessAsset { get; set; }
        public decimal GodownStock { get; set; }
        public decimal AverageSales { get; set; }
        public decimal AverageIncome { get; set; }
        
        #endregion

        #region CurrentSaving
        public string TypesofSavings { get; set; }
        public string AccountNo { get; set; }
        public DateTime AccountopenDate { get; set; }
        public decimal InstallmentAmount { get; set; }
        public decimal PresentAmount { get; set; }
        public string Status { get; set; }
        #endregion

        #region Jamanat
        public string RetentionDescription { get; set; }
        public string MoujaName { get; set; }
        public string DocumentNo { get; set; }
        public string LedgerNo { get; set; }
        public string StainsNo { get; set; }
        public string LandAmount { get; set; }
        public decimal MinimumPrice { get; set; }
        #endregion

        #region Jaminder
        public string GuarantorName { get; set; }
        public DateTime GuarantorDateofBirth { get; set; }
        public string GuarantorFather { get; set; }
        public string GuarantorMother { get; set; }
        public string PermanentVillage { get; set; }
        public string GuarantorPO { get; set; }
        public string GuarantorPS { get; set; }
        public string GuarantorPermanentDistrict { get; set; }
        public string GuarantorPresentAddress { get; set; }
        public string GuarantorBusinessAddress { get; set; }
        public string GuarantorNID { get; set; }
        public string GuarantorPhone { get; set; }
        public string GuarantorRelation { get; set; }
        public string GuarantorOccupation { get; set; }
        public string GuarantorDmcbSavingName { get; set; }
        public decimal GuarantorDmcbSavingAmount { get; set; }
        public string GuarantorDmcbLoanName { get; set; }
        public decimal GuarantorDmcbLoanAmount { get; set; }
        public decimal GuarantorInstallmentAmount { get; set; }
        public string GuarantorSignature { get; set; }
        #endregion

        #region Jaminder1
        public string GuarantorName1 { get; set; }
        public DateTime GuarantorDateofBirth1 { get; set; }
        public string GuarantorFather1 { get; set; }
        public string GuarantorMother1 { get; set; }
        public string PermanentVillage1 { get; set; }
        public string GuarantorPO1 { get; set; }
        public string GuarantorPS1 { get; set; }
        public string GuarantorPermanentDistrict1 { get; set; }
        public string GuarantorPresentAddress1 { get; set; }
        public string GuarantorBusinessAddress1 { get; set; }
        public string GuarantorNID1 { get; set; }
        public string GuarantorPhone1 { get; set; }
        public string GuarantorRelation1 { get; set; }
        public string GuarantorOccupation1 { get; set; }
        public string GuarantorDmcbSavingName1 { get; set; }
        public decimal GuarantorDmcbSavingAmount1 { get; set; }
        public string GuarantorDmcbLoanName1 { get; set; }
        public decimal GuarantorDmcbLoanAmount1 { get; set; }
        public decimal GuarantorInstallmentAmount1 { get; set; }
        public string GuarantorSignature1 { get; set; }
        #endregion

        #region Jaminder2
        public string GuarantorName2 { get; set; }
        public DateTime GuarantorDateofBirth2 { get; set; }
        public string GuarantorFather2 { get; set; }
        public string GuarantorMother2 { get; set; }
        public string PermanentVillage2 { get; set; }
        public string GuarantorPO2 { get; set; }
        public string GuarantorPS2 { get; set; }
        public string GuarantorPermanentDistrict2 { get; set; }
        public string GuarantorPresentAddress2 { get; set; }
        public string GuarantorBusinessAddress2 { get; set; }
        public string GuarantorNID2 { get; set; }
        public string GuarantorPhone2 { get; set; }
        public string GuarantorRelation2 { get; set; }
        public string GuarantorOccupation2 { get; set; }
        public string GuarantorDmcbSavingName2 { get; set; }
        public decimal GuarantorDmcbSavingAmount2 { get; set; }
        public string GuarantorDmcbLoanName2 { get; set; }
        public decimal GuarantorDmcbLoanAmount2 { get; set; }
        public decimal GuarantorInstallmentAmount2 { get; set; }
        public string GuarantorSignature2 { get; set; }
        #endregion

        #region OtherBank
        public string NameofOtherBank { get; set; }
        public decimal LoanAmount { get; set; }
        public DateTime ExceptLoanDate { get; set; }
        public DateTime ExpireLoanDate { get; set; }
        public decimal PresentLoanAmount { get; set; }
        #endregion

        #region SalesAndIncome
        public string LoanDescription { get; set; }
        public decimal SalesAmount { get; set; }
        public string ProfitRate { get; set; }
        public decimal IncomeAmount { get; set; }
        #endregion

        #region TRInvestment
        public DateTime TRDate { get; set; }
        public string SlNo { get; set; }
        public string ProductDescription { get; set; }
        public string QTY { get; set; }
        public decimal Buyamount { get; set; }
        public decimal TRSalesAmount { get; set; }
        public string MinimumProfit { get; set; }
        #endregion
    }
}