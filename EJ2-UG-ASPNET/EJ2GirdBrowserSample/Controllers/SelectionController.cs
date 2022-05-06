using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EJ2GirdBrowserSample.Controllers.DataBindingController;

namespace EJ2GirdBrowserSample.Controllers
{
    public class SelectionController : Controller
    {
        public IActionResult RowSelection()
        {
            var orders = OrderDetails.GetAllRecords();
            ViewBag.datasource = orders;
            return View();
        }
        public IActionResult CellSelection()
        {
            var orders = OrderDetails.GetAllRecords();
            ViewBag.datasource = orders;
            return View();
        }
        public IActionResult ColumnSelection()
        {
            var orders = OrderDetails.GetAllRecords();
            ViewBag.datasource = orders;
            return View();
        }
        public IActionResult CheckboxSelection()
        {
            var orders = OrderDetails.GetAllRecords();
            ViewBag.datasource = orders;
            return View();
        }
    }
}
