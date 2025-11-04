using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibMan.Models.DB;

namespace LibMan.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly LibMan.Models.DB.LibraryContext _context;

        public DetailsModel(LibMan.Models.DB.LibraryContext context)
        {
            _context = context;
        }

        public Books Books { get; set; }
        public IList<Books> Book { get; set; }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Books = await _context.Books.FirstOrDefaultAsync(m => m.Title == id);

            if (Books == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
