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
                    100,
                    150,
                    125,
                    200,
                    250,
                    175,
                    20,
                    300,
                    180,
                    266,
                    85,
                    300
                },

                SalePrice = 10.00m,
                PurchaseCostPerItem = 0.73m,
                AdministrationCostPerItem = 0.20m,
                DeliveryCostPerItem = 2.50m,
                EmployeeCosts = 200.00m
            };

            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}