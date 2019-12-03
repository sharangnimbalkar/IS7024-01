using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalXmL.Models;

namespace FinalXmL.Pages.NewMunicipality
{
    public class CreateModel : PageModel
    {
        private readonly FinalXmL.Models.FinalXmLContext _context;

        public CreateModel(FinalXmL.Models.FinalXmLContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MunicipalityAdd MunicipalityAdd { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MunicipalityAdd.Add(MunicipalityAdd);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
