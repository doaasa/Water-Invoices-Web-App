using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Water_Invoices_Project.Controllers
{
    public class MyController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Button9()
        {
            // Get the current process ID
            int currentProcessId = Process.GetCurrentProcess().Id;

            // Get the current process
            Process currentProcess = Process.GetProcessById(currentProcessId);

            // Stop the current process
            currentProcess.Kill();
            // Return a view or redirect to another page
            return View();

        }
        // Define similar action methods for Buttons 3 through 9
    }
}
