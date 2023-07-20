using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Water_Invoices_Project.Models;


namespace Water_Invoices_Project.Controllers
{
    public class InvoiceSearchController : Controller
    {
        Water_InvoicesContext SearchInvoices = new Water_InvoicesContext();
       
        [HttpPost]
        public JsonResult GetData(string invoice)
        {

            var model = new NwcInvoice();
            Console.WriteLine("NwcInvoicesNO value: " + invoice);

            var recordtoSearch = SearchInvoices.NwcInvoices.FirstOrDefault(r => r.NwcInvoicesNo == invoice);
            if (recordtoSearch == null)
            {
                Console.WriteLine("EMPTY");
                TempData["Failed Message"] = "برجاء التأكد من رقم الفاتورة";
            }

            DateTime Date = Convert.ToDateTime(recordtoSearch.NwcInvoicesDate);
            string NwcInvoicesDate = Date.ToString("yyyy-MM-dd");
            DateTime From = Convert.ToDateTime(recordtoSearch.NwcInvoicesFrom);
            string NwcInvoicesFrom = From.ToString("yyyy-MM-dd");
            DateTime To = Convert.ToDateTime(recordtoSearch.NwcInvoicesTo);
            string NwcInvoicesTo = To.ToString("yyyy-MM-dd");
            string NwcInvoicesSubscriptionNo = recordtoSearch.NwcInvoicesSubscriptionNo.ToString();
            string NwcInvoicesSubscriberNo = recordtoSearch.NwcInvoicesSubscriberNo.ToString();
            var result2 = (from file in SearchInvoices.NwcSubscriberFiles
                           where file.NwcSubscriberFileId == NwcInvoicesSubscriberNo
                           select file.NwcSubscriberFileName).ToList();

            string NwcSubscriberFileName = result2[0].ToString();

            string NwcInvoicesPreviousConsumptionAmount = recordtoSearch.NwcInvoicesPreviousConsumptionAmount.ToString();
            string NwcInvoicesCurrentConsumptionAmount = recordtoSearch.NwcInvoicesCurrentConsumptionAmount.ToString();
            string NwcInvoicesAmountConsumption = recordtoSearch.NwcInvoicesAmountConsumption.ToString();
            string NwcInvoicesServiceFee = recordtoSearch.NwcInvoicesServiceFee.ToString();
            string NwcInvoicesTaxRate = recordtoSearch.NwcInvoicesTaxRate.ToString();
            string sant = "نعم";
            if (recordtoSearch.NwcInvoicesIsThereSanitation ==false)
            {
                sant = "لا";
            }
            string NwcInvoicesConsumptionValue = recordtoSearch.NwcInvoicesConsumptionValue.ToString();
            string NwcInvoicesWastewaterConsumptionValue = recordtoSearch.NwcInvoicesWastewaterConsumptionValue.ToString();
            string NwcInvoicesTotalInvoice = recordtoSearch.NwcInvoicesTotalInvoice.ToString();
            string NwcInvoicesTaxValue = recordtoSearch.NwcInvoicesTaxValue.ToString();
            string NwcInvoicesTotalBill = recordtoSearch.NwcInvoicesTotalBill.ToString();
            var result = (from file in SearchInvoices.NwcSubscriptionFiles
                           where file.NwcSubscriptionFileNo == NwcInvoicesSubscriptionNo
                          select file.NwcSubscriptionFileUnitNo).ToList();

            string unit = result[0].ToString();

            return Json(new { data1 = NwcInvoicesDate, data2= NwcInvoicesFrom, 
                data3= NwcInvoicesTo , data4= unit, data5= NwcInvoicesSubscriptionNo, 
                data6= NwcInvoicesSubscriberNo, data7= NwcSubscriberFileName, data8= NwcInvoicesPreviousConsumptionAmount,
                data9= NwcInvoicesCurrentConsumptionAmount, data10= NwcInvoicesAmountConsumption, data11= NwcInvoicesServiceFee,
                data12= NwcInvoicesTaxRate, data13= sant, data14= NwcInvoicesConsumptionValue,data15= NwcInvoicesWastewaterConsumptionValue,
                data16= NwcInvoicesTotalInvoice, data17= NwcInvoicesTaxValue, data18= NwcInvoicesTotalBill
            });
        }

       










        //public IActionResult GetData(IFormCollection invoice)
        //{

        //        var model = new NwcInvoice();
        //        string NwcInvoicesNo = invoice["NwcInvoicesNo"];
        //    Console.WriteLine("NwcInvoicesNO value: " + NwcInvoicesNo);

        //    var recordtoSearch = SearchInvoices.NwcInvoices.FirstOrDefault(r => r.NwcInvoicesNo == NwcInvoicesNo);
        //        if (recordtoSearch == null)
        //        {
        //        Console.WriteLine("EMPTY");
        //        TempData["Failed Message"] = "برجاء التأكد من رقم الفاتورة";
        //            return View("InvoiceSearch", model);
        //        }

        //        string x = recordtoSearch.NwcInvoicesDate.ToString();

        //            //ViewBag.date = x;
        //            model.NwcInvoicesDate = recordtoSearch.NwcInvoicesDate;
        //        Console.WriteLine("NwcInvoicesDate value: " + model.NwcInvoicesDate);           
        //    return View(model);

        //}

        public IActionResult CreateView(IFormCollection invoice)
        {
            var model = new NwcInvoice();
            return View("InvoiceSearch", model);
        }

    }
}