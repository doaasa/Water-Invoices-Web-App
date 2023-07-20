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
    public class InvoicesReportController : Controller
    {
        Water_InvoicesContext nwcInvoices = new Water_InvoicesContext();

        public IActionResult GetInvoicesReport()
        {
            var list = nwcInvoices.NwcSubscriberFiles.ToList();
            var list2 = nwcInvoices.NwcInvoices.ToList();

            var result = ( from t1 in list2
                        join t2 in list on t1.NwcInvoicesSubscriberNo equals t2.NwcSubscriberFileId into t2Join
                        from t2 in t2Join.DefaultIfEmpty()
                        select new NwcInvoice
                        {
                           NwcInvoicesNo= t1.NwcInvoicesNo,
                            NwcInvoicesSubscriptionNo= t1.NwcInvoicesSubscriptionNo,
                            NwcInvoicesSubscriberNo=t1.NwcInvoicesSubscriberNo,
                            SubscriberName=( t1.NwcInvoicesSubscriberNo = t2.NwcSubscriberFileId == null ? null : t2.NwcSubscriberFileName),

                            Date= t1.NwcInvoicesDate.ToString(),
                           NwcInvoicesPreviousConsumptionAmount= t1.NwcInvoicesPreviousConsumptionAmount,
                           NwcInvoicesCurrentConsumptionAmount= t1.NwcInvoicesCurrentConsumptionAmount,
                            NwcInvoicesAmountConsumption= t1.NwcInvoicesAmountConsumption,
                            NwcInvoicesTotalInvoice=t1.NwcInvoicesTotalInvoice,
                            NwcInvoicesTotalBill= t1.NwcInvoicesTotalBill
                        }).Select((item, index) => new NwcInvoice
                        {
                            NwcInvoicesNo = item.NwcInvoicesNo,
                            NwcInvoicesSubscriptionNo = item.NwcInvoicesSubscriptionNo,
                            NwcInvoicesSubscriberNo = item.NwcInvoicesSubscriberNo,
                            SubscriberName = item.SubscriberName,
                            Date = item.Date,
                            NwcInvoicesPreviousConsumptionAmount = item.NwcInvoicesPreviousConsumptionAmount,
                            NwcInvoicesCurrentConsumptionAmount = item.NwcInvoicesCurrentConsumptionAmount,
                            NwcInvoicesAmountConsumption = item.NwcInvoicesAmountConsumption,
                            NwcInvoicesTotalInvoice = item.NwcInvoicesTotalInvoice,
                            NwcInvoicesTotalBill = item.NwcInvoicesTotalBill,
                            M = index + 1
                        }).ToList();



            return View("InvoicesReport", result);

        }

       
    }
}
