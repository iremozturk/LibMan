using System;
using System.Collections.Generic;

namespace LibMan.Models.DB
{
    public partial class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Password { get; set; }
    }
}
