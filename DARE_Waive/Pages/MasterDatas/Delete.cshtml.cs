using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DARE_Waive.Data;
using DARE_Waive.Models;

namespace DARE_Waive.Pages.MasterDatas
{
    public class DeleteModel : PageModel
    {
        private readonly DARE_Waive.Data.DARE_WaiveContext _context;

        public DeleteModel(DARE_Waive.Data.DARE_WaiveContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MasterData MasterData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MasterData = await _context.MasterData.FirstOrDefaultAsync(m => m.ID == id);

            if (MasterData == null)
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

            MasterData = await _context.MasterData.FindAsync(id);

            if (MasterData != null)
            {
                _context.MasterData.Remove(MasterData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
