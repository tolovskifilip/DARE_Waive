﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly DARE_Waive.Data.DARE_WaiveContext _context;

        public IndexModel(DARE_Waive.Data.DARE_WaiveContext context)
        {
            _context = context;
        }

        public IList<RedispatchingBedarfe> RedispatchingBedarfe { get;set; }

        public async Task OnGetAsync()
        {
            RedispatchingBedarfe = await _context.RedispatchingBedarfe.ToListAsync();
        }
    }
}