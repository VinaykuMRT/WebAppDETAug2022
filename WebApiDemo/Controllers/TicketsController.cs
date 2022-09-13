using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;
using WebApiDemo.Services;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public List<Ticket> Get()
        {
            return TicketServices.GetAll();

        }

        [HttpGet]
        [Route("{ID}")]
        public Ticket Get(int ID)
        {
            Ticket t = TicketServices.Get(ID);
            return t;
        }

    }
}
