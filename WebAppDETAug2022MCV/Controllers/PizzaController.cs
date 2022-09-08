using Microsoft.AspNetCore.Mvc;
using WebAppDETAug2022MCV.Models;
using WebAppDETAug2022MCV.PizzaServices;


namespace WebAppDETAug2022MCV.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            {
                List<Pizza> pizzas = PizzaServices.PizzaServices.GetAll();
                return View(pizzas);

            }
        }

        public IActionResult Detail(int id)
        {
            Pizza p = PizzaServices.PizzaServices.Get(id);
            return View(p);
        }
        public IActionResult List(int id)
        {
            List<Pizza> pizzas = PizzaServices.PizzaServices.GetAll();
            return View(pizzas);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Create(Pizza p)
        {
            PizzaServices.PizzaServices.Add(p);
            return RedirectToAction("List");
        }
        public IActionResult Delete(int Id)
        {
            Pizza p = PizzaServices.PizzaServices.Get(Id);
            if (p != null)
                return View(p);
            else
                return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(Pizza p)
        {
            PizzaServices.PizzaServices.Delete(p.Id);
            return RedirectToAction("List");
        }
    }
}