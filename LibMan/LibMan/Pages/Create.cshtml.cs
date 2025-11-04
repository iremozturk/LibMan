using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LibMan.Models.DB;
using Microsoft.AspNetCore.Http;

namespace LibMan.Pages
{
    public class CreateModel : PageModel
    {
        private readonly LibMan.Models.DB.LibraryContext _context;

        public CreateModel(LibMan.Models.DB.LibraryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Books Books { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Set the UserMail from session
            string userEmail = HttpContext.Session.GetString("username");
            if (string.IsNullOrEmpty(userEmail))
            {
                return RedirectToPage("./Index");
            }
            Books.UserMail = userEmail;

            _context.Books.Add(Books);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Welcome");
        }
    }
}
