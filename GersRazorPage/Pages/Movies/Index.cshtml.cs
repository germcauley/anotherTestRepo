using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GersRazorPage.Models;

namespace GersRazorPage.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly GersRazorPage.Models.GersRazorPageContext _context;

        public IndexModel(GersRazorPage.Models.GersRazorPageContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
