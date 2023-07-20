using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Water_Invoices_Project.Models;

namespace Water_Invoices_Project.Controllers
{

    public class InvoiceRegisterationController : Controller
    {
        Water_InvoicesContext AddInvoice = new Water_InvoicesContext();
        static string InoviceNum="";
        static DateTime NwcInvoicesTo;
        static decimal firstSlice = 0.0m;
        static decimal secondSlice = 0.0m;
        static decimal thirdSlice = 0.0m;
        static decimal forthSlice = 0.0m;
        static decimal fifthSlice = 0.0m;
        static int numm;
        static Tuple<List<int>, int> SplitNumber(int num)
        {
            List<int> result = new List<int>();
            while (num > 0 && result.Count < 4)
            {
                if (num <= (15 * numm))
                {
                    result.Add(num);
                    break;
                }
                else
                {
                    result.Add((15 * numm));
                    num -= (15 * numm);
                }
            }
            return Tuple.Create(result, num);
        }

        public JsonResult CalculateUsage(string Now, string last)
        {

            int Result = (int.Parse(Now) - int.Parse(last));
            string NowUsage = Result.ToString();



            return Json(new { data6 = NowUsage });

        }

        public decimal CalculateWater(string water, string unit)
        {

            int WaterUsage = int.Parse(water);
            numm = int.Parse(unit);
            Tuple<List<int>, int> splitResult = SplitNumber(WaterUsage);
            List<int> groups = splitResult.Item1;
            int remainingSum = 0;
            decimal priceWater = 0.0m;
            int SliceMax = (15 * int.Parse(unit));
            if (WaterUsage != (4 * SliceMax))
            {
                remainingSum = splitResult.Item2;
            }
            if (WaterUsage <= 4 * SliceMax)
            {
                if (WaterUsage <= SliceMax)
                {
                    int first = groups[0];
                    priceWater = ((first * firstSlice));
                }
                else if (WaterUsage <= 2 * SliceMax)
                {
                    int first2 = groups[0];
                    int second2 = groups[1];
                    priceWater = ((first2 * firstSlice) + (second2 * secondSlice));
                }
                else if (WaterUsage <= 3 * SliceMax)
                {
                    int first3 = groups[0];
                    int second3 = groups[1];
                    int third3 = groups[2];

                    priceWater = ((first3 * firstSlice) + (second3 * secondSlice) + (third3 * thirdSlice));
                }
                else if (WaterUsage <= 4 * SliceMax)
                {
                    int first4 = groups[0];
                    int second4 = groups[1];
                    int third4 = groups[2];
                    int fourth4 = groups[3];
                    priceWater = ((first4 * firstSlice) + (second4 * secondSlice) + (third4 * thirdSlice) + (fourth4 * forthSlice));
                }

            }
            else if (WaterUsage > 4 * SliceMax)
            {
                int first5 = groups[0];
                int second5 = groups[1];
                int third5 = groups[2];
                int fourth5 = groups[3];
                int fifth = remainingSum;
                priceWater = ((first5 * firstSlice) + (second5 * secondSlice) + (third5 * thirdSlice) + (fourth5 * forthSlice) + (fifth * fifthSlice));
            }
            return priceWater;
        }
        public decimal CalculateWaste(decimal water, string santin)
        {
            decimal PriceWaste = 0.0m;
            string TxtWasteWater = santin;
            if (TxtWasteWater == "نعم")
            {
                PriceWaste = water * .5m;
            }

            return PriceWaste;
        }


        public JsonResult CalculateTax(string water, string unit, string ServiceFee, string Serviceperc, string santinuse)
        {
            decimal TaxValue = 0.0m;
            decimal priceWater = CalculateWater(water, unit);
            decimal PriceWaste = CalculateWaste(priceWater, santinuse);
            decimal TotalPrice = 0.0m;
            decimal InvoicePrice = 0.0m;
            string value = ServiceFee;
            decimal servicePrice = Convert.ToDecimal(value);

            string txtWaterUsagePrice = priceWater.ToString();
            string txtWaterWastePrice = PriceWaste.ToString();
            TotalPrice = (servicePrice + priceWater + PriceWaste);
            string TxtInvoicePrice = TotalPrice.ToString();
            TaxValue = (decimal.Parse(Serviceperc) / 100) * TotalPrice;
            InvoicePrice = (TaxValue + TotalPrice);
            string TxtInvoicePriceTotalBill = InvoicePrice.ToString();

            return Json(new { data1 = txtWaterUsagePrice, data2 = txtWaterWastePrice, data3 = TxtInvoicePrice, data4 = TxtInvoicePriceTotalBill });

        }


