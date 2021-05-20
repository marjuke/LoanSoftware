using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoanSoftware.Models.CommonInformation
{
   
    public static class LoadComboBox
    {
        private static ApplicationDbContext db = new ApplicationDbContext();
        public static SelectList LoadAllBranch()
        {
            var data = db.Branches.ToList();
            Dictionary<string, string> items = new Dictionary<string, string>();

            items.Add("", "Select Branch");
            data.ForEach(x =>
            {
                items.Add(x.BranchCode,x.BranchCode+"-"+x.BranchName);
            });

            return new SelectList(items, "key", "Value");
        }
        //Area Select Dropdown

        public static SelectList LoadAllAreaCode()
        {
            var data = db.Areas.ToList();
            Dictionary<string, string> itemsData = new Dictionary<string, string>();

            itemsData.Add("", "Select Field");
            data.ForEach(x =>
            {
                itemsData.Add(x.AreaName, x.Comments);
            });

            return new SelectList(itemsData, "key", "Value");
        }
        public static SelectList LoadLoanType()
        {
            
            Dictionary<string, string> itemsData = new Dictionary<string, string>();

            itemsData.Add("", "Select type");
            itemsData.Add("ক্ষুদ্র", "ক্ষুদ্র");
            itemsData.Add("সাধারণ", "সাধারণ");
            itemsData.Add("চলতি", "চলতি");
          

            return new SelectList(itemsData, "key", "Value");
        }
        public static SelectList LoadLoanInstallmentType()
        {
            
            Dictionary<string, string> itemsData = new Dictionary<string, string>();

            itemsData.Add("", "Select type");
            itemsData.Add("দৈনিক", "দৈনিক");
            itemsData.Add("মাসিক", "মাসিক");
          

            return new SelectList(itemsData, "key", "Value");
        }
        public static SelectList LoadLoanSubType()
        {
            
            Dictionary<string, string> itemsData = new Dictionary<string, string>();

            itemsData.Add("", "Select type");
            itemsData.Add("নতুন", "নতুন");
            itemsData.Add("নবায়ন", "নবায়ন");
            itemsData.Add("বধিতকরন", "বধিতকরন");
          

            return new SelectList(itemsData, "key", "Value");
        }
        public static SelectList LoadDoinikShikkha()
        {
            
            Dictionary<string, string> itemsData = new Dictionary<string, string>();

            itemsData.Add("", "Select type");
            itemsData.Add("শিক্ষা", "শিক্ষা");
            itemsData.Add("বিবাহ", "বিবাহ");
          

            return new SelectList(itemsData, "key", "Value");
        }
        
       
        
    }
}