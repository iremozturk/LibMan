using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibMan.Models.DB;
using Microsoft.AspNetCore.Http;

namespace LibMan.Pages
{
    public class IndexModel : PageModel
    {
        private readonly LibMan.Models.DB.LibraryContext _context;

        public IndexModel(LibMan.Models.DB.LibraryContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Msg { get; set; }
        public new IList<User> User { get; set; }
        public List<Books> Books { get; private set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
            Books = await _context.Books.ToListAsync();
        }
        private bool UserExists(string username, string password)
        {
            bool Email = false, pass = false;


            Email = _context.User.Any(e => e.Email == username);
            pass = _context.User.Any(e => e.Password == password);

            if (Email == true && pass == true)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        public IActionResult OnPost()
        {
            if (UserExists(Email, Password))
            {                 //HttpContext.Session.SetString("user", Username);             
                var user = _context.User.Single(a => a.Email == Email);
                HttpContext.Session.SetString("username", user.Email);
                // return RedirectToPage("Welcome");            
                return RedirectToPage("Welcome");
            }

            else
            {

                Msg = "Invalid";

                return Page();
            }
        }
    }
}

