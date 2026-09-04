using Microsoft.AspNetCore.Mvc;
using data_board.Models;

namespace data_board.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var data = new ChartData
            {
                Labels = new[]
                {
                    "Januari",
                    "Februari",
                    "Maart",
                    "April",
                    "Mei",
                    "Juni",
                    "Juli",
                    "Augustus",
                    "September",
                    "Oktober",
                    "November",
                    "December"
                },

                ItemsSold = new[]
                {
                    1240,
                    1325,
                    1490,
                    1580,
                    1725,
                    1650,
                    1420,
                    1510,
                    1640,
                    1760,
                    1890,
                    2380
                },

                SalePrice = 34.95m,
                PurchaseCostPerItem = 12.80m,
                AdministrationCostPerItem = 2.35m,
                DeliveryCostPerItem = 4.10m,
                EmployeeCosts = 214500.00m
            };

            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}