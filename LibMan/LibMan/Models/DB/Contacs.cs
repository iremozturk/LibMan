using System;
using System.Collections.Generic;

namespace LibMan.Models.DB
{
    public partial class Contacs
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Zip { get; set; }
        public bool? IsActive { get; set; }
    }
}
