using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EJ2GirdBrowserSample.Controllers.DataBindingController;

namespace EJ2GirdBrowserSample.Controllers
{
    public class ScrollingController : Controller
    {
        public IActionResult Scrolling()
        {
            var orders = OrderDetails.GetAllRecords();
            ViewBag.datasource = orders;
            return View();
        }
    }
}