        [HttpPost]
        public ActionResult SaveInvoice(NwcInvoice invoice)
        {
            if (Request.Form["NwcInvoicesDate"].ToString() != "" && Request.Form["NwcInvoicesTo"].ToString() != "" && Request.Form["NwcInvoicesFrom"] != "")
            {
                string NwcInvoicesNo = Request.Form["NwcInvoicesNo"];
                DateTime NwcInvoicesDate = Convert.ToDateTime(Request.Form["NwcInvoicesDate"]);
                string Year = NwcInvoicesDate.ToString("yy");
                string NwcInvoicesSubscriberNo = Request.Form["NwcInvoicesSubscriberNo"];

                var query = AddInvoice.NwcSubscriptionFiles
                  .Where(x => x.NwcSubscriptionFileSubscriberCode == NwcInvoicesSubscriberNo)
                   .Select(x => x.NwcSubscriptionFileRrealEstateTypesCode).FirstOrDefault();
                string NwcInvoicesRrealEstateTypes = "";
                if (query != null)
                {
                    NwcInvoicesRrealEstateTypes = query;
                }
                string NwcInvoicesSubscriptionNo = Request.Form["NwcInvoicesSubscriptionNo"];
                string SubscriberName = Request.Form["SubscriberName"];
                DateTime NwcInvoicesFrom = Convert.ToDateTime(Request.Form["NwcInvoicesFrom"]);

                DateTime NwcInvoicesTo = Convert.ToDateTime(Request.Form["NwcInvoicesTo"]);

                decimal NwcInvoicesPreviousConsumptionAmount = Convert.ToDecimal(Request.Form["NwcInvoicesPreviousConsumptionAmount"]);
                decimal NwcInvoicesCurrentConsumptionAmount = Convert.ToDecimal(Request.Form["NwcInvoicesCurrentConsumptionAmount"]);
                decimal NwcInvoicesAmountConsumption = Convert.ToDecimal(Request.Form["NwcInvoicesAmountConsumption"]);
                decimal NwcInvoicesServiceFee = Convert.ToDecimal(Request.Form["NwcInvoicesServiceFee"]);
                decimal NwcInvoicesTaxRate = Convert.ToDecimal(Request.Form["NwcInvoicesTaxRate"]);
                string NwcInvoicesIsThereSanitation = Request.Form["NwcInvoicesIsThereSanitation"];
                decimal NwcInvoicesConsumptionValue = Convert.ToDecimal(Request.Form["NwcInvoicesConsumptionValue"]);
                decimal NwcInvoicesWastewaterConsumptionValue = Convert.ToDecimal(Request.Form["NwcInvoicesWastewaterConsumptionValue"]);
                decimal NwcInvoicesTotalInvoice = Convert.ToDecimal(Request.Form["NwcInvoicesTotalInvoice"]);
                decimal NwcInvoicesTaxValue = Convert.ToDecimal(Request.Form["NwcInvoicesTaxValue"]);
                decimal NwcInvoicesTotalBill = Convert.ToDecimal(Request.Form["NwcInvoicesTotalBill"]);
                if (NwcInvoicesIsThereSanitation == "لا")
                {
                    invoice.Waste = false;
                }
                else
                {
                    invoice.Waste = true;
                }
                bool WasteVal = invoice.Waste;
                int Unit = Convert.ToInt32(Request.Form["Unit"]);

                invoice.Unit = Unit;
                invoice.NwcInvoicesNo = NwcInvoicesNo;

                invoice.NwcInvoicesYear = Year;
                invoice.NwcInvoicesRrealEstateTypes = NwcInvoicesRrealEstateTypes;
                invoice.NwcInvoicesSubscriptionNo = NwcInvoicesSubscriptionNo;
                invoice.SubscriberName = SubscriberName;
                invoice.NwcInvoicesSubscriberNo = NwcInvoicesSubscriberNo;
                invoice.NwcInvoicesDate = NwcInvoicesDate;
                invoice.NwcInvoicesFrom = NwcInvoicesFrom;

                invoice.NwcInvoicesTo = NwcInvoicesTo;

                invoice.NwcInvoicesPreviousConsumptionAmount = NwcInvoicesPreviousConsumptionAmount;
                invoice.NwcInvoicesCurrentConsumptionAmount = NwcInvoicesCurrentConsumptionAmount;
                invoice.NwcInvoicesAmountConsumption = NwcInvoicesAmountConsumption;
                invoice.NwcInvoicesServiceFee = NwcInvoicesServiceFee;
                invoice.NwcInvoicesTaxRate = NwcInvoicesTaxRate;
                invoice.NwcInvoicesIsThereSanitation = WasteVal;
                invoice.NwcInvoicesConsumptionValue = NwcInvoicesConsumptionValue;
                invoice.NwcInvoicesWastewaterConsumptionValue = NwcInvoicesWastewaterConsumptionValue;
                invoice.NwcInvoicesTotalInvoice = NwcInvoicesTotalInvoice;
                invoice.NwcInvoicesTaxValue = NwcInvoicesTaxValue;
                invoice.NwcInvoicesTotalBill = NwcInvoicesTotalBill;

                AddInvoice.NwcInvoices.Add(invoice);
                AddInvoice.SaveChanges();
                UpdateLastReading(NwcInvoicesTaxRate, NwcInvoicesTotalInvoice, NwcInvoicesNo, NwcInvoicesCurrentConsumptionAmount, NwcInvoicesSubscriptionNo);
                TempData["SuccessMessage"] = "تم الحفظ بنجاح";

            }
            
            return View("InvoiceRegisteration", invoice);
        }

