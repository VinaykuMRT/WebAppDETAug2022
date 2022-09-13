//using ContosoPizza.Models;
//using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;
using WebApiDemo.Services;

namespace WebApiDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() =>
    PizzaServices.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaServices.Get(id);

        if (pizza == null)
            return NotFound();

        return pizza;
    }
    [HttpPost]
    //public IActionResult Create(Pizza pizza)
    //{
    //    // This code will save the pizza and return a result
    //}
    //[HttpPut("{id}")]
    //public IActionResult Update(int id, Pizza pizza)
    //{
    //    // This code will update the pizza and return a result
    //}
    //[HttpDelete("{id}")]
    //public IActionResult Delete(int id)
    //{
    //    // This code will delete the pizza and return a result
    //}
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        PizzaServices.Add(pizza);
        return CreatedAtAction(nameof(Create), new { id = pizza.Id }, pizza);
    }
    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        if (id != pizza.Id)
            return BadRequest();

        var existingPizza = PizzaServices.Get(id);
        if (existingPizza is null)
            return NotFound();

        PizzaServices.Update(pizza);

        return NoContent();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pizza = PizzaServices.Get(id);

        if (pizza is null)
            return NotFound();

        PizzaServices.Delete(id);

        return NoContent();
    }
    // GET all action

    // GET by Id action

    // POST action

    // PUT action

    // DELETE action
}