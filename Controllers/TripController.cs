using Microsoft.AspNetCore.Mvc;
using TripLog.Models;

namespace TripLog.Controllers
{
    public class TripController : Controller
    {
        private readonly TripContext context;

        public TripController(TripContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add(string id = "")
        {
            var vm = new TripViewModel();
            switch (id)
            {
                case "1":
                    vm.PageNum = 1;
                    return View("Add1", vm);
                case "2":
                    vm.PageNum = 2;
                    return View("Add2", vm);
                case "3":
                    return View("Add3");
                default:
                    return View("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult Add(TripViewModel vm)
        {
            if (vm.PageNum == 1)
            {
                    TempData["Destination"] = vm.trip.Destination;
                    TempData["Accomodation"] = vm.trip.Accomodation;
                    TempData["StartDate"] = vm.trip.StartDate;
                    TempData["EndDate"] = vm.trip.EndDate;
                    return RedirectToAction("Add", new { id = "2" });
            }
            else if (vm.PageNum == 2)
            {
                TempData["Phone"] = vm.trip.Phone;
                TempData["Email"] = vm.trip.Email;
                return RedirectToAction("Add", new { id = "3" });
            }
            else
            {
                Trip trip = new Trip()
                {
                    Destination = TempData["Destination"].ToString(),
                    Accomodation = TempData["Accomodation"].ToString(),
                    StartDate = (System.DateTime)TempData["StartDate"],
                    EndDate = (System.DateTime)TempData["EndDate"],
                    Phone = TempData["Phone"].ToString(),
                    Email = TempData["Email"].ToString(),
                    Thingstodo1 = vm.trip.Thingstodo1,
                    Thingstodo2 = vm.trip.Thingstodo2,
                    Thingstodo3 = vm.trip.Thingstodo3
                };
                context.Add(trip);
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
