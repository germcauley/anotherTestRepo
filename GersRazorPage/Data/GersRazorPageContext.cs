using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GersRazorPage.Models
{
    public class GersRazorPageContext : DbContext
    {
        public GersRazorPageContext (DbContextOptions<GersRazorPageContext> options)
            : base(options)
        {
        }

        public DbSet<GersRazorPage.Models.Movie> Movie { get; set; }
    }
}
