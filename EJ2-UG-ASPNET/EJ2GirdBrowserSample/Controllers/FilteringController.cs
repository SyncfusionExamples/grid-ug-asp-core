using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EJ2GirdBrowserSample.Controllers.DataBindingController;

namespace EJ2GirdBrowserSample.Controllers
{
    public class FilteringController : Controller
    {
        public IActionResult FilterBar()
        {
            var Order = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public IActionResult FilterMenu()
        {
            var Order = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public IActionResult ExcelLikeFilter()
        {
            var Order = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
    }
}
