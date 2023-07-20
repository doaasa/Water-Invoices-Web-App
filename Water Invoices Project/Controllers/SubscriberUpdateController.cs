using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml;
using Water_Invoices_Project.Models;

namespace Water_Invoices_Project.Controllers
{
    public class SubscriberUpdateController : Controller
    {
        Water_InvoicesContext subscriberUpdate = new Water_InvoicesContext();

        [HttpPost]
       public IActionResult UpdateRecordSub(IFormCollection newsubscriberfile)
        {
            var model = new NwcSubscriberFile();
            string NwcSubscriptionFileCode = newsubscriberfile["Code"];
            string NwcSubscriptionFileName = newsubscriberfile["Name"];
            string NwcSubscriptionFilecity = newsubscriberfile["City"];
            string NwcSubscriptionFilearea = newsubscriberfile["Area"];
            string NwcSubscriptionFilephone = newsubscriberfile["Phone"];

            var recordToUpdate = subscriberUpdate.NwcSubscriberFiles.FirstOrDefault(r => r.NwcSubscriberFileId == NwcSubscriptionFileCode);
            if (recordToUpdate == null)
            {
                TempData["Failed Message"] = "برجاء التأكد من رقم الهوية";
                return View("subscriberUpdate");
            }
            else
            {
                recordToUpdate.NwcSubscriberFileName = NwcSubscriptionFileName;
                recordToUpdate.NwcSubscriberFileCity= NwcSubscriptionFilecity;
                recordToUpdate.NwcSubscriberFileArea = NwcSubscriptionFilearea;
                recordToUpdate.NwcSubscriberFileMobile = NwcSubscriptionFilephone;
                subscriberUpdate.SaveChanges();
                TempData["SuccessMessage"] = "تم التحديث بنجاح";
                return View("subscriberUpdate", model);
            }
        }


        public ActionResult CreateView()
        {
            var model = new NwcSubscriberFile();
            return View("SubscriberUpdate", model);
        }
    }
}
