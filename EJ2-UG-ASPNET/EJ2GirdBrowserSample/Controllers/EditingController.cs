using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EJ2GirdBrowserSample.Controllers.DataBindingController;

namespace EJ2GirdBrowserSample.Controllers
{
    public class EditingController : Controller
    {
        public IActionResult InlineEditing()
        {
            var Order = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public IActionResult DialogEditing()
        {
            var Order = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public IActionResult BatchEditing()
        {
            var Order = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public IActionResult CommandColumnEditing()
        {
            var Order = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public IActionResult Validation()
        {
            var Emp = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Emp;
            return View();
        }
        public IActionResult UrlDatasource([FromBody] DataManagerRequest dm)
        {
            IEnumerable DataSource = OrderDetails.GetAllRecords();
            DataOperations operation = new DataOperations();
            int count = DataSource.Cast<OrderDetails>().Count();
            if (dm.Skip != 0)
            {
                DataSource = operation.PerformSkip(DataSource, dm.Skip);   //Paging
            }
            if (dm.Take != 0)
            {
                DataSource = operation.PerformTake(DataSource, dm.Take);
            }
            return dm.RequiresCounts ? Json(new { result = DataSource, count = count }) : Json(DataSource);
        }
    }
}
