using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DARE_Waive.Data;
using DARE_Waive.Models;

namespace DARE_Waive.Pages.AktivierungsDokumentes
{
    public class EditModel : PageModel
    {
        private readonly DARE_Waive.Data.DARE_WaiveContext _context;

        public EditModel(DARE_Waive.Data.DARE_WaiveContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AktivierungsDokumente AktivierungsDokumente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AktivierungsDokumente = await _context.AktivierungsDokumente.FirstOrDefaultAsync(m => m.ID == id);

            if (AktivierungsDokumente == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AktivierungsDokumente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AktivierungsDokumenteExists(AktivierungsDokumente.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AktivierungsDokumenteExists(int id)
        {
            return _context.AktivierungsDokumente.Any(e => e.ID == id);
        }
    }
}
