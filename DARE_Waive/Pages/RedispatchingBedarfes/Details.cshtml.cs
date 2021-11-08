using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DARE_Waive.Data;
using DARE_Waive.Models;

namespace DARE_Waive.Pages.RedispatchingBedarfes
{
    public class DetailsModel : PageModel
    {
        private readonly DARE_Waive.Data.DARE_WaiveContext _context;

        public DetailsModel(DARE_Waive.Data.DARE_WaiveContext context)
        {
            _context = context;
        }

        public RedispatchingBedarfe RedispatchingBedarfe { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RedispatchingBedarfe = await _context.RedispatchingBedarfe.FirstOrDefaultAsync(m => m.ID == id);

            if (RedispatchingBedarfe == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
