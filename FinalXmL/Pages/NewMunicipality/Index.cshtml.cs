using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalXmL.Models;

namespace FinalXmL.Pages.NewMunicipality
{
    public class IndexModel : PageModel
    {
        private readonly FinalXmL.Models.FinalXmLContext _context;

        public IndexModel(FinalXmL.Models.FinalXmLContext context)
        {
            _context = context;
        }

        public IList<MunicipalityAdd> MunicipalityAdd { get;set; }

        public async Task OnGetAsync()
        {
            MunicipalityAdd = await _context.MunicipalityAdd.ToListAsync();
        }
    }
}
