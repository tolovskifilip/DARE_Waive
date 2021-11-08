using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DARE_Waive.Pages
{
    public class PublicViewModel : PageModel
    {
        private readonly ILogger<PublicViewModel> _logger;

        public PublicViewModel(ILogger<PublicViewModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
