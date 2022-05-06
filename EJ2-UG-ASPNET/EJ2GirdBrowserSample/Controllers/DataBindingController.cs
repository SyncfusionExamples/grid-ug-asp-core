using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EJ2GirdBrowserSample.Controllers
{
    public class DataBindingController : Controller
    {
        public static List<OrderDetails> order = new List<OrderDetails>();
        private readonly ILogger<DataBindingController> _logger;
        public object DataSource { get; set; }

        public DataBindingController(ILogger<DataBindingController> logger)
        {
            _logger = logger;
        }
        public IActionResult SendingAdditonalParamtotheServer()
        {
            var Order = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
        public IActionResult HandlingHTTPerror()
        {
            return View();
        }
        public IActionResult LocalData()
        { 
            var Order = OrderDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }

        public IActionResult RemoteData()
        {
            return View();
        }

        public IActionResult DataTable()
        {
            DataTable dt = new DataTable("Table");
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("OrderID", typeof(long)),
        new DataColumn("CustomerID", typeof(string)),
        new DataColumn("EmployeeID",typeof(int)),
        new DataColumn("OrderDate",typeof(DateTime))
    });
            int code = 10000;
            for (int i = 1; i < 10; i++)
            {
                dt.Rows.Add(code + 1, "ALFKI", i + 0, new DateTime(1991, 05, 15));
                dt.Rows.Add(code + 2, "ANATR", i + 2, new DateTime(1990, 04, 04));
                dt.Rows.Add(code + 3, "ANTON", i + 1, new DateTime(1957, 11, 30));
                dt.Rows.Add(code + 4, "BLONP", i + 3, new DateTime(1930, 10, 22));
                dt.Rows.Add(code + 5, "BOLID", i + 4, new DateTime(1953, 02, 18));
                code += 5;
            }
            ViewBag.DataSource = dt;
            return View();
        }
        public IActionResult ImmutableMode()
        {
            ViewBag.DataSource = OrderDetails.GetAllRecords();
            return View();
        }

        public class OrderDetails
        {
            public OrderDetails()
            {

            }
            public OrderDetails(long OrderId, string CustomerId, int EmployeeId, double Freight, DateTime OrderDate, string ShipCity, string ShipCountry)
            {
                this.OrderID = OrderId;
                this.CustomerID = CustomerId;
                this.EmployeeID = EmployeeId;
                this.Freight = Freight;
                this.OrderDate = OrderDate;
                this.ShipCity = ShipCity;
                this.ShipCountry = ShipCountry;
            }

            public static List<OrderDetails> GetAllRecords()
            {
                if (order.Count == 0)
                {
                    int code = 10000;
                    for (int i = 1; i < 10; i++)
                    {
                        order.Add(new OrderDetails(code + 1, "ALFKI", i + 0, 2.3 * i, new DateTime(1991, 05, 15), "Berlin", "Denmark"));
                        order.Add(new OrderDetails(code + 2, "ANATR", i + 2, 3.3 * i, new DateTime(1990, 04, 04), "Madrid", "Brazil"));
                        order.Add(new OrderDetails(code + 3, "ANTON", i + 1, 4.3 * i, new DateTime(1957, 11, 30), "Cholchester", "Germany"));
                        order.Add(new OrderDetails(code + 4, "BLONP", i + 3, 5.3 * i, new DateTime(1930, 10, 22), "Marseille", "Austria"));
                        order.Add(new OrderDetails(code + 5, "BOLID", i + 4, 6.3 * i, new DateTime(1953, 02, 18), "Tsawassen", "Switzerland"));
                        code += 5;
                    }
                }
                return order;
            }

            public long OrderID { get; set; }
            [Required]
            public string CustomerID { get; set; }
            public int EmployeeID { get; set; }
            public double Freight { get; set; }
            public DateTime OrderDate { get; set; }
            public string ShipCity { get; set; }
            public string ShipCountry { get; set; }
        }
    }

}
