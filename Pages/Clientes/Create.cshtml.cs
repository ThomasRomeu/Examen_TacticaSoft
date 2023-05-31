using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Examen_TacticaSoft.Entidades;

namespace Examen_TacticaSoft._Pages_Clientes
{
    public class CreateModel : PageModel
    {
        private readonly Examen_TacticaSoft.Entidades.ApplicationDbContext _context;
        [TempData]
        public string MensajeExitoso { get; set; }

        public CreateModel(Examen_TacticaSoft.Entidades.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cliente Cliente { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          
            _context.Clientes.Add(Cliente);
            MensajeExitoso = "Se creo correctamente el Cliente" + "" + Cliente.Nombre;
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
