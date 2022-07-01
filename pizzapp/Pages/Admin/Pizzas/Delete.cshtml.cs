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
    public class DeleteModel : PageModel
    {
        private readonly pizzapp.Data.DataContext _context;

        public DeleteModel(pizzapp.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Pizzas == null)
            {
                return NotFound();
            }
            var pizza = await _context.Pizzas.FindAsync(id);

            if (pizza != null)
            {
                Pizza = pizza;
                _context.Pizzas.Remove(Pizza);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
