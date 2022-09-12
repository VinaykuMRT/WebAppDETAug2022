using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppDETAug2022MCV.Models;

namespace WebAppDETAug2022MCV.Data
{
    public class PizzaContext : DbContext
    {
        public PizzaContext (DbContextOptions<PizzaContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppDETAug2022MCV.Models.Pizza> Pizza { get; set; } = default!;
    }
}
