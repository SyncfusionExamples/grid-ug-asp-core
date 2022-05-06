using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EJ2GirdBrowserSample.Controllers.DataBindingController;

namespace EJ2GirdBrowserSample.Controllers
{
    public class GroupingController : Controller
    {
        public IActionResult CaptionTemplate()
        {
            var Order = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public IActionResult ReorderingonGroupedColumns()
        {
            var Order = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public IActionResult LazyLoadGrouping()
        {
            var Order = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
    }
}
    