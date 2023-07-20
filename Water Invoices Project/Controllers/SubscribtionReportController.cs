using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Water_Invoices_Project.Models;


namespace Water_Invoices_Project.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    [EnableCors("AllowOrigin")]
    [Produces("application/json")]
    public class SubscribtionReportController : Controller
    {
        Water_InvoicesContext nwcSubscribtionFile = new Water_InvoicesContext();
        public IActionResult GetSubscribtionReport()
        {
            var list = nwcSubscribtionFile.NwcSubscriberFiles.ToList();
            var list2 = nwcSubscribtionFile.NwcSubscriptionFiles.ToList();
            var list3 = nwcSubscribtionFile.NwcRrealEstateTypes.ToList();

            var result = (from t1 in list2
                         join t2 in list on t1.NwcSubscriptionFileSubscriberCode equals t2.NwcSubscriberFileId into t2Group
                         from t2 in t2Group.DefaultIfEmpty()
                         join t3 in list3  on t1.NwcSubscriptionFileRrealEstateTypesCode equals t3.NwcRrealEstateTypesCode into t3Group
                         from t3 in t3Group.DefaultIfEmpty()
                         select new NwcSubscriptionFile
                         {
                            NwcSubscriptionFileNo= t1.NwcSubscriptionFileNo,
                            NwcSubscriptionFileSubscriberCode=t1.NwcSubscriptionFileSubscriberCode,
                            SubscriberName = t2.NwcSubscriberFileName,
                            Phone = t2.NwcSubscriberFileMobile,
                            Type = t3.NwcRrealEstateTypesName,
                            NwcSubscriptionFileUnitNo= t1.NwcSubscriptionFileUnitNo,
                            YesorNo = t1.NwcSubscriptionFileIsThereSanitation !=true ? "لا" : "نعم",
                            NwcSubscriptionFileLastReadingMeter=  t1.NwcSubscriptionFileLastReadingMeter,
                             NwcSubscriptionFileReasons= t1.NwcSubscriptionFileReasons
                         }).Select((item, index) => new NwcSubscriptionFile
                         {
                             NwcSubscriptionFileNo = item.NwcSubscriptionFileNo,
                             NwcSubscriptionFileSubscriberCode = item.NwcSubscriptionFileSubscriberCode,
                             SubscriberName = item.SubscriberName,
                             Phone = item.Phone,
                             Type = item.Type,
                             NwcSubscriptionFileUnitNo = item.NwcSubscriptionFileUnitNo,
                             YesorNo = item.YesorNo,
                             NwcSubscriptionFileLastReadingMeter = item.NwcSubscriptionFileLastReadingMeter,
                             NwcSubscriptionFileReasons = item.NwcSubscriptionFileReasons,
                             M = index + 1
                         }).ToList();



            return View("SubscribtionReport", result);
        }
    }
}
