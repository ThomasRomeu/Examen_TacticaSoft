using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Examen_TacticaSoft.Entidades;

namespace Examen_TacticaSoft._Pages_Productos
{
    public class DetailsModel : PageModel
    {
        private readonly Examen_TacticaSoft.Entidades.ApplicationDbContext _context;

        public DetailsModel(Examen_TacticaSoft.Entidades.ApplicationDbContext context)
        {
            _context = context;
        }

      public Producto Producto { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Productos == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos.FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            else 
            {
                Producto = producto;
            }
            return Page();
        }
    }
}
