using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Examen_TacticaSoft.Entidades;

namespace Examen_TacticaSoft._Pages_Ventas
{
    public class DeleteModel : PageModel
    {
        private readonly Examen_TacticaSoft.Entidades.ApplicationDbContext _context;

        public DeleteModel(Examen_TacticaSoft.Entidades.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Venta Venta { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Ventas == null)
            {
                return NotFound();
            }

            var venta = await _context.Ventas.FirstOrDefaultAsync(m => m.Id == id);

            if (venta == null)
            {
                return NotFound();
            }
            else 
            {
                Venta = venta;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Ventas == null)
            {
                return NotFound();
            }
            var venta = await _context.Ventas.FindAsync(id);

            if (venta != null)
            {
                Venta = venta;
                _context.Ventas.Remove(Venta);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
