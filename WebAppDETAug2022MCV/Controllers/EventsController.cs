using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WebAppDETAug2022MCV.Models;

namespace WebAppDETAug2022MCV.Controllers
{
    public class EventsController : Controller
    {
        private List<Booking> events;

        public IActionResult Index()
        {
            events = new List<Booking>();
            events.Add(new Booking { Title = "ask CEO",EventDate =DateTime.Today,Qty =10});
            return View(events);
        }
    }
}
