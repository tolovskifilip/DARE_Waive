using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DARE_Waive.Data;
using DARE_Waive.Models;

namespace DARE_Waive.Pages.PlanungsDatenAnlagens
{
    public class CreateModel : PageModel
    {
        private readonly DARE_Waive.Data.DARE_WaiveContext _context;

        public CreateModel(DARE_Waive.Data.DARE_WaiveContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PlanungsDatenAnlagen PlanungsDatenAnlagen { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PlanungsDatenAnlagen.Add(PlanungsDatenAnlagen);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
