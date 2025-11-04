using System;
using System.Collections.Generic;

namespace LibMan.Models.DB
{
    public partial class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int? Pages { get; set; }
        public string ReadingStatus { get; set; }
        public string UserMail { get; set; }
        public string Cover { get; set; }
    }
}
