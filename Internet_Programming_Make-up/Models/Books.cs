using System;
using System.Collections.Generic;

namespace Internet_Programming_Make_up.Models
{
    public partial class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int? GenreId { get; set; }

        public virtual Genres Genre { get; set; }
    }
}
