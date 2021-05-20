using LoanSoftware.Models;
using LoanSoftware.Models.LoanModel;
using LoanSoftware.Models.LoanModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using LoanSoftware.Models.CommonInformation;
using LoanSoftware.Models.VIEW;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Microsoft.AspNet.Identity;

namespace LoanSoftware.Controllers.Loan
{
    public class LoanEntryController : Controller
    {
        // GET: LoanEntry
        private ApplicationDbContext db = new ApplicationDbContext();
        private LoanDBEntities dbViews = new LoanDBEntities();
        public ActionResult LoanEntry()
        {
            var UID = User.Identity.GetUserId();
            var branch = db.Users.Where(s => s.Id == UID).Select(s => s.BranchCode).FirstOrDefault();   
            var lastformno = db.MemberLoanInfo.Count();
            var sno = branch + "-" + "01-" + (lastformno + 1).ToString();
            ViewBag.softwarenumber = sno;

            ViewBag.Page = "LoanEntry";
            ViewBag.branchcode = LoadComboBox.LoadAllBranch();
            ViewBag.AreaCode = LoadComboBox.LoadAllAreaCode();
            ViewBag.LoanType = LoadComboBox.LoadLoanType();
            ViewBag.LoadLoanSubType = LoadComboBox.LoadLoanSubType();
            ViewBag.LoanInstallmentType = LoadComboBox.LoadLoanInstallmentType();
            ViewBag.LoadDoinikShikkha = LoadComboBox.LoadDoinikShikkha();

            return View();
        }

        

        public ActionResult Edit(string id)
        {
            ViewBag.branchcode = LoadComboBox.LoadAllBranch();
            ViewBag.AreaCode = LoadComboBox.LoadAllAreaCode();
            ViewBag.LoanType = LoadComboBox.LoadLoanType();
            ViewBag.LoadLoanSubType = LoadComboBox.LoadLoanSubType();
            ViewBag.LoanInstallmentType = LoadComboBox.LoadLoanInstallmentType();
            ViewBag.LoadDoinikShikkha = LoadComboBox.LoadDoinikShikkha();
            ViewBag.FormNo = id;
            return View();
        }



        



        [HttpPost]
        public async Task<ActionResult> Edit(HttpPostedFileBase file, HttpPostedFileBase file1, HttpPostedFileBase file2, HttpPostedFileBase file3, string json)
        {
            string[] g = new string[3];
            var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = "dd-MM-yyyy" };
            var rootObject = JsonConvert.DeserializeObject<RootObject>(json, dateTimeConverter);


            var memberinfo = db.MemberLoanInfo.FirstOrDefault(s => s.FormID == rootObject.MemberLoanInfo.FormID);
            var grantorlist = db.Guarantor.Where(x => x.FormID == memberinfo.FormID).ToList();

            string UploadPath = AppDomain.CurrentDomain.BaseDirectory.ToString() + "UploadFiles\\";
            //DirectoryInfo Dir = new DirectoryInfo(UploadPath + rootObject.MemberLoanInfo.FormID);
            //Dir.Create();

            DirectoryInfo dir = new DirectoryInfo(@"~/UploadFiles/" + rootObject.MemberLoanInfo.FormID);

            if (file != null)
            {
                if (!string.IsNullOrEmpty(memberinfo.MLFile))
                {
                    var filename = memberinfo.MLFile;
                    var filePath = Server.MapPath("~" + filename);
                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }
                }
               
                
                var fileName = Path.GetFileName(file.FileName);
                var extention = Path.GetExtension(file.FileName);
                var filenamewithoutextension = Path.GetFileNameWithoutExtension(file.FileName);
                var FileName = rootObject.MemberLoanInfo.FormID + "-LoanHolder" + rootObject.MemberLoanInfo.MemberNo + extention;
                file.SaveAs(Server.MapPath("/UploadFiles/" + rootObject.MemberLoanInfo.FormID + "/" + FileName));
                rootObject.MemberLoanInfo.MLFile = "/UploadFiles/" + rootObject.MemberLoanInfo.FormID + "/" + FileName;

            }
            else if (file == null && !string.IsNullOrEmpty(memberinfo.MLFile))
            {
                rootObject.MemberLoanInfo.MLFile = memberinfo.MLFile;
            }
            
