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
    public class SubscriberReportController : Controller
    {
        Water_InvoicesContext nwcSubscriberFile = new Water_InvoicesContext();
        public IActionResult GetSubscriberReport()
        {
           var list= nwcSubscriberFile.NwcSubscriberFiles.ToList();
           var list2= nwcSubscriberFile.NwcSubscriptionFiles.ToList();
           
           var result = (from t1 in list
                          join t2 in list2
                          on t1.NwcSubscriberFileId equals t2.NwcSubscriptionFileSubscriberCode into t2Group
                          from t2 in t2Group.DefaultIfEmpty()
                          group t2 by new
                          {
                              t1.NwcSubscriberFileId,
                              t1.NwcSubscriberFileName,
                              t1.NwcSubscriberFileCity,
                              t1.NwcSubscriberFileArea,
                              t1.NwcSubscriberFileMobile
                          } into g
                          select new NwcSubscriberFile
                          {
                              NwcSubscriberFileId = g.Key.NwcSubscriberFileId,
                              NwcSubscriberFileName = g.Key.NwcSubscriberFileName,
                              NwcSubscriberFileCity = g.Key.NwcSubscriberFileCity,
                              NwcSubscriberFileArea= g.Key.NwcSubscriberFileArea,
                              NwcSubscriberFileMobile=  g.Key.NwcSubscriberFileMobile,
                              Counter = (g.Count(x => x != null))
                                 
                          }).Select((item, index) => new NwcSubscriberFile
                          {
                              NwcSubscriberFileId = item.NwcSubscriberFileId,
                              NwcSubscriberFileName = item.NwcSubscriberFileName,
                              NwcSubscriberFileCity = item.NwcSubscriberFileCity,
                              NwcSubscriberFileArea = item.NwcSubscriberFileArea,
                              NwcSubscriberFileMobile = item.NwcSubscriberFileMobile,
                              Counter = item.Counter,
                              M = index + 1
                          }).ToList();



            return View("SubscriberReport",result);
        }
    }
}
