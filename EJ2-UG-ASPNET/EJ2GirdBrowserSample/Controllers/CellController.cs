using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EJ2GirdBrowserSample.Controllers.DataBindingController;

namespace EJ2GirdBrowserSample.Controllers
{
    public class CellController : Controller
    {
        public IActionResult DisplayingHTMLContent()
        {
            var Order = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public IActionResult AutoWrap()
        {
            var Order = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public IActionResult ClipMode()
        {
            var Order = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
    }
}
