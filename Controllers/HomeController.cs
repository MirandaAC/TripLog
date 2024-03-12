using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TripLog.Models;

namespace TripLog.Controllers
{
    public class HomeController : Controller
    {

        private TripContext context;

        public HomeController(TripContext ctx) { 
            context = ctx;
        }

        public IActionResult Index()
        {
            var trips = context.Trips.ToList();
            return View(trips);
        }


    }
}
