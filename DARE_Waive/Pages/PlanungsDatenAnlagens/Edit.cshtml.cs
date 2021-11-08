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

namespace DARE_Waive.Pages.PlanungsDatenAnlagens
{
    public class EditModel : PageModel
    {
        private readonly DARE_Waive.Data.DARE_WaiveContext _context;

        public EditModel(DARE_Waive.Data.DARE_WaiveContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PlanungsDatenAnlagen PlanungsDatenAnlagen { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PlanungsDatenAnlagen = await _context.PlanungsDatenAnlagen.FirstOrDefaultAsync(m => m.ID == id);

            if (PlanungsDatenAnlagen == null)
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

            _context.Attach(PlanungsDatenAnlagen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanungsDatenAnlagenExists(PlanungsDatenAnlagen.ID))
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

        private bool PlanungsDatenAnlagenExists(int id)
        {
            return _context.PlanungsDatenAnlagen.Any(e => e.ID == id);
        }
    }
}
