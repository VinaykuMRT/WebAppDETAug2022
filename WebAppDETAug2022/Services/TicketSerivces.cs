using System.Xml.Linq;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Services
{
    public class TicketServices
    {
        static List<Ticket> Tickets { get; }
        static int nextId = 3;
        static TicketServices()
        {
            Tickets = new List<Ticket>
                {
                new Ticket{Match= "INDIA VS PAKISTAN "   ,Price=5000,Id=1},
                new Ticket{Match= "Sri Lanka VS INDIA"   ,Price=4000,Id=2},
                new Ticket{Match= " INDIA VS Afghanistan",Price=3000,Id=3}

                };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket? Get(int id) => Tickets.FirstOrDefault(p => p.Id == id);

        public static void Add(Ticket ticket)
        {
            ticket.Id = nextId++;
            Tickets.Add(ticket);
        }

        public static void Delete(int id)
        {
            var ticket = Get(id);
            if (ticket is null)
                return;

            Tickets.Remove(ticket);
        }

        public static void Update(Ticket ticket)
        {
            var index = Tickets.FindIndex(p => p.Id == ticket.Id);
            if (index == -1)
                return;

            Tickets[index] = ticket;
        }
    }
}