        public void UpdateTaxValue(decimal NwcInvoicesTaxRate, decimal NwcInvoicesTotalInvoice, string NwcInvoicesNo)
        {
            decimal TaxValue = 0.0m;
            TaxValue = ((NwcInvoicesTaxRate / 100) * NwcInvoicesTotalInvoice);

            var invoice = AddInvoice.NwcInvoices
                        .Where(x => x.NwcInvoicesNo == NwcInvoicesNo).FirstOrDefault();
             if (invoice != null)
                    {
                        invoice.NwcInvoicesTaxValue = TaxValue;
                        AddInvoice.SaveChanges();
                    }
           
        }
        public void UpdateLastReading(decimal NwcInvoicesTaxRate, decimal NwcInvoicesTotalInvoice, string NwcInvoicesNo ,decimal NwcInvoicesCurrentConsumptionAmount,string NwcInvoicesSubscriptionNo)
        {
            var subscriptionFile = AddInvoice.NwcSubscriptionFiles
        .Where(x => x.NwcSubscriptionFileNo == NwcInvoicesSubscriptionNo)
        .FirstOrDefault();


                subscriptionFile.NwcSubscriptionFileLastReadingMeter = NwcInvoicesCurrentConsumptionAmount;
                AddInvoice.SaveChanges();
                UpdateTaxValue(NwcInvoicesTaxRate, NwcInvoicesTotalInvoice, NwcInvoicesNo);

            

        }
        public ActionResult CreateView()
        {
            var model = new NwcInvoice();
            while (true)
            {
                DateTime now = DateTime.Now;
                int year = now.Year;
                int month = now.Month;
                Random random = new Random();
                string TimeNow = now.ToString("yyyy-MM-dd");
                DateTime FormDate = Convert.ToDateTime(TimeNow);
                int randomNumber = random.Next(1, 100);
                string subNum = $"{year}-{month:D2}-{randomNumber:D2}";

                var recordtoSearch = AddInvoice.NwcInvoices.FirstOrDefault(r => r.NwcInvoicesNo == subNum);
                if (recordtoSearch == null)
                {
                    model.NwcInvoicesNo = subNum;
                    model.NwcInvoicesTo = FormDate;
                    InoviceNum = subNum;
                    NwcInvoicesTo = FormDate;
                    break;
                }
                else
                {
                    continue;
                }
            }
            var query = AddInvoice.NwcDefaultSliceValues.Take(5)
                .Select(x => x.NwcDefaultSliceValuesWaterPrice).ToList();

            if (query.Any())
            {
                firstSlice = (decimal)query.ElementAtOrDefault(0);
                secondSlice = (decimal)query.ElementAtOrDefault(1);
                thirdSlice = (decimal)query.ElementAtOrDefault(2);
                forthSlice = (decimal)query.ElementAtOrDefault(3);
                fifthSlice = (decimal)query.ElementAtOrDefault(4);
            }
            return View("InvoiceRegisteration", model);

        }

        [HttpPost]
        public JsonResult GetSubrData(string subscriberNo)
        {
            var result = (from file in AddInvoice.NwcSubscriptionFiles
                         where file.NwcSubscriptionFileNo == subscriberNo
                         select new
                         {
                             file.NwcSubscriptionFileSubscriberCode,
                             file.NwcSubscriptionFileIsThereSanitation,
                             file.NwcSubscriptionFileLastReadingMeter,
                             file.NwcSubscriptionFileUnitNo,

                         }).ToList();
            string data1 = "";
            string data2 = "";
            string data3 = "";
            string data4 = "";
            foreach (var item in result)
            {
                 data1 = item.NwcSubscriptionFileSubscriberCode.ToString();
                 data2 = item.NwcSubscriptionFileIsThereSanitation.ToString();
                 data3 = item.NwcSubscriptionFileLastReadingMeter.ToString();
                data4 = item.NwcSubscriptionFileUnitNo.ToString();

            }

            if (data2=="0")
            {
                data2 = "لا";
            }
            else
            {
                data2 = "نعم";
            }
            var result2 = (from file in AddInvoice.NwcSubscriberFiles
                          where file.NwcSubscriberFileId == data1
                           select file.NwcSubscriberFileName).ToList();

            string data5 = result2[0].ToString();
            return Json(new { data1 = data1, data2 = data2, data3 = data3 ,data4=data4,data5=data5});

        }

    }
}