            if (file1 != null )
            {
                if (grantorlist.Count() >= 1)
                {
                    var filename = grantorlist[0].FilePath;
                    var filePath = Server.MapPath("~" + filename);
                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }
                }
                
                var fileName = Path.GetFileName(file1.FileName);
                var extention = Path.GetExtension(file1.FileName);
                var filenamewithoutextension = Path.GetFileNameWithoutExtension(file1.FileName);
                var FileName = rootObject.MemberLoanInfo.FormID + "-grantor1-" + rootObject.MemberLoanInfo.MemberNo + extention;
                file1.SaveAs(Server.MapPath("/UploadFiles/" + rootObject.MemberLoanInfo.FormID + "/" + FileName));

                g[0] = "/UploadFiles/" + rootObject.MemberLoanInfo.FormID + "/" + FileName;
            }
            else if (file1 == null && grantorlist.Count()>=1)
            {
                if (!string.IsNullOrEmpty(grantorlist[0].FilePath))
                {
                    g[0] = grantorlist[0].FilePath;

                }
            }
            if (file2 != null)
            {
                if (grantorlist.Count()>=2)
                {
                    var filename = grantorlist[1].FilePath;
                    var filePath = Server.MapPath("~" + filename);
                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }
                }

                var fileName = Path.GetFileName(file2.FileName);
                var extention = Path.GetExtension(file2.FileName);
                var filenamewithoutextension = Path.GetFileNameWithoutExtension(file2.FileName);
                var FileName = rootObject.MemberLoanInfo.FormID + "-grantor2-" + rootObject.MemberLoanInfo.MemberNo + extention;
                file2.SaveAs(Server.MapPath("/UploadFiles/" + rootObject.MemberLoanInfo.FormID + "/" + FileName));

                g[1] = "/UploadFiles/" + rootObject.MemberLoanInfo.FormID + "/" + FileName;
            }
            else if (file2 == null && grantorlist.Count() >= 2)
            {
                if (!string.IsNullOrEmpty(grantorlist[1].FilePath))
                {
                    g[1] = grantorlist[1].FilePath;

                }
            }
            if (file3 != null)
            {
                if (grantorlist.Count()>=3)
                {
                    var filename = grantorlist[2].FilePath;
                    var filePath = Server.MapPath("~" + filename);
                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }
                }

                var fileName = Path.GetFileName(file3.FileName);
                var extention = Path.GetExtension(file3.FileName);
                var filenamewithoutextension = Path.GetFileNameWithoutExtension(file3.FileName);
                var FileName = rootObject.MemberLoanInfo.FormID + "-grantor3-" + rootObject.MemberLoanInfo.MemberNo + extention;
                file3.SaveAs(Server.MapPath("/UploadFiles/" + rootObject.MemberLoanInfo.FormID + "/" + FileName));
                g[2] = "/UploadFiles/" + rootObject.MemberLoanInfo.FormID + "/" + FileName;

            }
            else if (file3 == null &&grantorlist.Count()>=3)
            {
                if (!string.IsNullOrEmpty(grantorlist[2].FilePath))
                {
                    g[2] = grantorlist[2].FilePath;

                }
            }



            var Isdelete = await deletebyid(rootObject.MemberLoanInfo.FormID);

            if (Isdelete != true)
            {
                return RedirectToAction("List");
            }
            else
            {

                //var hist = db.MemberLoanInfo.FirstOrDefault(x => x.ApprovalNo == rootObject.MemberLoanInfo.ApprovalNo);
                //if (hist != null)
                //{
                //    return Json(0, JsonRequestBehavior.AllowGet);
                //}
                

                if (rootObject.CurrentSaving.Count > 0)
                {
                    rootObject.CurrentSaving.ForEach(x =>
                    {
                        x.FormID = rootObject.MemberLoanInfo.FormID;
                        db.CurrentSavings.Add(x);
                    });
                }

                if (rootObject.OtherBank.Count() > 0)
                {
                    rootObject.OtherBank.ForEach(x =>
                    {
                        x.FormID = rootObject.MemberLoanInfo.FormID;
                        db.OtherBank.Add(x);
                    });
                }

                if (rootObject.RetentionProperty.Count() != 0)
                {
                    rootObject.RetentionProperty.ForEach(x =>
                    {
                        x.FormID = rootObject.MemberLoanInfo.FormID;
                        db.RetentionProperty.Add(x);
                    });
                }

                if (rootObject.TRInvestment.Count() > 0)
                {
                    rootObject.TRInvestment.ForEach(x =>
                    {
                        x.FormID = rootObject.MemberLoanInfo.FormID;
                        db.TRInvestment.Add(x);
                    });
                }



                if (rootObject.BiMudaraba.Count() > 0)
                {

                    rootObject.BiMudaraba.ForEach(x =>
                    {
                        x.FormID = rootObject.MemberLoanInfo.FormID;

                        db.BiMudaraba.Add(x);

                    });
                }



                if (rootObject.Guarantor.Count() > 0)
                {
                    var i = 0;
                    rootObject.Guarantor.ForEach(x =>
                    {
                        if (x.GuarantorName!="")
                        {
                            x.FormID = rootObject.MemberLoanInfo.FormID;
                            x.FilePath = g[i];
                            db.Guarantor.Add(x);
                        }
                        i++;
                    });
                }


                db.MemberLoanInfo.Add(rootObject.MemberLoanInfo);



                db.SaveChanges();

                return Json(1, JsonRequestBehavior.AllowGet);
            }
        }
    



    //Delete
    public async Task<ActionResult> Delete(int id)
        {
            var LoanInfoData = db.MemberLoanInfo.Where(s => s.FormID == id).FirstOrDefault();
            var filename = LoanInfoData.MLFile;
            if (filename != null)
            {
                string[] subs = filename.Split('/');
                var filePath = Server.MapPath("~/" + subs[2]);
                if (Directory.Exists(filePath))
                {
                    Directory.Delete(filePath);
                }
            }
            var Isdelete = await deletebyid(id);
            
            if (Isdelete)
            {
                _ = db.SaveChangesAsync();
            }

            return RedirectToAction("List");
        }


        public async Task<bool> deletebyid(int id)
        {
            var LoanInfoData =  db.MemberLoanInfo.Where(s => s.FormID == id).FirstOrDefault();     
            var bimudaraData =  await db.BiMudaraba.Where(s => s.FormID == id).ToListAsync();
            var currentData = await db.CurrentSavings.Where(s => s.FormID == id).ToListAsync();
            var GuarantorData = await db.Guarantor.Where(s => s.FormID == id).ToListAsync();
            var otherBankData = await db.OtherBank.Where(s => s.FormID == id).ToListAsync();
            var trInvestData = await db.TRInvestment.Where(s => s.FormID == id).ToListAsync();
            var rententionData = await db.RetentionProperty.Where(s => s.FormID == id).ToListAsync();



           
            


            db.MemberLoanInfo.Remove(LoanInfoData);
            db.BiMudaraba.RemoveRange(bimudaraData);
            db.CurrentSavings.RemoveRange(currentData);
            db.Guarantor.RemoveRange(GuarantorData);
            db.OtherBank.RemoveRange(otherBankData);
            db.TRInvestment.RemoveRange(trInvestData);
            db.RetentionProperty.RemoveRange(rententionData);
            return true;
        }



        //Delete

        public ActionResult List()
        {
            ViewBag.Page = "LoanList";
            // var data = db.MemberLoanInfo.ToList();
            var data = dbViews.VMemberLoans.ToList();
            return View(data);
        }

        //Details


        public ActionResult LoanFormPrint(int Id)
        {
            ViewBag.branchcode = LoadComboBox.LoadAllBranch();
            ViewBag.AreaCode = LoadComboBox.LoadAllAreaCode();
            ViewBag.LoanType = LoadComboBox.LoadLoanType();
            ViewBag.LoadLoanSubType = LoadComboBox.LoadLoanSubType();
            ViewBag.LoanInstallmentType = LoadComboBox.LoadLoanInstallmentType();
            ViewBag.LoadDoinikShikkha = LoadComboBox.LoadDoinikShikkha();
            ViewBag.FormNo = Id;
            return View();
        }
        public ActionResult LoanFormPrintPrivew(int Id)
        {
            ViewBag.branchcode = LoadComboBox.LoadAllBranch();
            ViewBag.AreaCode = LoadComboBox.LoadAllAreaCode();
            ViewBag.LoanType = LoadComboBox.LoadLoanType();
            ViewBag.LoadLoanSubType = LoadComboBox.LoadLoanSubType();
            ViewBag.LoanInstallmentType = LoadComboBox.LoadLoanInstallmentType();
            ViewBag.LoadDoinikShikkha = LoadComboBox.LoadDoinikShikkha();
            ViewBag.FormNo = Id;
            return View();
        }
        public ActionResult Details(int Id)
        {
            //string MemberLoanNo = Id.ToString();
            //ViewData["MemberLoanMainFrom"] = await db.MemberLoanInfo.FirstOrDefaultAsync(s => s.FormID == Id);
            //ViewData["MemberLoanMainFromWithBranch"] = await dbViews.VMemberLoans.FirstOrDefaultAsync(s => s.FormID == Id);
            //ViewData["BiMudaraInfo"] = db.BiMudaraba.Where(s => s.FormID == Id).ToList();
            //ViewData["CurrentSavingInfo"] = await db.CurrentSavings.Where(s => s.FormID == Id).ToListAsync();
            //ViewData["GuranterInfo"] = await db.Guarantor.Where(s => s.FormID == Id).ToListAsync();
            //ViewData["OtherBankData"] = await db.OtherBank.Where(s => s.FormID == Id).ToListAsync();
            //ViewData["TRInvestmentInfo"] = await db.TRInvestment.Where(s => s.FormID == Id).ToListAsync();
            //ViewData["RetentionPropertyInfo"] = await db.RetentionProperty.Where(s => s.FormID == Id).ToListAsync();
            //ViewData["Member"] = await db.RetentionProperty.Where(s => s.FormID == Id).ToListAsync();

            //ViewBag.hasData = true;


            ViewBag.branchcode = LoadComboBox.LoadAllBranch();
            ViewBag.AreaCode = LoadComboBox.LoadAllAreaCode();
            ViewBag.LoanType = LoadComboBox.LoadLoanType();
            ViewBag.LoadLoanSubType = LoadComboBox.LoadLoanSubType();
            ViewBag.LoanInstallmentType = LoadComboBox.LoadLoanInstallmentType();
            ViewBag.LoadDoinikShikkha = LoadComboBox.LoadDoinikShikkha();
            ViewBag.FormNo = Id;
            //  var d = db.VstafflistNews.FirstOrDefault(s => s.CustIDNO == custId);
            return View();
        }

        //End

        // edit Search 
        public async Task<ActionResult> GetLoanData(int q)
        {
            if (q==0)
            {
                return Json(new
                {
                    status = 0,
                    Msg = "Query Not Provided!"
                }, JsonRequestBehavior.AllowGet);
            }

            var MemInfoData = await db.MemberLoanInfo.Where(x => x.FormID == q).FirstOrDefaultAsync();
            var BiMudarabaData = await db.BiMudaraba.Where(x => x.FormID == q).ToListAsync();
            var CurrentSavingData = await db.CurrentSavings.Where(x => x.FormID == q).ToListAsync();
            var GurantarData = await db.Guarantor.Where(x => x.FormID == q).ToListAsync();           
            var otherBankData = await db.OtherBank.Where(x => x.FormID == q).ToListAsync();
            var trInvestmentData = await db.TRInvestment.Where(x => x.FormID == q).ToListAsync();
            var RetentionData = await db.RetentionProperty.Where(x => x.FormID == q).ToListAsync();
            var VMemberLoandata = await dbViews.VMemberLoans.Where(x => x.FormID == q).FirstOrDefaultAsync();

            //var picLoanHolder= Server.MapPath("/UploadFiles/" + MemInfoData.FormID + "/" + FileName)

            return Json(new
            {
                MemInfoData,
                BiMudarabaData,
                CurrentSavingData,
                GurantarData,
                otherBankData,
                trInvestmentData,
                RetentionData,
                VMemberLoandata

            }, JsonRequestBehavior.AllowGet);

        }


        [HttpPost]
        public ActionResult Save(HttpPostedFileBase file, HttpPostedFileBase file1, HttpPostedFileBase file2, HttpPostedFileBase file3, string json)
        {
            string[] g=new string[3];
            var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = "dd-MM-yyyy" };
            var rootObject = JsonConvert.DeserializeObject<RootObject>(json, dateTimeConverter);
            string yearLastTwoPart = DateTime.Now.Year.ToString().Substring(2, 2).ToString();
            var noOfInvoice = db.MemberLoanInfo.Count();
            string formNo = "";

            if (noOfInvoice > 0)
            {
                var lastInvoice = db.MemberLoanInfo.ToList().LastOrDefault(x => x.FormID.ToString().Substring(0, 2).ToString() == yearLastTwoPart);
                if (lastInvoice == null)
                {
                    formNo = yearLastTwoPart + "00001";
                }
                else
                {
                    formNo = yearLastTwoPart + (Convert.ToInt32(lastInvoice.FormID.ToString().Substring(2, 5)) + 1).ToString().PadLeft(5, '0');
                }
            }
            else
            {
                formNo = yearLastTwoPart + "00001";
            }
            rootObject.MemberLoanInfo.FormID = Convert.ToInt32(formNo);


            
            

            //var hist = db.MemberLoanInfo.FirstOrDefault(x => x.ApprovalNo == rootObject.MemberLoanInfo.ApprovalNo);
            //if (hist != null)
            //{
            //    return Json(0, JsonRequestBehavior.AllowGet);
            //}
            string UploadPath = AppDomain.CurrentDomain.BaseDirectory.ToString() + "UploadFiles\\";
            DirectoryInfo Dir = new DirectoryInfo(UploadPath + rootObject.MemberLoanInfo.FormID);
            Dir.Create();

            DirectoryInfo dir = new DirectoryInfo(@"~/UploadFiles/" + rootObject.MemberLoanInfo.FormID);

            if (file != null)
            {

                var fileName = Path.GetFileName(file.FileName);
                var extention = Path.GetExtension(file.FileName);
                var filenamewithoutextension = Path.GetFileNameWithoutExtension(file.FileName);
                var FileName = rootObject.MemberLoanInfo.FormID + "-LoanHolder" + rootObject.MemberLoanInfo.MemberNo + extention;
                file.SaveAs(Server.MapPath("/UploadFiles/" + rootObject.MemberLoanInfo.FormID + "/" + FileName));
                rootObject.MemberLoanInfo.MLFile = "/UploadFiles/" + rootObject.MemberLoanInfo.FormID + "/" + FileName;

            }
            if (file1 != null)
            {

                var fileName = Path.GetFileName(file1.FileName);
                var extention = Path.GetExtension(file1.FileName);
                var filenamewithoutextension = Path.GetFileNameWithoutExtension(file1.FileName);
                 var FileName = rootObject.MemberLoanInfo.FormID + "-grantor1-" + rootObject.MemberLoanInfo.MemberNo + extention;
                file1.SaveAs(Server.MapPath("/UploadFiles/" + rootObject.MemberLoanInfo.FormID + "/" + FileName));

                g[0] = "/UploadFiles/" + rootObject.MemberLoanInfo.FormID + "/" + FileName;
            }
            if (file2 != null)
            {

                var fileName = Path.GetFileName(file2.FileName);
                var extention = Path.GetExtension(file2.FileName);
                var filenamewithoutextension = Path.GetFileNameWithoutExtension(file2.FileName);
                var FileName = rootObject.MemberLoanInfo.FormID + "-grantor2-" + rootObject.MemberLoanInfo.MemberNo + extention;
                file2.SaveAs(Server.MapPath("/UploadFiles/" + rootObject.MemberLoanInfo.FormID + "/" + FileName));

                g[1] = "/UploadFiles/" + rootObject.MemberLoanInfo.FormID + "/" + FileName;
            }
            if (file3 != null)
            {

                var fileName = Path.GetFileName(file3.FileName);
                var extention = Path.GetExtension(file3.FileName);
                var filenamewithoutextension = Path.GetFileNameWithoutExtension(file3.FileName);
                var FileName = rootObject.MemberLoanInfo.FormID + "-grantor3-" + rootObject.MemberLoanInfo.MemberNo + extention;
                file3.SaveAs(Server.MapPath("/UploadFiles/" + rootObject.MemberLoanInfo.FormID + "/" + FileName));
                g[2] = "/UploadFiles/" + rootObject.MemberLoanInfo.FormID + "/" + FileName;

            }

                        

            if (rootObject.CurrentSaving.Count > 0)
            {
                rootObject.CurrentSaving.ForEach(x =>
                {
                    x.FormID = rootObject.MemberLoanInfo.FormID;
                    db.CurrentSavings.Add(x);
                });
            }

            if (rootObject.OtherBank.Count() > 0)
            {
                rootObject.OtherBank.ForEach(x =>
                {
                    x.FormID = rootObject.MemberLoanInfo.FormID;
                    db.OtherBank.Add(x);
                });
            }

            if (rootObject.RetentionProperty.Count() != 0)
            {
                rootObject.RetentionProperty.ForEach(x =>
                {
                    x.FormID = rootObject.MemberLoanInfo.FormID;
                    db.RetentionProperty.Add(x);
                });
            }

            if (rootObject.TRInvestment.Count() > 0)
            {
                rootObject.TRInvestment.ForEach(x =>
                {
                    x.FormID = rootObject.MemberLoanInfo.FormID;
                    db.TRInvestment.Add(x);
                });
            }



            if (rootObject.BiMudaraba.Count() > 0)
            {
            
                rootObject.BiMudaraba.ForEach(x =>
                {
                    x.FormID = rootObject.MemberLoanInfo.FormID;
                    
                    db.BiMudaraba.Add(x);

                });
            }



            if (rootObject.Guarantor.Count() > 0)
            {
                var i = 0;
                rootObject.Guarantor.ForEach(x =>
                {
                    if (x.GuarantorName != null)
                    {
                        x.FormID = rootObject.MemberLoanInfo.FormID;
                        x.FilePath = g[i];
                        db.Guarantor.Add(x);
                    }
                    i++;
                });
            }


            db.MemberLoanInfo.Add(rootObject.MemberLoanInfo);



            db.SaveChanges();

            return Json(1, JsonRequestBehavior.AllowGet);
        }


        
    }

    public class RootObject
    {
        public MemberLoanInfo MemberLoanInfo { get; set; }
        public List<CurrentSaving> CurrentSaving { get; set; }
        public List<OtherBank> OtherBank { get; set; }
        public List<RetentionProperty> RetentionProperty { get; set; }
        public List<TRInvestment> TRInvestment { get; set; }
        public List<BiMudaraba> BiMudaraba { get; set; }
        public List<Guarantor> Guarantor { get; set; }
    }
}