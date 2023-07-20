using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Water_Invoices_Project.Models;

namespace Water_Invoices_Project.Controllers
{
    public class RealEstateController : Controller
    {
        Water_InvoicesContext RealEstate = new Water_InvoicesContext();

        [HttpPost]
        public IActionResult UpdateRecord(IFormCollection  nwcRrealEstateType)
        {
            var model = new NwcRrealEstateType();
            string NwcRrealEstateTypesCode = nwcRrealEstateType["Code"];
            string NwcRrealEstateTypesName = nwcRrealEstateType["Name"];
            string NwcRrealEstateTypesReasons = nwcRrealEstateType["Reasons"];
            var recordToUpdate = RealEstate.NwcRrealEstateTypes.FirstOrDefault(r => r.NwcRrealEstateTypesCode == NwcRrealEstateTypesCode);
            if (recordToUpdate == null)
            {
                TempData["Failed Message"] = "برجاء التأكد من رمز العقار";
                return View("RealEstate", model);
            }
            else
            {
                recordToUpdate.NwcRrealEstateTypesName = NwcRrealEstateTypesName;
                recordToUpdate.NwcRrealEstateTypesReasons = NwcRrealEstateTypesReasons;
                RealEstate.SaveChanges();
                TempData["SuccessMessage"] = "تم التحديث بنجاح";
                return View("RealEstate", model);
            }
        }

       public ActionResult CreateView()
         {
            var model = new NwcRrealEstateType();
            return View("RealEstate",model);
           }

       
    }
}
