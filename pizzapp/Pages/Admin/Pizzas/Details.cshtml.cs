using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizzapp.Data;
using pizzapp.Models;

namespace pizzapp.Pages.Admin.Pizzas
{
    public class DetailsModel : PageModel
    {
        private readonly pizzapp.Data.DataContext _context;

        public DetailsModel(pizzapp.Data.DataContext context)
        {
            _context = context;
        }

      public Pizza Pizza { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Pizzas == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas.FirstOrDefaultAsync(m => m.PizzaId == id);
            if (pizza == null)
            {
                return NotFound();
            }
            else 
            {
                Pizza = pizza;
            }
            return Page();
        }
    }
}
