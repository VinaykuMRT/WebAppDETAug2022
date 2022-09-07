using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Pages
{
    public class IPLeventsModel : PageModel
    {
        public List<Ticket> Tickets { get; set; }
        public void OnGet()
        {
            Tickets = new list<Ticket>
            {
               new Ticket{Match= "INDIA VS PAKISTAN "   ,Price=5000,Id=1},
                new Ticket{Match= "Sri Lanka VS INDIA"   ,Price=4000,Id=2},
                new Ticket{Match= " INDIA VS Afghanistan",Price=3000,Id=3}

            };
        }
    }
}
