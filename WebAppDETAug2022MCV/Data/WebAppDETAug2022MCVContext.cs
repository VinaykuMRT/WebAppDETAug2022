using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppDETAug2022MCV.Models;

namespace WebAppDETAug2022MCV.Data
{
    public class WebAppDETAug2022MCVContext : DbContext
    {
        public WebAppDETAug2022MCVContext (DbContextOptions<WebAppDETAug2022MCVContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppDETAug2022MCV.Models.Booking> Booking { get; set; } = default!;

        public DbSet<WebAppDETAug2022MCV.Models.Friend>? Friend { get; set; }

        public DbSet<WebAppDETAug2022MCV.Models.Pizza>? Pizza { get; set; }
    }
}
