using LibMan.Models.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LibMan.Pages
{
    public class WelcomeModel : PageModel
    {
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public string Msg { get; set; }
        //public virtual DbSet<Books> Book { get; set; }
        public Books Book { get; set; }
        public IList<Books> Books { get; set; }
     
        public string Title { get; private set; }
        private readonly LibMan.Models.DB.LibraryContext _context;
        string Email;
        public WelcomeModel(LibMan.Models.DB.LibraryContext context)
        {
            _context = context;
        }
        public async Task OnGetAsync()
        {
            string e_mail = HttpContext.Session.GetString("username");
            if (string.IsNullOrEmpty(e_mail))
            {
                Books = new List<Books>();
                return;
            }
            
            var User = _context.User.SingleOrDefault(a => a.Email == e_mail);
            if (User == null)
            {
                Books = new List<Books>();
                return;
            }
            
            Email = User.Email;
            Books = await _context.Books.Where(b => b.UserMail == Email).ToListAsync();
            
            if (Books == null)
            {
                Books = new List<Books>();
            }
        }
      
        private bool BookExists(string Title)
        {
            bool usern = false;

            usern = _context.Books.Any(e => e.Title == Title);


            if (usern == true)
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
            if (BookExists(Title))
            {                 //HttpContext.Session.SetString("username", Username);  
                var cust = _context.Books.Single(a => a.Title == Title);
                HttpContext.Session.SetString("Title", cust.Title);
                // return RedirectToPage("Welcome");               
                return RedirectToPage("Welcome");
            }

            else
            {

                Msg = "Invalid";

                return Page();
            }
        }
        public IActionResult OnGetLogout() { 
            HttpContext.Session.Remove("username");
            return RedirectToPage("Index");
        }
    }
}