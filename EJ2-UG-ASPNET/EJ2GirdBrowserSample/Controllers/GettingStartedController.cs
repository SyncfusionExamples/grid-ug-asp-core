using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EJ2GirdBrowserSample.Controllers.DataBindingController;

namespace EJ2GirdBrowserSample.Controllers
{
    public class GettingStartedController : Controller
    {
        public IActionResult EnablePaging()
        {
            ViewBag.DataSource = OrderDetails.GetAllRecords();
            return View();
        }
        public IActionResult EnableSorting()
        {
            ViewBag.DataSource = OrderDetails.GetAllRecords();
            return View();
        }
        public IActionResult EnableFiltering()
        {
            ViewBag.DataSource = OrderDetails.GetAllRecords();
            return View();

        }
        public IActionResult EnableGrouping()
        {
            ViewBag.DataSource = OrderDetails.GetAllRecords();
            return View();
        }

    }
}
