using System;
using System.Collections.Generic;

namespace LibMan.Models.DB
{
    public partial class Districts
    {
        public int Id { get; set; }
        public int? CityId { get; set; }
        public string District { get; set; }
    }
}
