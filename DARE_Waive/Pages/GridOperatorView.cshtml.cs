using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DARE_Waive.Pages
{
    public class GridOperatorViewModel : PageModel
    {
        private readonly ILogger<GridOperatorViewModel> _logger;

        public GridOperatorViewModel(ILogger<GridOperatorViewModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
