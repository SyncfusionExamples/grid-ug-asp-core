﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJ2GirdBrowserSample.Controllers
{
    public class InfiniteScrollingController : Controller
    {
        public IActionResult InfiniteScrolling()
        {
            return View();
        }
    }
}
