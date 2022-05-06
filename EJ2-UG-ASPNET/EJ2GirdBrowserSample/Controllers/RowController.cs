using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EJ2GirdBrowserSample.Controllers.DataBindingController;

namespace EJ2GirdBrowserSample.Controllers
{
    public class RowController : Controller
    {
        public IActionResult RowHeight()
        {
            var Emp = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Emp;
            return View();
        }
        public IActionResult RowTemplate()
        {
            var Emp = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Emp;
            return View();
        }
        public IActionResult DetailTemplate()
        {
            var Emp = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Emp;
            return View();
        }
        public IActionResult RowDragAndDrop()
        {
            var Emp = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Emp;
            return View();
        }
        public IActionResult RowSpanning()
        {
            var Emp = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Emp;
            return View();
        }
    }
}
