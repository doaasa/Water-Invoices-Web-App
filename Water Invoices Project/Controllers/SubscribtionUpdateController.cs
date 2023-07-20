using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Water_Invoices_Project.Models;

namespace Water_Invoices_Project.Controllers
{
    public class SubscribtionUpdateController : Controller
    {
        Water_InvoicesContext subscribitionUpdate = new Water_InvoicesContext();

        [HttpPost]

        public JsonResult UpdateRecordSubribition(string Code)
        {
            var recordToUpdate = subscribitionUpdate.NwcSubscriberFiles.FirstOrDefault(r => r.NwcSubscriberFileId == Code);

            if (recordToUpdate == null)
            {
                TempData["Failed Message"] = "برجاء التأكد من رقم الهوية";
                return Json(Code);
            }
            else
            {
                
                string SubscriberFileName = recordToUpdate.NwcSubscriberFileName.ToString();
                string SubscriberFilecity = recordToUpdate.NwcSubscriberFileCity.ToString();
                string SubscriberFileArea = recordToUpdate.NwcSubscriberFileArea.ToString();
                string SubscriberFileMobile = recordToUpdate.NwcSubscriberFileMobile.ToString();
                TempData["SuccessMessage"] = "تم التحديث بنجاح";
                return Json(new
                {
                    data1 = SubscriberFileName,
                    data2 = SubscriberFilecity,
                    data3 = SubscriberFileArea,
                    data4 = SubscriberFileMobile
                });
            }
        }

        [HttpPost]
        public IActionResult SaveData(IFormCollection form)
        {
            bool yesChecked = form["yes"] == "true";
            bool noChecked = form["no"] == "false";
            bool sant =false;
            if (yesChecked)
            {
                sant =true;
            }
            string NWC_Subscription_File_No = Request.Form["SubCode"];
            string NWC_Subscription_File_Subscriber_Code = Request.Form["Code"];
            string Type = form["TypeName"];
            decimal Unit = decimal.Parse(Request.Form["Unit"]);
            NwcSubscriptionFile subscriptionFile = new NwcSubscriptionFile
            {
                NwcSubscriptionFileNo = NWC_Subscription_File_No,
                NwcSubscriptionFileSubscriberCode = NWC_Subscription_File_Subscriber_Code,
                NwcSubscriptionFileRrealEstateTypesCode = Type,
                NwcSubscriptionFileUnitNo = Unit,
                NwcSubscriptionFileIsThereSanitation = sant,
            };

            subscribitionUpdate.NwcSubscriptionFiles.Add(subscriptionFile);
            subscribitionUpdate.SaveChanges();
            return View("SubscribtionUpdate", subscriptionFile);
        }
        public IActionResult CreateView()
        {
            var model = new NwcSubscriptionFile();
            while (true)
            {
                DateTime now = DateTime.Now;
                int year = now.Year;
                string lastTwoDigits = (year % 100).ToString("00");
                int month = now.Month;
                Random random = new Random();

                int randomNumber = random.Next(1, 300);
                string subNum = $"{lastTwoDigits}-{month:D2}-{randomNumber:D3}";

                var recordtoSearch = subscribitionUpdate.NwcSubscriptionFiles.FirstOrDefault(r => r.NwcSubscriptionFileNo == subNum);
                if (recordtoSearch == null)
                {
                    model.NwcSubscriptionFileNo = subNum;

                    break;
                }
                else
                {
                    continue;
                }
            }
            return View("SubscribtionUpdate", model);
        }
    }
}
