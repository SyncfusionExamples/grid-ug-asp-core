using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EJ2GirdBrowserSample.Controllers.DataBindingController;

namespace EJ2GirdBrowserSample.Controllers
{
    public class StatePersistenceController : Controller
    {
        public IActionResult StatePersistence()
        {
            var orders = OrderDetails.GetAllRecords();
            ViewBag.datasource = orders;
            return View();
        }
        public IActionResult PreventtoPersist()
        {
            var orders = OrderDetails.GetAllRecords();
            ViewBag.datasource = orders;
            return View();
        }
    }
}
