using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DARE_Waive.Data;
using DARE_Waive.Models;

namespace DARE_Waive.Pages.PlanungsDatenAnlagens
{
    public class DeleteModel : PageModel
    {
        private readonly DARE_Waive.Data.DARE_WaiveContext _context;

        public DeleteModel(DARE_Waive.Data.DARE_WaiveContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PlanungsDatenAnlagen = await _context.PlanungsDatenAnlagen.FindAsync(id);

            if (PlanungsDatenAnlagen != null)
            {
                _context.PlanungsDatenAnlagen.Remove(PlanungsDatenAnlagen);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
